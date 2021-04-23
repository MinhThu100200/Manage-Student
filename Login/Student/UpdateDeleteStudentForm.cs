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
using Login.Properties;

namespace Login
{
    public partial class UpdateDeleteStudentForm : Form
    {
        public UpdateDeleteStudentForm()
        {
            InitializeComponent();
        }
        STUDENT student = new STUDENT();
        //Find by ID
        private void buttonFind_Click(object sender, EventArgs e)
        {
            //Convert text to Int
            int id = int.Parse(txtStudentId.Text);

            DataTable dt = student.getStudentId(id);
            
            if(dt.Rows.Count > 0)
            {
                txtFName.Text = dt.Rows[0]["FirstName"].ToString();
                txtLName.Text = dt.Rows[0]["LastName"].ToString();
                dateTimePickerBDate.Value = (DateTime)dt.Rows[0]["BirthDate"];

                //gender
                if(dt.Rows[0]["Gender"].ToString().Trim() == "Female")
                {
                    radioButtonGFemale.Checked = true;
                }    
                else
                {
                    radioButtonGMale.Checked = true;
                }

                txtNumberPhone.Text = dt.Rows[0]["Phone"].ToString();
                txtAddressStudent.Text = dt.Rows[0]["Address"].ToString();

                //picture
                byte[] pic = (byte[])dt.Rows[0]["Picture"];
                MemoryStream picture = new MemoryStream(pic);
                pictureBoxImageStudent.Image = Image.FromStream(picture);
                

            }   
            else
            {
                MessageBox.Show("Not found", "Find Student", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }    
        }
        
        //Check input char or not
        private void txtStudentId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }    
        }

        //Edit Infor Student
        private void buttonEdit_Click(object sender, EventArgs e)
        {
            int id;
            string fname = txtFName.Text;
            string lname = txtLName.Text;
            DateTime bdate = dateTimePickerBDate.Value;
            string phone = txtNumberPhone.Text;
            string address = txtAddressStudent.Text;
            string gender = "Male";

            //gender
            if(radioButtonGFemale.Checked)
            {
                gender = "Female";
            }

            MemoryStream pic = new MemoryStream();

            int born_year = dateTimePickerBDate.Value.Year;
            int this_year = DateTime.Now.Year;
            //Check age 
            if(((this_year - born_year) < 10) || ((this_year - born_year) > 100))
            {
                MessageBox.Show("The student age must be between 10 and 100 years", "Birth date error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if(verify())
            {
                try
                {
                    id = Convert.ToInt32(txtStudentId.Text);

                    pictureBoxImageStudent.Image.Save(pic, pictureBoxImageStudent.Image.RawFormat);

                    if(student.updateStudent(id, fname, lname, bdate, gender, phone, address, pic))
                    {
                        MessageBox.Show("Student information updated", "Edit student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Error", "Edit student", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "Edit student", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Empty fields", "Edit student", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            
        }

        //Remove Student by ID
        private void buttonRemove_Click(object sender, EventArgs e)
        {
           try
            {
                int studentId = int.Parse(txtStudentId.Text);
                if((MessageBox.Show("Are you sure you want to delete this student", "Delete student", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                {
                    if (student.deleteStudent(studentId))
                    {
                        MessageBox.Show("Student deleted", "Delete student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtStudentId.Text = "";
                        txtFName.Text = "";
                        txtLName.Text = "";
                        txtAddressStudent.Text = "";
                        txtNumberPhone.Text = "";
                        dateTimePickerBDate.Value = DateTime.Now;
                        pictureBoxImageStudent.Image = null;

                    }
                    else
                    {
                        MessageBox.Show("Student not deleted", "Delete student", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Please enter a valid ID", "Delete student", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        //upload image
        private void btnUploadImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Image(*.jpg;*.png;*.gif)|*.jpg;.png;*.gif";
            if((opf.ShowDialog() == DialogResult.OK))
            {
                pictureBoxImageStudent.Image = Image.FromFile(opf.FileName);
            }
        }
        //check input
        bool verify()
        {
            if ((txtFName.Text.Trim() == "") ||
                (txtLName.Text.Trim() == "") ||
                (txtNumberPhone.Text.Trim() == "") ||
                (txtAddressStudent.Text.Trim() == "") ||
                (txtStudentId.Text.Trim() == "") ||
                (pictureBoxImageStudent.Image == null))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

    }
}
