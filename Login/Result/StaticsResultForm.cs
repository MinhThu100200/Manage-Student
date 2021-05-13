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
                labelScorePython.Text = (avgByCourse.Rows[4][0].ToString() + ": " + avgByCourse.Rows[4][1].ToString());
                labelScoreSQL.Text = (avgByCourse.Rows[5][0].ToString() + ": " + avgByCourse.Rows[5][1].ToString());
                labelScoreWinfrom.Text = (avgByCourse.Rows[6][0].ToString() + ": " + avgByCourse.Rows[6][1].ToString());
                labelScoreR.Text = (avgByCourse.Rows[7][0].ToString() + ": " + avgByCourse.Rows[7][1].ToString());

            }
            catch(Exception )
            {

            }
            DataTable avgByResult = new DataTable();
            avgByResult = result.getAvgScoreByStudent();

            for(int sc = 0; sc <avgByResult.Rows.Count; sc ++)
            {
                float avgscore = 0;
                _ = float.TryParse(avgByResult.Rows[sc][1].ToString(), out avgscore);
                if ((avgscore) >= 5)
                {
                    dem = dem + 1;
                }
                Console.WriteLine(sc);
            }
            
            labelPass.Text = ("Pass: " + (float)100 * dem / allStudents.Rows.Count)+"%";
                labelFail.Text = ("Fail: " + (float)100 * (allStudents.Rows.Count - dem) / allStudents.Rows.Count)+"%";
                

        }
    }
}
