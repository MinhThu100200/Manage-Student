
namespace Login
{
    partial class RemoveScoreForm
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
            this.dataGridViewListScore = new System.Windows.Forms.DataGridView();
            this.buttonRemove = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListScore)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewListScore
            // 
            this.dataGridViewListScore.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewListScore.Location = new System.Drawing.Point(60, 41);
            this.dataGridViewListScore.Name = "dataGridViewListScore";
            this.dataGridViewListScore.RowHeadersWidth = 51;
            this.dataGridViewListScore.RowTemplate.Height = 24;
            this.dataGridViewListScore.Size = new System.Drawing.Size(680, 369);
            this.dataGridViewListScore.TabIndex = 25;
            // 
            // buttonRemove
            // 
            this.buttonRemove.BackColor = System.Drawing.Color.Red;
            this.buttonRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRemove.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonRemove.Location = new System.Drawing.Point(60, 436);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(183, 37);
            this.buttonRemove.TabIndex = 26;
            this.buttonRemove.Text = "Remove Score";
            this.buttonRemove.UseVisualStyleBackColor = false;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // RemoveScoreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 485);
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.dataGridViewListScore);
            this.Name = "RemoveScoreForm";
            this.Text = "RemoveScoreForm";
            this.Load += new System.EventHandler(this.RemoveScoreForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListScore)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewListScore;
        private System.Windows.Forms.Button buttonRemove;
    }
}