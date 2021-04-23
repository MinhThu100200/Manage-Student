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
    public partial class ManageCourseForm : Form
    {
        public ManageCourseForm()
        {
            InitializeComponent();
        }

        SCORE score = new SCORE();
        STUDENT student = new STUDENT();
        COURSE course = new COURSE();
       

        private void ManageCourseForm_Load(object sender, EventArgs e)
        {
            
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(textBoxIdCourse.Text);
                string label = textBoxLabelCourse.Text;
                string description = richTextBoxDescription.Text;
                int period = (int)numericUpDownHoursNumber.Value;
                if (course.checkId(id) == true)
                {
                    MessageBox.Show("ID đã tồn tại", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (verify() == true && course.insertCourse(id, label, period, description) == true)
                    {
                        MessageBox.Show("New Course Added", "Add Course", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Error", "Add Course", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                reloadData();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
        bool verify()
        {
            if ((textBoxIdCourse.Text.Trim() == "") ||
                (numericUpDownHoursNumber.Text.Trim() == "") ||
                (textBoxLabelCourse.Text.Trim() == "") ||
                (richTextBoxDescription.Text.Trim() == ""))

            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void ManageCourseForm_Load_1(object sender, EventArgs e)
        {
            reloadData();
        }
        //load data vao datagridview
        void reloadData()
        {
            dataGridViewListCourse.ReadOnly = true;
            dataGridViewListCourse.RowTemplate.Height = 80;
            dataGridViewListCourse.DataSource = course.getCourses();
            dataGridViewListCourse.AllowUserToAddRows = false;
            labelTotal.Text = ("Total Courses: " + dataGridViewListCourse.Rows.Count);
        }
        void showData(DataGridView data)
        {
            textBoxIdCourse.Text = "";
            textBoxLabelCourse.Text = "";
            numericUpDownHoursNumber.Value = 0;
            richTextBoxDescription.Text = "";
            //get the id student select
            textBoxIdCourse.Text = data.CurrentRow.Cells[0].Value.ToString();
            textBoxLabelCourse.Text = data.CurrentRow.Cells[1].Value.ToString();
            numericUpDownHoursNumber.Value = (int)data.CurrentRow.Cells[2].Value;
            richTextBoxDescription.Text = data.CurrentRow.Cells[3].Value.ToString();
        }
        private void dataGridViewListCourse_DoubleClick(object sender, EventArgs e)
        {
            showData(dataGridViewListCourse);
        }

        private void buttonAdd_Click_1(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(textBoxIdCourse.Text);
                string label = textBoxLabelCourse.Text;
                string description = richTextBoxDescription.Text;
                int period = (int)numericUpDownHoursNumber.Value;
                if (course.checkId(id) == true)
                {
                    MessageBox.Show("ID đã tồn tại", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (verify() == true && course.insertCourse(id, label, period, description) == true)
                    {
                        MessageBox.Show("New Course Added", "Add Course", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Error", "Add Course", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                reloadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            int id;
            string label;
            string description;
            int period;         

            if (verify())
            {
                try
                {
                    id = Int32.Parse(textBoxIdCourse.Text);
                    label = textBoxLabelCourse.Text;
                    period = (int)numericUpDownHoursNumber.Value;
                    description = richTextBoxDescription.Text;
                    if (course.editCourse(id, label, period, description))
                    {
                        MessageBox.Show("Course information updated", "Edit Course", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Error", "Edit Course", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Edit Course", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Empty fields", "Edit Course", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            reloadData();
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            try
            {
                int Id = int.Parse(textBoxIdCourse.Text);
                if ((MessageBox.Show("Are you sure you want to delete this Course", "Delete Course", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                {
                    if (course.deleteCourse(Id))
                    {
                        MessageBox.Show("Course deleted", "Delete Course", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        textBoxIdCourse.Text = "";
                        textBoxLabelCourse.Text = "";
                        numericUpDownHoursNumber.Value = 0;
                        richTextBoxDescription.Text = "";

                    }
                    else
                    {
                        MessageBox.Show("Course not deleted", "Delete Course", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Please enter a valid ID", "Delete Course", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            reloadData();
        }

        private void buttonFirst_Click(object sender, EventArgs e)
        {
            dataGridViewListCourse.ClearSelection();
           // dataGridViewListCourse.Rows[0].Cells[0].Selected = true;
            dataGridViewListCourse.CurrentCell = dataGridViewListCourse.Rows[0].Cells[0]; // change current cell
            showData(dataGridViewListCourse);
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            int indexCurrentRow = dataGridViewListCourse.CurrentRow.Index;
            if (indexCurrentRow < dataGridViewListCourse.Rows.Count - 1)
            {
                dataGridViewListCourse.CurrentCell = dataGridViewListCourse.Rows[indexCurrentRow + 1].Cells[0];
                showData(dataGridViewListCourse);
            } 
            else
            {
                dataGridViewListCourse.CurrentCell = dataGridViewListCourse.Rows[0].Cells[0];
                showData(dataGridViewListCourse);
            }    
                
        }

        private void buttonPrevious_Click(object sender, EventArgs e)
        {
            int indexCurrentRow = dataGridViewListCourse.CurrentRow.Index;
            int countRow = dataGridViewListCourse.Rows.Count;
            if (indexCurrentRow > 0)
            {
                dataGridViewListCourse.CurrentCell = dataGridViewListCourse.Rows[indexCurrentRow - 1].Cells[0];
                showData(dataGridViewListCourse);
            }
            else
            {
                dataGridViewListCourse.CurrentCell = dataGridViewListCourse.Rows[countRow - 1].Cells[0];
                showData(dataGridViewListCourse);
            }
        }

        private void buttonLast_Click(object sender, EventArgs e)
        {
            int countRow = dataGridViewListCourse.Rows.Count;
            dataGridViewListCourse.CurrentCell = dataGridViewListCourse.Rows[countRow - 1].Cells[0];
            showData(dataGridViewListCourse);
        }
    }
}
