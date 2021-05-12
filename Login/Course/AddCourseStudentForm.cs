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
    public partial class AddCourseStudentForm : Form
    {
        public AddCourseStudentForm()
        {
            InitializeComponent();
        }
        COURSE course = new COURSE();
        private void comboBoxSemester_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBoxIdStusent.Text);
            string semes = comboBoxSemester.SelectedItem.ToString();
            loadData(listBoxAvailable, listBoxSelected, id, semes);
        }
        public void loadData(ListBox avai, ListBox select, int id, string semes)
        {           
            //available
            avai.DataSource = course.getCoursesAvailible(id, semes);
            avai.ValueMember = "Id";
            avai.DisplayMember = "Label";
            avai.SelectedItem = null;
            //selected
            select.DataSource = course.getCoursesSelected(id, semes);
            select.ValueMember = "Id";
            select.DisplayMember = "Label";
            select.SelectedItem = null;
        }
        private void buttonSelect_Click(object sender, EventArgs e)
        {
            try
            {
                int studentid = Convert.ToInt32(textBoxIdStusent.Text);
                int courseid = (int)listBoxAvailable.SelectedValue;
                if(course.insertCourseStudent(courseid, studentid))
                {
                    int id = Convert.ToInt32(textBoxIdStusent.Text);
                    string semes = comboBoxSemester.SelectedItem.ToString();
                    loadData(listBoxAvailable, listBoxSelected, id, semes);
                }    
            }
            catch { }
            

        }
    }
}
