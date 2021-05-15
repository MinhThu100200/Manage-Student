using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class EditUserForm : Form
    {
        public EditUserForm()
        {
            InitializeComponent();
        }
        USER user = new USER();

        private void EditUserForm_Load(object sender, EventArgs e)
        {
            try
            {
                int userid = Global.GlobalUserID;

                DataTable dt = new DataTable();

                dt = user.getUserById(userid);

                txtIdStudent.Text = userid.ToString();
                txtFirstName.Text = dt.Rows[0][1].ToString();
                txtLastName.Text = dt.Rows[0][2].ToString();
                textBoxUsername.Text = dt.Rows[0][3].ToString();
                textBoxPassword.Text = dt.Rows[0][4].ToString();
                textBoxEmail.Text = dt.Rows[0][5].ToString();
                txtPhone.Text = dt.Rows[0][6].ToString();
                richTextBoxAddress.Text = dt.Rows[0][7].ToString();
                byte[] pic;
                pic = (byte[])dt.Rows[0][8];
                MemoryStream picture = new MemoryStream(pic);
                pictureBoxImg.Image = Image.FromStream(picture);
            }
            catch { }
            

        }

        private void btnUploadImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";
            if ((opf.ShowDialog() == DialogResult.OK))
            {
                pictureBoxImg.Image = Image.FromFile(opf.FileName);
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(txtIdStudent.Text);
                string fname = txtFirstName.Text;
                string lname = txtLastName.Text;
                string username = textBoxUsername.Text;
                string password = textBoxPassword.Text;
                string email = textBoxEmail.Text;
                string phone = txtPhone.Text;
                string addr = richTextBoxAddress.Text;


                MemoryStream pic = new MemoryStream();
                if ((user.checkUser(username, "edit") == false) && verify() == true)
                {
                    pictureBoxImg.Image.Save(pic, pictureBoxImg.Image.RawFormat);
                    if (user.updateUser(id, fname, lname, username, password, email, phone, addr, pic))
                    {
                        MessageBox.Show("Success!!!", "Edit Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Error", "Edit Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("You must fill all of them or Your username existed", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        bool verify()
        {
            if ((txtFirstName.Text.Trim() == "") ||
                (txtLastName.Text.Trim() == "") ||
                (txtPhone.Text.Trim() == "") ||
                (richTextBoxAddress.Text.Trim() == "") ||
                (pictureBoxImg.Image == null) ||
                (textBoxUsername.Text.Trim() == "") ||
                (textBoxPassword.Text.Trim() == "") ||
                (textBoxEmail.Text.Trim() == ""))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonDownload_Click(object sender, EventArgs e)
        {
            SaveFileDialog svf = new SaveFileDialog();
            svf.FileName = ("Contact" + txtFirstName.Text + txtLastName.Text );
            if ((pictureBoxImg.Image == null))
            {
                MessageBox.Show("No Image In The PictureBox");
            }
            else if ((svf.ShowDialog() == DialogResult.OK))
            {
                pictureBoxImg.Image.Save((svf.FileName + ("." + ImageFormat.Jpeg.ToString())));
            }
        }
    }
}
