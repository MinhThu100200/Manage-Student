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
    public partial class ContactForm : Form
    {
        public ContactForm()
        {
            InitializeComponent();
        }
        CONTACT contact = new CONTACT();
        USER user = new USER();
        GROUP group = new GROUP();
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
       
        private void ContactForm_Load(object sender, EventArgs e)
        {
            try
            {
                //img user
                int userid = Global.GlobalUserID;
                DataTable dt = new DataTable();
                dt = user.getUserById(userid);
                byte[] pic = (byte[])dt.Rows[0]["Picture"];
                MemoryStream picture = new MemoryStream(pic);
                pictureBoxImg.Image = Image.FromStream(picture);
                //lable welcom
                labelWelcome.Text = "Welcome " + dt.Rows[0]["Firstname"].ToString() + " " + dt.Rows[0]["Lastname"].ToString();
                //combox name group edit
                comboBoxSelectGroupEdit.DataSource = group.getGroupByUserId(Global.GlobalUserID);
                comboBoxSelectGroupEdit.DisplayMember = "Name";
                comboBoxSelectGroupEdit.ValueMember = "Id";
                comboBoxSelectGroupEdit.SelectedItem = null;
                //combox name group remove
                comboBoxSelectGroupRemove.DataSource = group.getGroupByUserId(Global.GlobalUserID);
                comboBoxSelectGroupRemove.DisplayMember = "Name";
                comboBoxSelectGroupRemove.ValueMember = "Id";
                comboBoxSelectGroupRemove.SelectedItem = null;
            }
            catch
            { }
            

        }
       
        private void buttonAddGroup_Click(object sender, EventArgs e)
        {

            try
            {
                DataTable dt = new DataTable();
                dt = group.getGroups();
                int id = dt.Rows.Count;
                string name = textBoxGroupName.Text;
                int userid = Global.GlobalUserID;
                if (!group.checkGroup(name, "add", id + 1, userid))
                {
                    if (group.insertGroup(8, name, userid))
                    {
                        MessageBox.Show("Success!!!", "Add Group", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Error", "Add Group", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("ID already exist, Try other id", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch
            {
                MessageBox.Show("You must fill in name of group", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonEditGroup_Click(object sender, EventArgs e)
        {
            try
            {

                int id = (int)comboBoxSelectGroupEdit.SelectedValue;
                string name = textBoxNewNameGroup.Text;
                if(!group.checkGroup(name, "edit", id))
                {
                    if (group.updateGroup(id, name))
                    {
                        MessageBox.Show("Success!!!", "Edit Group", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Error", "Edit Group", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }    
                else
                {
                    MessageBox.Show("ID not exist or you not permmited, Try other id", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }    
            }
            catch
            {
                MessageBox.Show("You must fill in name of group", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonRemoveGroup_Click(object sender, EventArgs e)
        {
            try
            {
                int id = (int)comboBoxSelectGroupRemove.SelectedValue;
                if(group.deleteGroup(id))
                {
                    MessageBox.Show("Success!!!", "Delete Group", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error", "Delete Group", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }    
            }
            catch 
            {
                MessageBox.Show("You must choose group to delete", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
