using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class AvgResultByScoreForm : Form
    {
        public AvgResultByScoreForm()
        {
            InitializeComponent();
        }
        STUDENT student = new STUDENT();
        RESULT result = new RESULT();
        COURSE course = new COURSE();
        private void AvgResultByScoreForm_Load(object sender, EventArgs e)
        {

            DataTable allStudents = student.getStudent();
            DataTable scoreOfCourse = result.getScoreOfCourse();
            DataTable newTable = new DataTable();
            DataTable allCourse = course.getCourses();
            
            
            newTable.Columns.Add("Student ID", typeof(System.Int32));
            newTable.Columns.Add("First name", typeof(System.String));
            newTable.Columns.Add("Last name", typeof(System.String));
            for(int n = 0; n < allCourse.Rows.Count; n++)
            {
                newTable.Columns.Add(allCourse.Rows[n][1].ToString(), typeof(float));
            }    
                       
            newTable.Columns.Add("Result", typeof(float));          
            for (int i = 0; i < allStudents.Rows.Count; i++)
            {
                DataTable scoreOfStudent = result.getScoreOfCourseByStudent(Convert.ToInt32(allStudents.Rows[i][0].ToString()));
                float[] terms = new float[scoreOfCourse.Rows.Count];
                               
                int[] a = new int[allCourse.Rows.Count];
                float avgScore = 0;
                int dem = 0;
                try
                {
                    for (int n = 0; n < allCourse.Rows.Count; n++)
                    {
                        for (int j = 0; j < scoreOfStudent.Rows.Count; j++)
                        {

                            if (scoreOfStudent.Rows[j][0].ToString() == allCourse.Rows[n][1].ToString())
                            {
                                a[n] = Convert.ToInt32(scoreOfStudent.Rows[j][1].ToString());
                                avgScore = avgScore + a[n];
                                dem++;
                                break;
                            }
                            else
                            {
                                a[n] = -1;
                            }
                        }
                        Console.WriteLine(a[n]);
                    }
                    newTable.Rows.Add(allStudents.Rows[i][0], allStudents.Rows[i][1], allStudents.Rows[i][2],
                        a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], avgScore / dem);
                }
                catch { }                                   
            }
            dataGridViewScoreOfCourse.ReadOnly = true;
            dataGridViewScoreOfCourse.RowTemplate.Height = 80;
            dataGridViewScoreOfCourse.DataSource = newTable;
            dataGridViewScoreOfCourse.AllowUserToAddRows = false;
            dataGridViewScoreOfCourse.Columns[0].Width = 50;
            dataGridViewScoreOfCourse.Columns[3].Width = 50;
            dataGridViewScoreOfCourse.Columns[4].Width = 50;
            dataGridViewScoreOfCourse.Columns[5].Width = 50;
            dataGridViewScoreOfCourse.Columns[6].Width = 50;
            dataGridViewScoreOfCourse.Columns[7].Width = 50;
            dataGridViewScoreOfCourse.Columns[8].Width = 50;
            dataGridViewScoreOfCourse.Columns[9].Width = 50;
            dataGridViewScoreOfCourse.Columns[10].Width = 50;
            dataGridViewScoreOfCourse.Columns[11].Width = 71;

        }

        private void buttonPrint_Click(object sender, EventArgs e)
        {
            PrintDialog printDlg = new PrintDialog();
            PrintDocument printDoc = new PrintDocument();
            printDoc.DocumentName = "Print Document";
            printDlg.Document = printDoc;
            printDlg.AllowSelection = true;
            printDlg.AllowSomePages = true;

            if (printDlg.ShowDialog() == DialogResult.OK) printDoc.Print();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string search = textBoxSearch.Text;
                DataTable dt = new DataTable();
                dt = result.searchStudentScore(search);
                txtIdStudent.Text = dt.Rows[0][0].ToString();
                txtFirstName.Text = dt.Rows[0][1].ToString();
                txtLastName.Text = dt.Rows[0][2].ToString();
            }
            catch
            { }

            
        }

        private void dataGridViewScoreOfCourse_DoubleClick(object sender, EventArgs e)
        {
            txtIdStudent.Text = dataGridViewScoreOfCourse.CurrentRow.Cells[0].Value.ToString();
            txtFirstName.Text = dataGridViewScoreOfCourse.CurrentRow.Cells[1].Value.ToString();
            txtLastName.Text = dataGridViewScoreOfCourse.CurrentRow.Cells[2].Value.ToString();
        }
    }
}

