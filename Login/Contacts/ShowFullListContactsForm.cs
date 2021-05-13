using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class ShowFullListContactsForm : Form
    {
        public ShowFullListContactsForm()
        {
            InitializeComponent();
        }
        CONTACT contact = new CONTACT();
        GROUP group = new GROUP();
        private void ShowFullListContactsForm_Load(object sender, EventArgs e)
        {

            //load data contact
            dataGridViewContacts.ReadOnly = true;
            SqlCommand command = new SqlCommand("SELECT Contact.Id, Firstname, Lastname, Groups.Name as 'Group', Phone, " +
                "Email, Address, Picture FROM Contact INNER JOIN Groups ON Contact.Group_id = Groups.Id WHERE " +
                "Contact.User_id = @userid");
            command.Parameters.Add("@userid", SqlDbType.Int).Value = Global.GlobalUserID;
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            dataGridViewContacts.RowTemplate.Height = 80;
            dataGridViewContacts.DataSource = contact.selectContactList(command);          
            picCol = (DataGridViewImageColumn)dataGridViewContacts.Columns[7];
            picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            dataGridViewContacts.AllowUserToAddRows = false;


            for (int i = 0; i < dataGridViewContacts.Rows.Count; i++)
            {
                if(isOdd(i))
                {
                    dataGridViewContacts.Rows[i].DefaultCellStyle.BackColor = Color.WhiteSmoke;
                }    
            }
            //load data listbox

            listBoxNameGroup.DataSource = group.getGroupByUserId(Global.GlobalUserID);
            listBoxNameGroup.DisplayMember = "Name";
            listBoxNameGroup.ValueMember = "Id";
            listBoxNameGroup.SelectedItem = null;
            dataGridViewContacts.ClearSelection();
        }
        public static bool isOdd(int value)
        {
            return value % 2 != 0;
        }

        private void listBoxNameGroup_Click(object sender, EventArgs e)
        {
            try
            {
                //load data contact
                int groupid = (int)listBoxNameGroup.SelectedValue;
                dataGridViewContacts.ReadOnly = true;
                SqlCommand command = new SqlCommand("SELECT Contact.Id, Firstname, Lastname, Groups.Name as 'Group', Phone, " +
                    "Email, Address, Picture FROM Contact INNER JOIN Groups ON Contact.Group_id = Groups.Id WHERE " +
                    "Contact.User_id = @userid AND Conatct.Group_id = @groupid");
                command.Parameters.Add("@userid", SqlDbType.Int).Value = Global.GlobalUserID;
                command.Parameters.Add("@groupid", SqlDbType.Int).Value = groupid;
                DataGridViewImageColumn picCol = new DataGridViewImageColumn();
                dataGridViewContacts.RowTemplate.Height = 80;
                dataGridViewContacts.DataSource = contact.selectContactList(command);
                picCol = (DataGridViewImageColumn)dataGridViewContacts.Columns[7];
                picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
                dataGridViewContacts.AllowUserToAddRows = false;


                for (int i = 0; i < dataGridViewContacts.Rows.Count; i++)
                {
                    if (isOdd(i))
                    {
                        dataGridViewContacts.Rows[i].DefaultCellStyle.BackColor = Color.WhiteSmoke;
                    }
                }
            }
            catch { }
            dataGridViewContacts.ClearSelection();
            

        }

        private void dataGridViewContacts_Click(object sender, EventArgs e)
        {
            try
            {
                richTextBoxAddress.Text = dataGridViewContacts.CurrentRow.Cells[6].Value.ToString();
            }
            catch { }
            
        }

        private void labelShowAll_Click(object sender, EventArgs e)
        {
            ShowFullListContactsForm_Load(null, null);
        }

        private void dataGridViewContacts_DoubleClick(object sender, EventArgs e)
        {
            ListStudentByContact frm = new ListStudentByContact();

            try
            {
                frm.txtContact.Text = dataGridViewContacts.CurrentRow.Cells[1].Value.ToString() + " " + dataGridViewContacts.CurrentRow.Cells[2].Value.ToString();
                byte[] pic = (byte[])dataGridViewContacts.CurrentRow.Cells[7].Value;
                MemoryStream picture = new MemoryStream(pic);
                frm.pictureBoxImg.Image = Image.FromStream(picture);
                frm.textBoxIdContact.Text = dataGridViewContacts.CurrentRow.Cells[0].Value.ToString();
            }
            catch { }
            frm.ShowDialog();
        }
    }
}
