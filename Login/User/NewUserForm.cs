using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class NewUserForm : Form
    {
        public NewUserForm()
        {
            InitializeComponent();
        }
        USER user = new USER();
        private void labelSignUp_Click(object sender, EventArgs e)
        {
            LoginForm frm = new LoginForm();
            frm.ShowDialog();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                
                string fname = txtFirstName.Text;
                string lname = txtLastName.Text;
                string username = textBoxUsername.Text;
                string password = textBoxPassword.Text;
                string email = textBoxEmail.Text;
                string phone = txtPhone.Text;
                string addr = richTextBoxAddress.Text;

                MemoryStream pic = new MemoryStream();
                if ((user.checkUser(username, "signup") == false) && verify() == true)
                {
                    pictureBoxImg.Image.Save(pic, pictureBoxImg.Image.RawFormat);
                    if(user.insertUser(fname, lname, username, password, email, phone, addr, pic))
                    {
                        MessageBox.Show("Success!!!", "Sign Up", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }    
                    else
                    {
                        MessageBox.Show("Error", "Sign Up", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        //Check input
        bool verify()
        {
            if ((txtFirstName.Text.Trim() == "") ||
                (txtLastName.Text.Trim() == "") ||
                (txtPhone.Text.Trim() == "") ||
                (richTextBoxAddress.Text.Trim() == "") ||
                (pictureBoxImg.Image == null)||
                (textBoxUsername.Text.Trim() == "")||
                (textBoxPassword.Text.Trim() == "")||
                (textBoxEmail.Text.Trim() == ""))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        //upload image
        private void btnUploadImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";
            if ((opf.ShowDialog() == DialogResult.OK))
            {
                pictureBoxImg.Image = Image.FromFile(opf.FileName);
            }
        }

        private void NewUserForm_Load(object sender, EventArgs e)
        {
            ToolTip toolTip1 = new ToolTip();

            // Set up the delays for the ToolTip.
            toolTip1.AutoPopDelay = 5000;
            toolTip1.InitialDelay = 100;
            toolTip1.ReshowDelay = 50;
            // Force the ToolTip text to be displayed whether or not the form is active.
            toolTip1.ShowAlways = true;
            //dung set thay vi thao tac trong properties
            toolTip1.SetToolTip(this.txtFirstName, "First name is not blank");
            toolTip1.SetToolTip(this.txtLastName, "Last name is not blank");
            toolTip1.SetToolTip(this.textBoxUsername, "Username is not blank");
            toolTip1.SetToolTip(this.textBoxPassword, "Password is not blank");
            toolTip1.SetToolTip(this.textBoxEmail, "Email is not blank");
            toolTip1.SetToolTip(this.txtPhone, "Phone is not blank");
            toolTip1.SetToolTip(this.txtIdStudent, "ID is not blank");
            toolTip1.SetToolTip(this.richTextBoxAddress, "Address is not blank");
            toolTip1.SetToolTip(this.pictureBoxImg, "Add your picture");
        }
    }
}
