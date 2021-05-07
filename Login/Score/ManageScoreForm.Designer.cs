
namespace Login
{
    partial class ManageScoreForm
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
            this.textBoxScore = new System.Windows.Forms.TextBox();
            this.buttonAvgScore = new System.Windows.Forms.Button();
            this.richTextBoxDescription = new System.Windows.Forms.RichTextBox();
            this.textBoxIdStudent = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewListStudent = new System.Windows.Forms.DataGridView();
            this.buttonShowScore = new System.Windows.Forms.Button();
            this.buttonShowStudent = new System.Windows.Forms.Button();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.comboBoxCourse = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListStudent)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxScore
            // 
            this.textBoxScore.Location = new System.Drawing.Point(149, 146);
            this.textBoxScore.Name = "textBoxScore";
            this.textBoxScore.Size = new System.Drawing.Size(204, 22);
            this.textBoxScore.TabIndex = 34;
            // 
            // buttonAvgScore
            // 
            this.buttonAvgScore.BackColor = System.Drawing.Color.DarkViolet;
            this.buttonAvgScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAvgScore.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonAvgScore.Location = new System.Drawing.Point(62, 392);
            this.buttonAvgScore.Name = "buttonAvgScore";
            this.buttonAvgScore.Size = new System.Drawing.Size(290, 37);
            this.buttonAvgScore.TabIndex = 33;
            this.buttonAvgScore.Text = "Average Score By Course";
            this.buttonAvgScore.UseVisualStyleBackColor = false;
            this.buttonAvgScore.Click += new System.EventHandler(this.buttonAvgScore_Click);
            // 
            // richTextBoxDescription
            // 
            this.richTextBoxDescription.Location = new System.Drawing.Point(148, 208);
            this.richTextBoxDescription.Name = "richTextBoxDescription";
            this.richTextBoxDescription.Size = new System.Drawing.Size(204, 96);
            this.richTextBoxDescription.TabIndex = 32;
            this.richTextBoxDescription.Text = "";
            // 
            // textBoxIdStudent
            // 
            this.textBoxIdStudent.Location = new System.Drawing.Point(148, 28);
            this.textBoxIdStudent.Name = "textBoxIdStudent";
            this.textBoxIdStudent.Size = new System.Drawing.Size(204, 22);
            this.textBoxIdStudent.TabIndex = 30;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(41, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 18);
            this.label4.TabIndex = 29;
            this.label4.Text = "Description :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(82, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 18);
            this.label3.TabIndex = 28;
            this.label3.Text = "Score :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(21, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 18);
            this.label2.TabIndex = 27;
            this.label2.Text = "Select Course :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(49, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 18);
            this.label1.TabIndex = 26;
            this.label1.Text = "Student ID :";
            // 
            // dataGridViewListStudent
            // 
            this.dataGridViewListStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewListStudent.Location = new System.Drawing.Point(392, 60);
            this.dataGridViewListStudent.Name = "dataGridViewListStudent";
            this.dataGridViewListStudent.RowHeadersWidth = 70;
            this.dataGridViewListStudent.RowTemplate.Height = 24;
            this.dataGridViewListStudent.Size = new System.Drawing.Size(701, 369);
            this.dataGridViewListStudent.TabIndex = 35;
            this.dataGridViewListStudent.DoubleClick += new System.EventHandler(this.dataGridViewListStudent_DoubleClick);
            // 
            // buttonShowScore
            // 
            this.buttonShowScore.BackColor = System.Drawing.Color.SlateGray;
            this.buttonShowScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonShowScore.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonShowScore.Location = new System.Drawing.Point(818, 17);
            this.buttonShowScore.Name = "buttonShowScore";
            this.buttonShowScore.Size = new System.Drawing.Size(274, 37);
            this.buttonShowScore.TabIndex = 36;
            this.buttonShowScore.Text = "Show Scores";
            this.buttonShowScore.UseVisualStyleBackColor = false;
            this.buttonShowScore.Click += new System.EventHandler(this.buttonShowScore_Click);
            // 
            // buttonShowStudent
            // 
            this.buttonShowStudent.BackColor = System.Drawing.Color.SlateGray;
            this.buttonShowStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonShowStudent.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonShowStudent.Location = new System.Drawing.Point(392, 17);
            this.buttonShowStudent.Name = "buttonShowStudent";
            this.buttonShowStudent.Size = new System.Drawing.Size(276, 37);
            this.buttonShowStudent.TabIndex = 37;
            this.buttonShowStudent.Text = "Show Students";
            this.buttonShowStudent.UseVisualStyleBackColor = false;
            this.buttonShowStudent.Click += new System.EventHandler(this.buttonShowStudent_Click);
            // 
            // buttonRemove
            // 
            this.buttonRemove.BackColor = System.Drawing.Color.Crimson;
            this.buttonRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRemove.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonRemove.Location = new System.Drawing.Point(242, 328);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(110, 37);
            this.buttonRemove.TabIndex = 38;
            this.buttonRemove.Text = "Remove";
            this.buttonRemove.UseVisualStyleBackColor = false;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonAdd.Location = new System.Drawing.Point(62, 328);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(110, 37);
            this.buttonAdd.TabIndex = 39;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // comboBoxCourse
            // 
            this.comboBoxCourse.FormattingEnabled = true;
            this.comboBoxCourse.Location = new System.Drawing.Point(148, 86);
            this.comboBoxCourse.Name = "comboBoxCourse";
            this.comboBoxCourse.Size = new System.Drawing.Size(204, 24);
            this.comboBoxCourse.TabIndex = 40;
            // 
            // ManageScoreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(1123, 450);
            this.Controls.Add(this.comboBoxCourse);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.buttonShowStudent);
            this.Controls.Add(this.buttonShowScore);
            this.Controls.Add(this.dataGridViewListStudent);
            this.Controls.Add(this.textBoxScore);
            this.Controls.Add(this.buttonAvgScore);
            this.Controls.Add(this.richTextBoxDescription);
            this.Controls.Add(this.textBoxIdStudent);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ManageScoreForm";
            this.Text = "ManageScoreForm";
            this.Load += new System.EventHandler(this.ManageScoreForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListStudent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxScore;
        private System.Windows.Forms.Button buttonAvgScore;
        private System.Windows.Forms.RichTextBox richTextBoxDescription;
        private System.Windows.Forms.TextBox textBoxIdStudent;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewListStudent;
        private System.Windows.Forms.Button buttonShowScore;
        private System.Windows.Forms.Button buttonShowStudent;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.ComboBox comboBoxCourse;
    }
}