
namespace Login
{
    partial class AvgScoreForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridViewAvgScore = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAvgScore)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewAvgScore
            // 
            this.dataGridViewAvgScore.BackgroundColor = System.Drawing.Color.LightSeaGreen;
            this.dataGridViewAvgScore.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAvgScore.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridViewAvgScore.Location = new System.Drawing.Point(12, 36);
            this.dataGridViewAvgScore.Name = "dataGridViewAvgScore";
            this.dataGridViewAvgScore.RowHeadersWidth = 51;
            this.dataGridViewAvgScore.RowTemplate.Height = 24;
            this.dataGridViewAvgScore.Size = new System.Drawing.Size(493, 277);
            this.dataGridViewAvgScore.TabIndex = 0;
            // 
            // AvgScoreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumTurquoise;
            this.ClientSize = new System.Drawing.Size(516, 323);
            this.Controls.Add(this.dataGridViewAvgScore);
            this.Name = "AvgScoreForm";
            this.Text = "AvgScoreForm";
            this.Load += new System.EventHandler(this.AvgScoreForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAvgScore)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewAvgScore;
    }
}