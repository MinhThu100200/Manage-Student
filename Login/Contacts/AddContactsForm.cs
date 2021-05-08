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
    public partial class AddContactsForm : Form
    {
        public AddContactsForm()
        {
            InitializeComponent();
        }
        MY_DB db = new MY_DB();
        CONTACT contact = new CONTACT();
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
                (comboBoxGroup.DisplayMember == "")||
                (textBoxEmail.Text.Trim() == ""))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void AddContactsForm_Load(object sender, EventArgs e)
        {
            GROUP group = new GROUP();


            comboBoxGroup.DataSource = group.getGroupByUserId(Global.GlobalUserID);
            comboBoxGroup.DisplayMember = "Name";
            comboBoxGroup.ValueMember = "Id";

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
            toolTip1.SetToolTip(this.textBoxEmail, "Email is not blank");
            toolTip1.SetToolTip(this.txtPhone, "Phone is not blank");
            toolTip1.SetToolTip(this.txtIdContact, "ID is not blank");
            toolTip1.SetToolTip(this.richTextBoxAddress, "Address is not blank");
            toolTip1.SetToolTip(this.pictureBoxImg, "Add your picture");

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtIdContact.Text);
            string fname = txtFirstName.Text;
            string lname = txtLastName.Text;
            string email = textBoxEmail.Text;
            string phone = txtPhone.Text;
            string addr = richTextBoxAddress.Text;
            int user_id = Global.GlobalUserID;
            try
            {
                int group_id = (int)comboBoxGroup.SelectedValue;
                MemoryStream pic = new MemoryStream();
                pictureBoxImg.Image.Save(pic, pictureBoxImg.Image.RawFormat);

                if ((verify() == true) && contact.checkContact(id, "add") == false)
                {
                    if (contact.insertContact(id, fname, lname, group_id, email, phone, addr, pic, user_id))
                    {
                        MessageBox.Show("New Contact Added", "Add Contact", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Error", "Add Contact", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("This ID Already Exists, Try Another One", "Invalid ID", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }          
            catch 
            { 

            }


        }
    }
}
