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
using Microsoft.Office.Interop.Word;

namespace Login
{
    public partial class ManageStudentsForm : Form
    {
        public ManageStudentsForm()
        {
            InitializeComponent();
        }
        STUDENT student = new STUDENT();
        private void ManageStudentsForm_Load(object sender, EventArgs e)
        {
            //Do data vao datagridview
            dataGridViewListStudent.ReadOnly = true;
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            dataGridViewListStudent.RowTemplate.Height = 80;
            dataGridViewListStudent.DataSource = student.getStudent();
            picCol = (DataGridViewImageColumn)dataGridViewListStudent.Columns[7];
            picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            dataGridViewListStudent.AllowUserToAddRows = false;
            //label total
            labelTotal.Text = ("Total Students: " + dataGridViewListStudent.Rows.Count);
            //tooltip
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
        //check input
        bool verify()
        {
            if ((txtFirstName.Text.Trim() == "") ||
                (txtLastName.Text.Trim() == "") ||
                (txtPhone.Text.Trim() == "") ||
                (txtAddress.Text.Trim() == "") ||
                (txtIdStudent.Text.Trim() == "") ||
                (pictureBoxStudent.Image == null))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
        //Add student
        private void buttonAdd_Click(object sender, EventArgs e)
        {
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
            if (((this_year - born_year) < 10) || ((this_year - born_year) > 100))
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
        //Load Img
        private void btnUploadImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";
            if ((opf.ShowDialog() == DialogResult.OK))
            {
                pictureBoxStudent.Image = Image.FromFile(opf.FileName);
            }
        }
        //Edit student
        private void buttonEdit_Click(object sender, EventArgs e)
        {
            int id;
            string fname = txtFirstName.Text;
            string lname = txtLastName.Text;
            DateTime bdate = dateTimePickerBirthDate.Value;
            string phone = txtPhone.Text;
            string address = txtAddress.Text;
            string gender = "Male";

            //gender
            if (radioButtonFemale.Checked)
            {
                gender = "Female";
            }

            MemoryStream pic = new MemoryStream();

            int born_year = dateTimePickerBirthDate.Value.Year;
            int this_year = DateTime.Now.Year;
            //Check age 
            if (((this_year - born_year) < 10) || ((this_year - born_year) > 100))
            {
                MessageBox.Show("The student age must be between 10 and 100 years", "Birth date error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (verify())
            {
                try
                {
                    id = Convert.ToInt32(txtIdStudent.Text);

                    pictureBoxStudent.Image.Save(pic, pictureBoxStudent.Image.RawFormat);

                    if (student.updateStudent(id, fname, lname, bdate, gender, phone, address, pic))
                    {
                        MessageBox.Show("Student information updated", "Edit student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Error", "Edit student", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Edit student", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Empty fields", "Edit student", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        //Remove student
        private void buttonRemove_Click(object sender, EventArgs e)
        {
            try
            {
                int studentId = int.Parse(txtIdStudent.Text);
                if ((MessageBox.Show("Are you sure you want to delete this student", "Delete student", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                {
                    if (student.deleteStudent(studentId))
                    {
                        MessageBox.Show("Student deleted", "Delete student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtIdStudent.Text = "";
                        txtFirstName.Text = "";
                        txtLastName.Text = "";
                        txtAddress.Text = "";
                        txtPhone.Text = "";
                        dateTimePickerBirthDate.Value = DateTime.Now;
                        pictureBoxStudent.Image = null;

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
        //Reset
        private void buttonReset_Click(object sender, EventArgs e)
        {
            txtIdStudent.Text = "";
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtPhone.Text = "";
            txtAddress.Text = "";
            pictureBoxStudent.Image = null;
            radioButtonMale.Checked = true;
            dateTimePickerBirthDate.Value = DateTime.Now.Date;
        }
        //search 
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            //Do data vao datagridview
            dataGridViewListStudent.ReadOnly = true;
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            dataGridViewListStudent.RowTemplate.Height = 80;
            dataGridViewListStudent.DataSource = student.getStudentSearch(textBoxSearch.Text);
            picCol = (DataGridViewImageColumn)dataGridViewListStudent.Columns[7];
            picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            dataGridViewListStudent.AllowUserToAddRows = false;
            //label total
            labelTotal.Text = ("Total Students: " + dataGridViewListStudent.Rows.Count);

        }
        //double click to fill in textbox
        private void dataGridViewListStudent_DoubleClick(object sender, EventArgs e)
        {
            UpdateDeleteStudentForm updateDeletefrm = new UpdateDeleteStudentForm();
            this.txtIdStudent.Text = dataGridViewListStudent.CurrentRow.Cells[0].Value.ToString();
            this.txtFirstName.Text = dataGridViewListStudent.CurrentRow.Cells[1].Value.ToString();
            this.txtLastName.Text = dataGridViewListStudent.CurrentRow.Cells[2].Value.ToString();
            this.dateTimePickerBirthDate.Value = (DateTime)dataGridViewListStudent.CurrentRow.Cells[3].Value;
            this.radioButtonMale.Checked = true;
            //gender
            if ((dataGridViewListStudent.CurrentRow.Cells[4].Value.ToString().Trim() == "Female"))
            {
                this.radioButtonFemale.Checked = true;
            }

            this.txtPhone.Text = dataGridViewListStudent.CurrentRow.Cells[5].Value.ToString();
            updateDeletefrm.txtAddressStudent.Text = dataGridViewListStudent.CurrentRow.Cells[6].Value.ToString();

            //picture student
            byte[] pic;
            pic = (byte[])dataGridViewListStudent.CurrentRow.Cells[7].Value;
            MemoryStream picture = new MemoryStream(pic);
            this.pictureBoxStudent.Image = Image.FromStream(picture);
          
        }

        private void buttonAddCourse_Click(object sender, EventArgs e)
        {
            AddCourseStudentForm frm = new AddCourseStudentForm();
            frm.ShowDialog();
        }
    }
}

    

