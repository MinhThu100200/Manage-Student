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
    public partial class ManageScoreForm : Form
    {
        public ManageScoreForm()
        {
            InitializeComponent();
        }

        SCORE score = new SCORE();
        STUDENT student = new STUDENT();
        COURSE course = new COURSE();
        private void ManageScoreForm_Load(object sender, EventArgs e)
        {
            //lay thong tin
            comboBoxCourse.DataSource = course.getCourses();
            comboBoxCourse.DisplayMember = "label";
            comboBoxCourse.ValueMember = "id";
            comboBoxCourse.SelectedItem = null;

            //datagridview
            dataGridViewListStudent.ReadOnly = true;
            dataGridViewListStudent.RowTemplate.Height = 80;
            dataGridViewListStudent.DataSource = student.getStudentWithSomeAtribute();
            dataGridViewListStudent.AllowUserToAddRows = false;

            
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            try
            {
                int idStudent = int.Parse(textBoxIdStudent.Text);
                int idCourse = (int)(comboBoxCourse.SelectedValue);

                if ((MessageBox.Show("Are you sure you want to delete this Score", "Delete Score", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                {
                    if (score.deleteScore(idStudent, idCourse))
                    {
                        MessageBox.Show("Score deleted", "Delete Score", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        textBoxScore.Text = "";
                        textBoxIdStudent.Text = "";
                        richTextBoxDescription.Text = "";

                    }
                    else
                    {
                        MessageBox.Show("Score not deleted", "Delete Score", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Please enter a valid ID", "Delete Score", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Add Score", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonAvgScore_Click(object sender, EventArgs e)
        {
            AvgScoreForm frm = new AvgScoreForm();
            frm.ShowDialog();
        }

        private void buttonShowStudent_Click(object sender, EventArgs e)
        {
            //datagridview
            dataGridViewListStudent.ReadOnly = true;
            dataGridViewListStudent.RowTemplate.Height = 80;
            dataGridViewListStudent.DataSource = student.getStudentWithSomeAtribute();
            dataGridViewListStudent.AllowUserToAddRows = false;
            dataGridViewListStudent.Columns[0].HeaderText = "ID";
            //dataGridViewListStudent.Columns[0].Width = 90;
            dataGridViewListStudent.Columns[1].HeaderText = "Firstname";
            dataGridViewListStudent.Columns[2].HeaderText = "Lastname";
        }

        private void buttonShowScore_Click(object sender, EventArgs e)
        {
            //datagridview
            dataGridViewListStudent.ReadOnly = true;
            dataGridViewListStudent.RowTemplate.Height = 80;
            dataGridViewListStudent.DataSource = score.getScore();
            dataGridViewListStudent.AllowUserToAddRows = false;
            dataGridViewListStudent.Columns[0].HeaderText = "ID Student";
            //dataGridViewListStudent.Columns[0].Width = 90;
            dataGridViewListStudent.Columns[1].HeaderText = "ID Course";
            dataGridViewListStudent.Columns[2].HeaderText = "Score Student";
            dataGridViewListStudent.Columns[3].HeaderText = "Descriptions";
        }

        private void dataGridViewListStudent_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //get id
            textBoxIdStudent.Text = dataGridViewListStudent.CurrentRow.Cells[0].Value.ToString();
        }
    }
}
