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
    public partial class AddScoreForm : Form
    {
        public AddScoreForm()
        {
            InitializeComponent();
        }
        SCORE score = new SCORE();
        STUDENT student = new STUDENT();
        COURSE course = new COURSE();
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxIdStudent.Text != "")
                {
                    int student_id = Int32.Parse(textBoxIdStudent.Text);
                    int course_id = (int)comboBoxCourse.SelectedValue;
                    float score_student = Convert.ToInt32(textBoxScore.Text);
                    string description = richTextBoxDescription.Text;
                    if (!score.studentScoreExist(student_id, course_id))
                    {
                        if (score.insertScore(student_id, course_id, score_student, description))
                        {
                            MessageBox.Show("New Course Added", "Add Score", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Error", "Add Score", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("The score for this course are already set", "Add Score", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
                else
                {
                    MessageBox.Show("Bạn nên nhập đầy đủ thông tin", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Add Score", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        

        private void AddScoreForm_Load(object sender, EventArgs e)
        {
            //lay thong tin
            comboBoxCourse.DataSource = course.getCourses();
            comboBoxCourse.DisplayMember = "label";
            comboBoxCourse.ValueMember = "id";

            //datagridview
            dataGridViewListStudent.ReadOnly = true;
            dataGridViewListStudent.RowTemplate.Height = 80;
            dataGridViewListStudent.DataSource = student.getStudentWithSomeAtribute();
            dataGridViewListStudent.AllowUserToAddRows = false;
        }

        private void dataGridViewListScore_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //get the id student select
            textBoxIdStudent.Text = dataGridViewListStudent.CurrentRow.Cells[0].Value.ToString();
        }
    }

}
