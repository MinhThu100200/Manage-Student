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
using Word = Microsoft.Office.Interop.Word;

namespace Login
{
    public partial class AddStudent : Form
    {
        public AddStudent()
        {
            InitializeComponent();
        }

        //cancel
        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        //Add student
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            STUDENT student = new STUDENT();
            int id = Convert.ToInt32(txtIdStudent.Text);
            string fname = txtFirstName.Text;
            string lnaem = txtLastName.Text;
            DateTime bdate = dateTimePickerBirthDate.Value;
            string phone = txtPhone.Text;
            string adrs = txtAddress.Text;
            string gender = "Male";
            
            //gender
            if (radioButtonFemale.Checked)
            {
                gender = "Female";
            }

            MemoryStream pic = new MemoryStream();
            int born_year = dateTimePickerBirthDate.Value.Year;
            int this_year = DateTime.Now.Year;

            //check age
            if ( ((this_year - born_year) < 10) || ((this_year - born_year) > 100) )
            {
                MessageBox.Show("The student age must be between 10 and 100 year", "Invalid Birth Date", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }    
            else if (verify())
            {
                pictureBoxStudent.Image.Save(pic, pictureBoxStudent.Image.RawFormat);
                if (student.insertStudent(id, fname, lnaem, bdate, gender, phone, adrs, pic))
                {
                    MessageBox.Show("New student Added", "Add Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }  
                else
                {
                    MessageBox.Show("Error", "Add Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }                    
            }    
        }

        //Check input
        bool verify()
        {
            if ((txtFirstName.Text.Trim() == "") ||
                (txtLastName.Text.Trim() == "") ||
                (txtPhone.Text.Trim() == "") ||
                (txtAddress.Text.Trim() == "") ||
                (txtIdStudent.Text.Trim() == "")||
                (pictureBoxStudent.Image == null))
            {
                return false;
            }
            else
            {
                return true;
            }    
        }

        //upload image
        private void btnUploadImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";
            if ((opf.ShowDialog() == DialogResult.OK))
            {
                pictureBoxStudent.Image = Image.FromFile(opf.FileName);
            }    
        }

        private void buttonexport_Click(object sender, EventArgs e)
        {

        }

        private void AddStudent_Load(object sender, EventArgs e)
        {
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
            toolTip1.SetToolTip(this.txtPhone, "Phone is not blank");
            toolTip1.SetToolTip(this.txtIdStudent, "ID is not blank");
            toolTip1.SetToolTip(this.txtAddress, "Address is not blank");
            toolTip1.SetToolTip(this.pictureBoxStudent, "Add your picture");    
        }
    }
}
