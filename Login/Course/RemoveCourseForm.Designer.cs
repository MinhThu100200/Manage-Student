
namespace Login
{
    partial class RemoveCourseForm
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
            this.buttonRemoveCourse = new System.Windows.Forms.Button();
            this.txtIdCourse = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonRemoveCourse
            // 
            this.buttonRemoveCourse.BackColor = System.Drawing.Color.Crimson;
            this.buttonRemoveCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRemoveCourse.Location = new System.Drawing.Point(364, 27);
            this.buttonRemoveCourse.Name = "buttonRemoveCourse";
            this.buttonRemoveCourse.Size = new System.Drawing.Size(155, 33);
            this.buttonRemoveCourse.TabIndex = 34;
            this.buttonRemoveCourse.Text = "Remove";
            this.buttonRemoveCourse.UseVisualStyleBackColor = false;
            this.buttonRemoveCourse.Click += new System.EventHandler(this.buttonRemoveCourse_Click);
            // 
            // txtIdCourse
            // 
            this.txtIdCourse.Location = new System.Drawing.Point(193, 32);
            this.txtIdCourse.Name = "txtIdCourse";
            this.txtIdCourse.Size = new System.Drawing.Size(154, 22);
            this.txtIdCourse.TabIndex = 33;
            this.txtIdCourse.TextChanged += new System.EventHandler(this.txtIdCourse_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(5, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 17);
            this.label1.TabIndex = 32;
            this.label1.Text = "Enter The Course\'s ID";
            // 
            // RemoveCourseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(520, 82);
            this.Controls.Add(this.buttonRemoveCourse);
            this.Controls.Add(this.txtIdCourse);
            this.Controls.Add(this.label1);
            this.Name = "RemoveCourseForm";
            this.Text = "RemoveCourseForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonRemoveCourse;
        private System.Windows.Forms.TextBox txtIdCourse;
        private System.Windows.Forms.Label label1;
    }
}