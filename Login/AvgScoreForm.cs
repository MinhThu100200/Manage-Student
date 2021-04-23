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
    public partial class AvgScoreForm : Form
    {
        public AvgScoreForm()
        {
            InitializeComponent();
        }
        SCORE score = new SCORE();
        private void AvgScoreForm_Load(object sender, EventArgs e)
        {
            //datagridview
            dataGridViewAvgScore.ReadOnly = true;
            dataGridViewAvgScore.RowTemplate.Height = 80;
            dataGridViewAvgScore.DataSource = score.getAvgScoreByCourse();
            dataGridViewAvgScore.AllowUserToAddRows = false;
        }
    }
}
