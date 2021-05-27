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
    public partial class RemoveScoreForm : Form
    {
        public RemoveScoreForm()
        {
            InitializeComponent();
        }
        SCORE score = new SCORE();
        private void RemoveScoreForm_Load(object sender, EventArgs e)
        {

            //datagridview
            dataGridViewListScore.ReadOnly = true;
            dataGridViewListScore.RowTemplate.Height = 80;
            dataGridViewListScore.DataSource = score.getStudentAndScore();
            dataGridViewListScore.AllowUserToAddRows = false;
            dataGridViewListScore.Columns[0].HeaderText = "ID Student";
            dataGridViewListScore.Columns[5].HeaderText = "Score Student";
            dataGridViewListScore.Columns[3].HeaderText = "ID Course";
            dataGridViewListScore.Columns[0].Width = 67;
            dataGridViewListScore.Columns[1].Width = 75;
            dataGridViewListScore.Columns[2].Width = 75;
            dataGridViewListScore.Columns[4].Width = 150;
            dataGridViewListScore.Columns[3].Width = 69;
            dataGridViewListScore.Columns[5].Width = 67;

        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            try
            {
                int idStudent = (int)dataGridViewListScore.CurrentRow.Cells[0].Value;
                int idCourse = (int)(dataGridViewListScore.CurrentRow.Cells[3].Value);

                if ((MessageBox.Show("Are you sure you want to delete this score", "Delete Score", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                {
                    if (score.deleteScore(idStudent, idCourse))
                    {
                        MessageBox.Show("Score deleted", "Delete Score", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //datagridview
                        dataGridViewListScore.ReadOnly = true;
                        dataGridViewListScore.RowTemplate.Height = 80;
                        dataGridViewListScore.DataSource = score.getStudentAndScore();
                        dataGridViewListScore.AllowUserToAddRows = false;


                    }
                    else
                    {
                        MessageBox.Show("Score not deleted", "Delete Score", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Please enter a valid ID", "Delete Score", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
