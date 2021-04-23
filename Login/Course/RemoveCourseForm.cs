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
    public partial class RemoveCourseForm : Form
    {
        public RemoveCourseForm()
        {
            InitializeComponent();
        }

        private void txtIdCourse_TextChanged(object sender, EventArgs e)
        {
            
        }
        COURSE course = new COURSE();
        private void buttonRemoveCourse_Click(object sender, EventArgs e)
        {
            try
            {
                int Id = int.Parse(txtIdCourse.Text);
                if ((MessageBox.Show("Are you sure you want to delete this Course", "Delete Course", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                {
                    if (course.deleteCourse(Id))
                    {
                        MessageBox.Show("Course deleted", "Delete Course", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtIdCourse.Text = "";

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
        }
    }
}
