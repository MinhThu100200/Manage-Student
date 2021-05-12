using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class SelectContactsForm : Form
    {
        public SelectContactsForm()
        {
            InitializeComponent();
        }

        private void SelectContactsForm_Load(object sender, EventArgs e)
        {
            CONTACT contact = new CONTACT();
            SqlCommand command = new SqlCommand("SELECT  Id ,  Firstname,  Lastname,  group_id  as'group id' FROM  Contact  WHERE  User_id  = @uid");
            command.Parameters.Add("@uid", SqlDbType.Int).Value = Global.GlobalUserID;
            dataGridViewContact.DataSource = contact.selectContactList(command);
        }

        private void dataGridViewContact_DoubleClick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

