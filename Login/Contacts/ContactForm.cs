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
        }
    }
}
