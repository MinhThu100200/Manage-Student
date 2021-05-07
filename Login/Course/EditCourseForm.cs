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
    public partial class EditCourseForm : Form
    {
        public EditCourseForm()
        {
            InitializeComponent();
        }
        COURSE course = new COURSE();
        private void buttonEditCourse_Click(object sender, EventArgs e)
        {           
            int id;
            string label;
            string description;
            int period;
            if (txtIdCourse.Text == "")
            {
                id = (int)comboBoxCourse.SelectedValue;
                label = comboBoxCourse.Text;
                period = (int)numericUpDownPeriod.Value;
                description = richTextBoxDescription.Text;
            }
            else
            {
                id = Convert.ToInt32(txtIdCourse.Text);
                label = txtLabel.Text;
                period = (int)numericUpDownPeriod.Value;
                description = richTextBoxDescription.Text;
            }    
                         
            if(verify())
            {
                try
                {
                    if(course.editCourse(id, label, period, description))
                    {
                        MessageBox.Show("Course information updated", "Edit Course", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }    
                    else
                    {
                        MessageBox.Show("Error", "Edit Course", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }    
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "Edit Course", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Empty fields", "Edit Course", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }
        bool verify()
        {
            if ((numericUpDownPeriod.Text.Trim() == "") ||
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
       // COURSE course = new COURSE();
        
        private void EditCourseForm_Load(object sender, EventArgs e)
        {
            comboBoxCourse.DataSource = course.getCourses();
            comboBoxCourse.DisplayMember = "Label";
            comboBoxCourse.ValueMember = "Id";

            comboBoxCourse.SelectedItem = null;
        }
        private void fillCombo(int index)
        {
            comboBoxCourse.DataSource = course.getCourses();
            comboBoxCourse.DisplayMember = "Label";
            comboBoxCourse.ValueMember = "id";
            comboBoxCourse.SelectedIndex = index;
        }

        private void comboBoxCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(comboBoxCourse.SelectedValue);
                DataTable tb = new DataTable();
                tb = course.getCourseById(id);
                txtLabel.Text = tb.Rows[0][1].ToString();
                numericUpDownPeriod.Value = Int32.Parse(tb.Rows[0][2].ToString());
                richTextBoxDescription.Text = tb.Rows[0][3].ToString();
            }
            catch { }
        }
    }
}
