using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class ContactForm : Form
    {
        public ContactForm()
        {
            InitializeComponent();
        }
        CONTACT contact = new CONTACT();
        private void buttonShowFullList_Click(object sender, EventArgs e)
        {
            ShowFullListContactsForm frm = new ShowFullListContactsForm();
            frm.ShowDialog();
        }

        private void buttonAddContact_Click(object sender, EventArgs e)
        {
            AddContactsForm frm = new AddContactsForm();
            frm.ShowDialog();
        }

        private void buttonEditContact_Click(object sender, EventArgs e)
        {
            EditContactsForm frm = new EditContactsForm();
            frm.ShowDialog();
        }

        private void buttonSelectContact_Click(object sender, EventArgs e)
        {
            SelectContactsForm frm = new SelectContactsForm();
            frm.ShowDialog();
            try
            {
                int contactId = Convert.ToInt32(frm.dataGridViewContact.CurrentRow.Cells[0].Value.ToString());
                textBoxContactId.Text = contactId.ToString();
            }
            catch { }
        }

        private void labelEditUser_Click(object sender, EventArgs e)
        {
            EditUserForm frm = new EditUserForm();
            frm.ShowDialog();
        }

        private void labelLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginForm frm = new LoginForm();
            frm.ShowDialog();
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            try
            {
                
                if (textBoxContactId.Text != "" )
                {
                    int idContact = Convert.ToInt32(textBoxContactId.Text);
                    if(contact.deleteContact(idContact))
                    {
                        MessageBox.Show("Success!!!", "Delete Contact", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }    
                    else
                    {
                        MessageBox.Show("Error", "Delete Contact", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }    
                }    
                else
                {
                    MessageBox.Show("You must Select contact!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }    
                
            }
            catch { }
        }
    }
}
