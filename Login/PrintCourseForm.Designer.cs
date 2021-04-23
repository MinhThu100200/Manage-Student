
namespace Login
{
    partial class PrintCourseForm
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
            this.dataGridViewListCourse = new System.Windows.Forms.DataGridView();
            this.buttonToFile = new System.Windows.Forms.Button();
            this.buttonPrint = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListCourse)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewListCourse
            // 
            this.dataGridViewListCourse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewListCourse.Location = new System.Drawing.Point(24, 34);
            this.dataGridViewListCourse.Name = "dataGridViewListCourse";
            this.dataGridViewListCourse.RowHeadersWidth = 51;
            this.dataGridViewListCourse.RowTemplate.Height = 24;
            this.dataGridViewListCourse.Size = new System.Drawing.Size(1009, 389);
            this.dataGridViewListCourse.TabIndex = 0;
            this.dataGridViewListCourse.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewListCourse_CellContentClick);
            // 
            // buttonToFile
            // 
            this.buttonToFile.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonToFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonToFile.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonToFile.Location = new System.Drawing.Point(24, 449);
            this.buttonToFile.Name = "buttonToFile";
            this.buttonToFile.Size = new System.Drawing.Size(122, 41);
            this.buttonToFile.TabIndex = 1;
            this.buttonToFile.Text = "To File";
            this.buttonToFile.UseVisualStyleBackColor = false;
            this.buttonToFile.Click += new System.EventHandler(this.buttonToFile_Click);
            // 
            // buttonPrint
            // 
            this.buttonPrint.BackColor = System.Drawing.Color.OliveDrab;
            this.buttonPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPrint.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonPrint.Location = new System.Drawing.Point(207, 449);
            this.buttonPrint.Name = "buttonPrint";
            this.buttonPrint.Size = new System.Drawing.Size(130, 41);
            this.buttonPrint.TabIndex = 2;
            this.buttonPrint.Text = "Print";
            this.buttonPrint.UseVisualStyleBackColor = false;
            this.buttonPrint.Click += new System.EventHandler(this.buttonPrint_Click);
            // 
            // PrintCourseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1053, 531);
            this.Controls.Add(this.buttonPrint);
            this.Controls.Add(this.buttonToFile);
            this.Controls.Add(this.dataGridViewListCourse);
            this.Name = "PrintCourseForm";
            this.Text = "PrintCourseForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListCourse)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewListCourse;
        private System.Windows.Forms.Button buttonToFile;
        private System.Windows.Forms.Button buttonPrint;
    }
}