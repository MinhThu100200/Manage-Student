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
    public partial class AddCourseForm : Form
    {
        public AddCourseForm()
        {
            InitializeComponent();
        }

        private void buttonAddCourse_Click(object sender, EventArgs e)
        {
            COURSE course = new COURSE();
            try 
            {
                int id = Convert.ToInt32(txtIdCourse.Text);
                string label = txtLabel.Text;
                string description = richTextBoxDescription.Text;
                int period = (int)numericUpDownPeriod.Value;
                string semes = comboBoxSemester.SelectedItem.ToString();
                if (course.checkId(id) == true)
                {
                    MessageBox.Show("ID đã tồn tại", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (verify() == true && course.insertCourse(id, label, period, description, semes) == true)
                    {
                        MessageBox.Show("New Course Added", "Add Course", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Error", "Add Course", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch { }
           
        }
        bool verify()
        {
            if ((txtIdCourse.Text.Trim() == "") ||
                (numericUpDownPeriod.Text.Trim() == "") ||
                (txtLabel.Text.Trim() == "") ||
                (richTextBoxDescription.Text.Trim() == ""))
                
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void AddCourseForm_Load(object sender, EventArgs e)
        {
            
        }
    }
}
