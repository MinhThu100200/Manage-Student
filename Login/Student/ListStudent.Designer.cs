namespace Login
{
    partial class ListStudent
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
            this.dataGridViewListStudent = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.buttonSaveToText = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListStudent)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewListStudent
            // 
            this.dataGridViewListStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewListStudent.Location = new System.Drawing.Point(15, 66);
            this.dataGridViewListStudent.Name = "dataGridViewListStudent";
            this.dataGridViewListStudent.RowHeadersWidth = 51;
            this.dataGridViewListStudent.RowTemplate.Height = 24;
            this.dataGridViewListStudent.Size = new System.Drawing.Size(1164, 359);
            this.dataGridViewListStudent.TabIndex = 0;
            this.dataGridViewListStudent.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewListStudent_CellContentClick);
            this.dataGridViewListStudent.DoubleClick += new System.EventHandler(this.dataGridViewListStudent_DoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(458, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(307, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "DANH SÁCH HỌC SINH";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label4.Location = new System.Drawing.Point(12, 471);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(216, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Nguyễn Thị Minh Thư_18128062";
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonRefresh.Location = new System.Drawing.Point(745, 431);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(102, 36);
            this.buttonRefresh.TabIndex = 12;
            this.buttonRefresh.Text = "Refresh";
            this.buttonRefresh.UseVisualStyleBackColor = false;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // buttonSaveToText
            // 
            this.buttonSaveToText.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonSaveToText.Location = new System.Drawing.Point(384, 431);
            this.buttonSaveToText.Name = "buttonSaveToText";
            this.buttonSaveToText.Size = new System.Drawing.Size(114, 36);
            this.buttonSaveToText.TabIndex = 13;
            this.buttonSaveToText.Text = "Save To Text";
            this.buttonSaveToText.UseVisualStyleBackColor = false;
            this.buttonSaveToText.Click += new System.EventHandler(this.buttonSaveToText_Click);
            // 
            // ListStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1191, 494);
            this.Controls.Add(this.buttonSaveToText);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewListStudent);
            this.Name = "ListStudent";
            this.Text = "ListStudent";
            this.Load += new System.EventHandler(this.ListStudent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListStudent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewListStudent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.Button buttonSaveToText;
    }
}