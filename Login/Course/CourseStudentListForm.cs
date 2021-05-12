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
    public partial class CourseStudentListForm : Form
    {
        public CourseStudentListForm()
        {
            InitializeComponent();
        }

        COURSE course = new COURSE();
        private void CourseStudentListForm_Load(object sender, EventArgs e)
        {
            
            
                string label = textBoxCourse.Text;
                string semester = textBoxSemester.Text;

                DataTable dt = new DataTable();
                dt = course.getIdStudentByLable(label, semester);
                dataGridViewStudentList.ReadOnly = true;
                dataGridViewStudentList.DataSource = dt;
               
            
        }
    }
}
