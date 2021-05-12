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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        //Login
        private void btnSignIn_Click(object sender, EventArgs e)
        {
            MY_DB db = new MY_DB();
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable dt = new DataTable();
            SqlCommand command = new SqlCommand("SELECT * FROM Users WHERE Username = @username AND Password = @password", db.getConnection);
            command.Parameters.Add("@username", SqlDbType.NVarChar).Value = txtUsername.Text;
            command.Parameters.Add("@password", SqlDbType.NVarChar).Value = txtPassword.Text;

            adapter.SelectCommand = command;
            adapter.Fill(dt);


            if ((dt.Rows.Count > 0))
            {
                int userid = Convert.ToInt32(dt.Rows[0][0].ToString());
                Global.SetGlobalUserID(userid);
                this.DialogResult = DialogResult.OK;
                //MessageBox.Show("Bắt đầu nào!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                if (radioButtonHuman.Checked)
                {
                    ContactForm frm = new ContactForm();
                    frm.ShowDialog();
                }
                else if( radioButtonStudent.Checked)
                {
                    Main main = new Main();
                    main.ShowDialog();
                }
                else
                {
                    MessageBox.Show("You must choose STUDENT or HUMAN RESOURCE", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    this.Show();
                }
            }    
            else
            {
                if (txtUsername.Text == "")
                {
                    CreateControls();
                   
                }
                else if (txtPassword.Text == "")
                {
                    CreateControlsPass();

                }             
                MessageBox.Show("Invalid Username or Password", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

            ToolTip toolTip1 = new ToolTip();

            // Set up the delays for the ToolTip.
            toolTip1.AutoPopDelay = 5000;
            toolTip1.InitialDelay = 100;
            toolTip1.ReshowDelay = 50;
            // Force the ToolTip text to be displayed whether or not the form is active.
            toolTip1.ShowAlways = true;
            //dung set thay vi thao tac trong properties
            toolTip1.SetToolTip(this.txtUsername, "User name is not blank");
            toolTip1.SetToolTip(this.txtPassword, "Password is not blank");
        }

        void CreateControls()
        {
            ErrorProvider ep = new ErrorProvider();

            ep.BlinkStyle = ErrorBlinkStyle.BlinkIfDifferentError;
          
           
            ep.SetError(txtUsername, "Blank is not valid");
            this.Controls.Add(txtUsername);


        }
        void CreateControlsPass()
        {
            ErrorProvider ep = new ErrorProvider();

            ep.BlinkStyle = ErrorBlinkStyle.BlinkIfDifferentError;


            ep.SetError(txtPassword, "Blank is not valid");
            
            this.Controls.Add(txtPassword);


        }

        

        private void txtUsername_Validated(object sender, EventArgs e)
        {
           
        }

        private void labelNewUser_Click(object sender, EventArgs e)
        {
            NewUserForm frm = new NewUserForm();
            frm.ShowDialog();
        }

        private void checkBoxShowPass_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !txtPassword.UseSystemPasswordChar;
        }

        private void labelAboutMe_Click(object sender, EventArgs e)
        {
            AboutMeForm frm = new AboutMeForm();
            frm.ShowDialog();
        }
    }
}
