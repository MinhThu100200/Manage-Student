
namespace Login
{
    partial class EditCourseForm
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
            this.numericUpDownPeriod = new System.Windows.Forms.NumericUpDown();
            this.buttonEditCourse = new System.Windows.Forms.Button();
            this.richTextBoxDescription = new System.Windows.Forms.RichTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtLabel = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxCourse = new System.Windows.Forms.ComboBox();
            this.txtIdCourse = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPeriod)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDownPeriod
            // 
            this.numericUpDownPeriod.Location = new System.Drawing.Point(160, 119);
            this.numericUpDownPeriod.Name = "numericUpDownPeriod";
            this.numericUpDownPeriod.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownPeriod.TabIndex = 42;
            // 
            // buttonEditCourse
            // 
            this.buttonEditCourse.BackColor = System.Drawing.Color.Teal;
            this.buttonEditCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditCourse.Location = new System.Drawing.Point(27, 328);
            this.buttonEditCourse.Name = "buttonEditCourse";
            this.buttonEditCourse.Size = new System.Drawing.Size(435, 33);
            this.buttonEditCourse.TabIndex = 41;
            this.buttonEditCourse.Text = "EDIT";
            this.buttonEditCourse.UseVisualStyleBackColor = false;
            this.buttonEditCourse.Click += new System.EventHandler(this.buttonEditCourse_Click);
            // 
            // richTextBoxDescription
            // 
            this.richTextBoxDescription.Location = new System.Drawing.Point(160, 177);
            this.richTextBoxDescription.Name = "richTextBoxDescription";
            this.richTextBoxDescription.Size = new System.Drawing.Size(302, 96);
            this.richTextBoxDescription.TabIndex = 40;
            this.richTextBoxDescription.Text = "";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(24, 177);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 17);
            this.label8.TabIndex = 39;
            this.label8.Text = "Description";
            // 
            // txtLabel
            // 
            this.txtLabel.Location = new System.Drawing.Point(160, 72);
            this.txtLabel.Name = "txtLabel";
            this.txtLabel.Size = new System.Drawing.Size(302, 22);
            this.txtLabel.TabIndex = 38;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(59, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 17);
            this.label3.TabIndex = 36;
            this.label3.Text = "Period";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(66, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 35;
            this.label2.Text = "Label";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(35, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 17);
            this.label1.TabIndex = 34;
            this.label1.Text = "Course ID";
            // 
            // comboBoxCourse
            // 
            this.comboBoxCourse.FormattingEnabled = true;
            this.comboBoxCourse.Location = new System.Drawing.Point(328, 31);
            this.comboBoxCourse.Name = "comboBoxCourse";
            this.comboBoxCourse.Size = new System.Drawing.Size(134, 24);
            this.comboBoxCourse.TabIndex = 44;
            this.comboBoxCourse.SelectedIndexChanged += new System.EventHandler(this.comboBoxCourse_SelectedIndexChanged);
            // 
            // txtIdCourse
            // 
            this.txtIdCourse.Location = new System.Drawing.Point(160, 31);
            this.txtIdCourse.Name = "txtIdCourse";
            this.txtIdCourse.Size = new System.Drawing.Size(143, 22);
            this.txtIdCourse.TabIndex = 37;
            // 
            // EditCourseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(491, 376);
            this.Controls.Add(this.comboBoxCourse);
            this.Controls.Add(this.numericUpDownPeriod);
            this.Controls.Add(this.buttonEditCourse);
            this.Controls.Add(this.richTextBoxDescription);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtLabel);
            this.Controls.Add(this.txtIdCourse);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "EditCourseForm";
            this.Text = "EditCourseForm";
            this.Load += new System.EventHandler(this.EditCourseForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPeriod)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericUpDownPeriod;
        private System.Windows.Forms.Button buttonEditCourse;
        private System.Windows.Forms.RichTextBox richTextBoxDescription;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxCourse;
        private System.Windows.Forms.TextBox txtIdCourse;
    }
}