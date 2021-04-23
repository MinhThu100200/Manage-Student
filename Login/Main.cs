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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void addNewStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddStudent frm = new AddStudent();
            frm.ShowDialog();
        }

        private void studentListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListStudent frm = new ListStudent();
            frm.ShowDialog();
        }

        private void editRemoveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateDeleteStudentForm form = new UpdateDeleteStudentForm();
            form.ShowDialog();
        }

        private void staticsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StaticsForm frm = new StaticsForm();
            frm.ShowDialog();
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintForm frm = new PrintForm();
            frm.ShowDialog();
        }

        private void mangeStudentFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageStudentsForm frm = new ManageStudentsForm();
            frm.ShowDialog();
        }

        private void addCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddCourseForm frm = new AddCourseForm();
            frm.ShowDialog();
        }

        private void editCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditCourseForm frm = new EditCourseForm();
            frm.ShowDialog();
        }

        private void removeCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RemoveCourseForm frm = new RemoveCourseForm();
            frm.ShowDialog();
        }

        private void manageCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageCourseForm frm = new ManageCourseForm();
            frm.ShowDialog();
        }

        private void printToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            PrintCourseForm frm = new PrintCourseForm();
            frm.ShowDialog();
        }

        private void addScoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddScoreForm frm = new AddScoreForm();
            frm.ShowDialog();
        }

        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RemoveScoreForm frm = new RemoveScoreForm();
            frm.ShowDialog();
        }

        private void manageScoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageScoreForm frm = new ManageScoreForm();
            frm.ShowDialog();
        }

        private void avgScoreByCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AvgScoreForm frm = new AvgScoreForm();
            frm.ShowDialog();
        }

        private void aVGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AvgResultByScoreForm frm = new AvgResultByScoreForm();
            frm.ShowDialog();
        }
    }
}
