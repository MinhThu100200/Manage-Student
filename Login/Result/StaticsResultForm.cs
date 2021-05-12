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
    public partial class StaticsResultForm : Form
    {
        public StaticsResultForm()
        {
            InitializeComponent();
        }

        SCORE score = new SCORE();
        RESULT result = new RESULT();
        STUDENT student = new STUDENT();
        private void buttonDrawChart_Click(object sender, EventArgs e)
        {
            ChartResultForm frm = new ChartResultForm();
            frm.ShowDialog();
        }

        private void StaticsResultForm_Load(object sender, EventArgs e)
        {
            DataTable avgByCourse = score.getAvgScoreByCourse();
            DataTable allStudents = student.getStudent();
            int dem = 0;
            try
            {
                labelScoreC.Text = (avgByCourse.Rows[0][0].ToString() + ": " + avgByCourse.Rows[0][1].ToString());
                labelScoreJava.Text = (avgByCourse.Rows[1][0].ToString() + ": " + avgByCourse.Rows[1][1].ToString());
                labelScoreML.Text = (avgByCourse.Rows[2][0].ToString() + ": " + avgByCourse.Rows[2][1].ToString());
                labelScoreAI.Text = (avgByCourse.Rows[3][0].ToString() + ": " + avgByCourse.Rows[3][1].ToString());
                for (int i = 0; i<allStudents.Rows.Count; i++)
                {
                    DataTable avgByResult = result.getAvgScoreByStudent(Convert.ToInt32(allStudents.Rows[i][0].ToString()));
                    if (Convert.ToInt32(avgByResult.Rows[0][0].ToString()) >= 5)
                    {
                        dem = dem + 1;
                    }
                }
                labelPass.Text = ("Pass: " + (float)100 * dem / allStudents.Rows.Count);
                labelFail.Text = ("Fail: " + (float)100 * (allStudents.Rows.Count - dem) / allStudents.Rows.Count);
                
            }
            catch(Exception )
            {

            }

        }
    }
}
