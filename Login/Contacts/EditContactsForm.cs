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
    public partial class EditContactsForm : Form
    {
        public EditContactsForm()
        {
            InitializeComponent();
        }
        MY_DB db = new MY_DB();
        CONTACT contact = new CONTACT();
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
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
        bool verify()
        {
            if ((txtFirstName.Text.Trim() == "") ||
                (txtLastName.Text.Trim() == "") ||
                (txtPhone.Text.Trim() == "") ||
                (richTextBoxAddress.Text.Trim() == "") ||
                (pictureBoxImg.Image == null) ||
                (comboBoxGroup.DisplayMember == "") ||
                (textBoxEmail.Text.Trim() == ""))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            
            string fname = txtFirstName.Text;
            string lname = txtLastName.Text;
            string email = textBoxEmail.Text;
            string phone = txtPhone.Text;
            string addr = richTextBoxAddress.Text;
            
            try
            {
                int id = Convert.ToInt32(txtIdContact.Text);
                int group_id = (int)comboBoxGroup.SelectedValue;
                MemoryStream pic = new MemoryStream();
                pictureBoxImg.Image.Save(pic, pictureBoxImg.Image.RawFormat);

                if ((verify() == true) && contact.checkContact(id, "edit") == false)
                {
                    if (contact.updateContact(id, fname, lname, group_id, email, phone, addr, pic))
                    {
                        MessageBox.Show("Success!", "Edit Contact", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Error", "Edit Contact", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("This ID Not Exists, Try Another One Or You must fill in all of textboxes", "Invalid ID", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            catch
            {

            }
        }

        private void EditContactsForm_Load(object sender, EventArgs e)
        {
            GROUP group = new GROUP();


            comboBoxGroup.DataSource = group.getGroupByUserId(Global.GlobalUserID);
            comboBoxGroup.DisplayMember = "Name";
            comboBoxGroup.ValueMember = "Id";
            comboBoxGroup.SelectedItem = null;

        }

        private void buttonSelectContact_Click(object sender, EventArgs e)
        {
            SelectContactsForm frm = new SelectContactsForm();
            frm.ShowDialog();

            try 
            {
                int contactId = Convert.ToInt32(frm.dataGridViewContact.CurrentRow.Cells[0].Value.ToString());

                CONTACT contact = new CONTACT();
                DataTable table = contact.getContactById(contactId);

                txtIdContact.Text = table.Rows[0]["Id"].ToString();
                txtFirstName.Text = table.Rows[0]["Firstname"].ToString();
                txtLastName.Text = table.Rows[0]["Lastname"].ToString();
                comboBoxGroup.SelectedValue = table.Rows[0]["group_id"];
                txtPhone.Text = table.Rows[0]["Phone"].ToString();
                textBoxEmail.Text = table.Rows[0]["Email"].ToString();
                richTextBoxAddress.Text = table.Rows[0]["Address"].ToString();

                byte[] pic = (byte[])table.Rows[0]["Picture"];
                MemoryStream picture = new MemoryStream(pic);
                pictureBoxImg.Image = Image.FromStream(picture);

            }
            catch (Exception)
            {

            }

        }
            
    }
}
