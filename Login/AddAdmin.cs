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
    public partial class AddAdmin : Form
    {
        public AddAdmin()
        {
            InitializeComponent();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonSignUp_Click(object sender, EventArgs e)
        {
            Admin ad = new Admin();

            int id = int.Parse(textBoxID.Text);
            string username = textBoxUsername.Text;
            string password = textBoxPassword.Text;
            string email = textBoxEmail.Text;

            if (verify() == true)
            {
                if (ad.insertAdmin(id, username, password, email))
                {
                    MessageBox.Show("New admin Added", "Add Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error", "Add Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }    

        }
        public bool verify()
        {
            if ((textBoxID.Text.Trim() == "") ||
                (textBoxUsername.Text.Trim() == "") ||
                (textBoxPassword.Text.Trim() == ""))
               
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void AddAdmin_Load(object sender, EventArgs e)
        {
            ToolTip toolTip1 = new ToolTip();

            // Set up the delays for the ToolTip.
            toolTip1.AutoPopDelay = 5000;
            toolTip1.InitialDelay = 100;
            toolTip1.ReshowDelay = 50;
            // Force the ToolTip text to be displayed whether or not the form is active.
            toolTip1.ShowAlways = true;
            //dung set thay vi thao tac trong properties
            toolTip1.SetToolTip(this.textBoxUsername, "User name is not blank");
            toolTip1.SetToolTip(this.textBoxPassword, "Password must be 6-10 characters");
            toolTip1.SetToolTip(this.textBoxEmail, "Email is not blank");
            toolTip1.SetToolTip(this.textBoxID, "ID is not blank");
        }
    }
}
