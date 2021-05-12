namespace Login
{
    partial class UpdateDeleteStudentForm
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
            this.dateTimePickerBDate = new System.Windows.Forms.DateTimePicker();
            this.txtFName = new System.Windows.Forms.TextBox();
            this.txtLName = new System.Windows.Forms.TextBox();
            this.txtStudentId = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioButtonGFemale = new System.Windows.Forms.RadioButton();
            this.radioButtonGMale = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNumberPhone = new System.Windows.Forms.TextBox();
            this.txtAddressStudent = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.pictureBoxImageStudent = new System.Windows.Forms.PictureBox();
            this.buttonFind = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.btnUploadImage = new System.Windows.Forms.Button();
            this.buttonAddCourse = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImageStudent)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePickerBDate
            // 
            this.dateTimePickerBDate.Location = new System.Drawing.Point(168, 172);
            this.dateTimePickerBDate.Name = "dateTimePickerBDate";
            this.dateTimePickerBDate.Size = new System.Drawing.Size(302, 22);
            this.dateTimePickerBDate.TabIndex = 27;
            // 
            // txtFName
            // 
            this.txtFName.Location = new System.Drawing.Point(168, 79);
            this.txtFName.Name = "txtFName";
            this.txtFName.Size = new System.Drawing.Size(302, 22);
            this.txtFName.TabIndex = 25;
            // 
            // txtLName
            // 
            this.txtLName.Location = new System.Drawing.Point(168, 123);
            this.txtLName.Name = "txtLName";
            this.txtLName.Size = new System.Drawing.Size(302, 22);
            this.txtLName.TabIndex = 24;
            // 
            // txtStudentId
            // 
            this.txtStudentId.Location = new System.Drawing.Point(168, 38);
            this.txtStudentId.Name = "txtStudentId";
            this.txtStudentId.Size = new System.Drawing.Size(302, 22);
            this.txtStudentId.TabIndex = 22;
            this.txtStudentId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtStudentId_KeyPress);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioButtonGFemale);
            this.panel1.Controls.Add(this.radioButtonGMale);
            this.panel1.Location = new System.Drawing.Point(168, 207);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(302, 44);
            this.panel1.TabIndex = 21;
            // 
            // radioButtonGFemale
            // 
            this.radioButtonGFemale.AutoSize = true;
            this.radioButtonGFemale.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonGFemale.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.radioButtonGFemale.Location = new System.Drawing.Point(164, 13);
            this.radioButtonGFemale.Name = "radioButtonGFemale";
            this.radioButtonGFemale.Size = new System.Drawing.Size(81, 21);
            this.radioButtonGFemale.TabIndex = 1;
            this.radioButtonGFemale.TabStop = true;
            this.radioButtonGFemale.Text = "Female";
            this.radioButtonGFemale.UseVisualStyleBackColor = true;
            // 
            // radioButtonGMale
            // 
            this.radioButtonGMale.AutoSize = true;
            this.radioButtonGMale.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonGMale.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.radioButtonGMale.Location = new System.Drawing.Point(13, 13);
            this.radioButtonGMale.Name = "radioButtonGMale";
            this.radioButtonGMale.Size = new System.Drawing.Size(63, 21);
            this.radioButtonGMale.TabIndex = 0;
            this.radioButtonGMale.TabStop = true;
            this.radioButtonGMale.Text = "Male";
            this.radioButtonGMale.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(43, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 17);
            this.label5.TabIndex = 20;
            this.label5.Text = "Gender";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(43, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 17);
            this.label4.TabIndex = 19;
            this.label4.Text = "BirthDate";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(43, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 17);
            this.label3.TabIndex = 18;
            this.label3.Text = "Last Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(43, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 17);
            this.label2.TabIndex = 17;
            this.label2.Text = "First Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(43, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 17);
            this.label1.TabIndex = 16;
            this.label1.Text = "Student ID";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(43, 268);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 17);
            this.label8.TabIndex = 26;
            this.label8.Text = "Phone";
            // 
            // txtNumberPhone
            // 
            this.txtNumberPhone.Location = new System.Drawing.Point(168, 268);
            this.txtNumberPhone.Name = "txtNumberPhone";
            this.txtNumberPhone.Size = new System.Drawing.Size(302, 22);
            this.txtNumberPhone.TabIndex = 23;
            // 
            // txtAddressStudent
            // 
            this.txtAddressStudent.Location = new System.Drawing.Point(617, 40);
            this.txtAddressStudent.Multiline = true;
            this.txtAddressStudent.Name = "txtAddressStudent";
            this.txtAddressStudent.Size = new System.Drawing.Size(302, 61);
            this.txtAddressStudent.TabIndex = 30;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(492, 119);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 17);
            this.label7.TabIndex = 29;
            this.label7.Text = "Picture";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(492, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 17);
            this.label6.TabIndex = 28;
            this.label6.Text = "Address";
            // 
            // buttonRemove
            // 
            this.buttonRemove.BackColor = System.Drawing.Color.Gold;
            this.buttonRemove.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonRemove.Location = new System.Drawing.Point(541, 342);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(147, 35);
            this.buttonRemove.TabIndex = 33;
            this.buttonRemove.Text = "Remove";
            this.buttonRemove.UseVisualStyleBackColor = false;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.BackColor = System.Drawing.Color.Green;
            this.buttonEdit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonEdit.Location = new System.Drawing.Point(295, 337);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(147, 35);
            this.buttonEdit.TabIndex = 32;
            this.buttonEdit.Text = "Edit";
            this.buttonEdit.UseVisualStyleBackColor = false;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // pictureBoxImageStudent
            // 
            this.pictureBoxImageStudent.BackColor = System.Drawing.Color.SkyBlue;
            this.pictureBoxImageStudent.Location = new System.Drawing.Point(617, 119);
            this.pictureBoxImageStudent.Name = "pictureBoxImageStudent";
            this.pictureBoxImageStudent.Size = new System.Drawing.Size(302, 164);
            this.pictureBoxImageStudent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxImageStudent.TabIndex = 31;
            this.pictureBoxImageStudent.TabStop = false;
            // 
            // buttonFind
            // 
            this.buttonFind.BackColor = System.Drawing.Color.Maroon;
            this.buttonFind.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonFind.Location = new System.Drawing.Point(46, 337);
            this.buttonFind.Name = "buttonFind";
            this.buttonFind.Size = new System.Drawing.Size(147, 35);
            this.buttonFind.TabIndex = 34;
            this.buttonFind.Text = "Find";
            this.buttonFind.UseVisualStyleBackColor = false;
            this.buttonFind.Click += new System.EventHandler(this.buttonFind_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.MistyRose;
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label10.Location = new System.Drawing.Point(12, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(216, 17);
            this.label10.TabIndex = 36;
            this.label10.Text = "Nguyễn Thị Minh Thư_18128062";
            // 
            // btnUploadImage
            // 
            this.btnUploadImage.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnUploadImage.Location = new System.Drawing.Point(617, 289);
            this.btnUploadImage.Name = "btnUploadImage";
            this.btnUploadImage.Size = new System.Drawing.Size(302, 29);
            this.btnUploadImage.TabIndex = 37;
            this.btnUploadImage.Text = "Upload Image";
            this.btnUploadImage.UseVisualStyleBackColor = true;
            this.btnUploadImage.Click += new System.EventHandler(this.btnUploadImage_Click);
            // 
            // buttonAddCourse
            // 
            this.buttonAddCourse.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonAddCourse.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonAddCourse.Location = new System.Drawing.Point(772, 342);
            this.buttonAddCourse.Name = "buttonAddCourse";
            this.buttonAddCourse.Size = new System.Drawing.Size(147, 35);
            this.buttonAddCourse.TabIndex = 38;
            this.buttonAddCourse.Text = "Add Course";
            this.buttonAddCourse.UseVisualStyleBackColor = false;
            this.buttonAddCourse.Click += new System.EventHandler(this.buttonAddCourse_Click);
            // 
            // UpdateDeleteStudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(947, 389);
            this.Controls.Add(this.buttonAddCourse);
            this.Controls.Add(this.btnUploadImage);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.buttonFind);
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.pictureBoxImageStudent);
            this.Controls.Add(this.txtAddressStudent);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dateTimePickerBDate);
            this.Controls.Add(this.txtFName);
            this.Controls.Add(this.txtLName);
            this.Controls.Add(this.txtStudentId);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtNumberPhone);
            this.Name = "UpdateDeleteStudentForm";
            this.Text = "UpdateDeleteStudentForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImageStudent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.Button buttonEdit;
        public System.Windows.Forms.TextBox txtStudentId;
        public System.Windows.Forms.DateTimePicker dateTimePickerBDate;
        public System.Windows.Forms.TextBox txtFName;
        public System.Windows.Forms.TextBox txtLName;
        public System.Windows.Forms.RadioButton radioButtonGFemale;
        public System.Windows.Forms.RadioButton radioButtonGMale;
        public System.Windows.Forms.TextBox txtNumberPhone;
        public System.Windows.Forms.PictureBox pictureBoxImageStudent;
        public System.Windows.Forms.TextBox txtAddressStudent;
        private System.Windows.Forms.Button buttonFind;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnUploadImage;
        private System.Windows.Forms.Button buttonAddCourse;
    }
}