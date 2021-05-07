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
            SqlCommand command = new SqlCommand("SELECT * FROM Admin WHERE Username = @User AND Password = @Pass", db.getConnection);
            command.Parameters.Add("@User", SqlDbType.NVarChar).Value = txtUsername.Text;
            command.Parameters.Add("@Pass", SqlDbType.NVarChar).Value = txtPassword.Text;
            adapter.SelectCommand = command;
            adapter.Fill(dt);


            if ((dt.Rows.Count > 0))
            {
                this.DialogResult = DialogResult.OK;
                MessageBox.Show("Bắt đầu nào!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                Main main = new Main();              
                main.ShowDialog();
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

        private void buttonSignUp_Click(object sender, EventArgs e)
        {
           
        }
    }
}
