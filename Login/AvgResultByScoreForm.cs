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
                
                int j = 0;
                if (scoreOfStudent.Rows.Count == allCourse.Rows.Count)
                {
                    //for(int j = 0; j < scoreOfStudent.Rows.Count; j++)
                    //{
                    //    terms[j] = (float)Convert.ToInt32(scoreOfStudent.Rows[j][1].ToString());                        
                    //}
                    newTable.Rows.Add(allStudents.Rows[i][0], allStudents.Rows[i][1], allStudents.Rows[i][2], scoreOfStudent.Rows[j][1], scoreOfStudent.Rows[j + 1][1], scoreOfStudent.Rows[j + 2][1],
                       (float)(Convert.ToInt32(scoreOfStudent.Rows[j][1].ToString()) + Convert.ToInt32(scoreOfStudent.Rows[j + 1][1].ToString()) + Convert.ToInt32(scoreOfStudent.Rows[j + 2][1].ToString())) / 3);
                }    
                else if(scoreOfStudent.Rows.Count < allCourse.Rows.Count)
                {

                }

                
                                   
            }
            dataGridViewScoreOfCourse.ReadOnly = true;
            dataGridViewScoreOfCourse.RowTemplate.Height = 80;
            dataGridViewScoreOfCourse.DataSource = newTable;
            dataGridViewScoreOfCourse.AllowUserToAddRows = false;

        
        }
    }
}

