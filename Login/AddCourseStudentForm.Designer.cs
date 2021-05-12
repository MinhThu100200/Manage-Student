
namespace Login
{
    partial class AddCourseStudentForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxIdStusent = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxSemester = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.listBoxAvailable = new System.Windows.Forms.ListBox();
            this.buttonSelect = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.listBoxSelected = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(13, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student ID:";
            // 
            // textBoxIdStusent
            // 
            this.textBoxIdStusent.Location = new System.Drawing.Point(112, 44);
            this.textBoxIdStusent.Name = "textBoxIdStusent";
            this.textBoxIdStusent.Size = new System.Drawing.Size(139, 22);
            this.textBoxIdStusent.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(360, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Semester:";
            // 
            // comboBoxSemester
            // 
            this.comboBoxSemester.FormattingEnabled = true;
            this.comboBoxSemester.Location = new System.Drawing.Point(462, 42);
            this.comboBoxSemester.Name = "comboBoxSemester";
            this.comboBoxSemester.Size = new System.Drawing.Size(92, 24);
            this.comboBoxSemester.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(29, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Course Available:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(360, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Courses Selected:";
            // 
            // listBoxAvailable
            // 
            this.listBoxAvailable.FormattingEnabled = true;
            this.listBoxAvailable.ItemHeight = 16;
            this.listBoxAvailable.Location = new System.Drawing.Point(33, 192);
            this.listBoxAvailable.Name = "listBoxAvailable";
            this.listBoxAvailable.Size = new System.Drawing.Size(190, 132);
            this.listBoxAvailable.TabIndex = 6;
            // 
            // buttonSelect
            // 
            this.buttonSelect.BackColor = System.Drawing.Color.DimGray;
            this.buttonSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSelect.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonSelect.Location = new System.Drawing.Point(241, 192);
            this.buttonSelect.Name = "buttonSelect";
            this.buttonSelect.Size = new System.Drawing.Size(107, 28);
            this.buttonSelect.TabIndex = 7;
            this.buttonSelect.Text = "Add";
            this.buttonSelect.UseVisualStyleBackColor = false;
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttonSave.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonSave.Location = new System.Drawing.Point(241, 296);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(107, 28);
            this.buttonSave.TabIndex = 8;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = false;
            // 
            // listBoxSelected
            // 
            this.listBoxSelected.FormattingEnabled = true;
            this.listBoxSelected.ItemHeight = 16;
            this.listBoxSelected.Location = new System.Drawing.Point(364, 192);
            this.listBoxSelected.Name = "listBoxSelected";
            this.listBoxSelected.Size = new System.Drawing.Size(190, 132);
            this.listBoxSelected.TabIndex = 9;
            // 
            // AddCourseStudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(582, 334);
            this.Controls.Add(this.listBoxSelected);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonSelect);
            this.Controls.Add(this.listBoxAvailable);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxSemester);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxIdStusent);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Name = "AddCourseStudentForm";
            this.Text = "AddCourseStudentForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxIdStusent;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxSemester;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listBoxAvailable;
        private System.Windows.Forms.Button buttonSelect;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.ListBox listBoxSelected;
    }
}