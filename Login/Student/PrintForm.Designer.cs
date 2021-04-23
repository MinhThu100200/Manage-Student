
namespace Login
{
    partial class PrintForm
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
            this.buttonSaveToText = new System.Windows.Forms.Button();
            this.buttonPrint = new System.Windows.Forms.Button();
            this.dataGridViewListStudent = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dateTimePickerTo = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePickerFrom = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButtonNo = new System.Windows.Forms.RadioButton();
            this.radioButtonYes = new System.Windows.Forms.RadioButton();
            this.radioButtonFemale = new System.Windows.Forms.RadioButton();
            this.radioButtonMale = new System.Windows.Forms.RadioButton();
            this.radioButtonAll = new System.Windows.Forms.RadioButton();
            this.buttonCheck = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListStudent)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonSaveToText
            // 
            this.buttonSaveToText.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonSaveToText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSaveToText.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonSaveToText.Location = new System.Drawing.Point(370, 480);
            this.buttonSaveToText.Name = "buttonSaveToText";
            this.buttonSaveToText.Size = new System.Drawing.Size(149, 36);
            this.buttonSaveToText.TabIndex = 16;
            this.buttonSaveToText.Text = "Save To Text";
            this.buttonSaveToText.UseVisualStyleBackColor = false;
            this.buttonSaveToText.Click += new System.EventHandler(this.buttonSaveToText_Click);
            // 
            // buttonPrint
            // 
            this.buttonPrint.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPrint.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonPrint.Location = new System.Drawing.Point(731, 480);
            this.buttonPrint.Name = "buttonPrint";
            this.buttonPrint.Size = new System.Drawing.Size(137, 36);
            this.buttonPrint.TabIndex = 15;
            this.buttonPrint.Text = "To Printer";
            this.buttonPrint.UseVisualStyleBackColor = false;
            this.buttonPrint.Click += new System.EventHandler(this.buttonPrint_Click);
            // 
            // dataGridViewListStudent
            // 
            this.dataGridViewListStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewListStudent.Location = new System.Drawing.Point(10, 108);
            this.dataGridViewListStudent.Name = "dataGridViewListStudent";
            this.dataGridViewListStudent.RowHeadersWidth = 51;
            this.dataGridViewListStudent.RowTemplate.Height = 24;
            this.dataGridViewListStudent.Size = new System.Drawing.Size(1166, 359);
            this.dataGridViewListStudent.TabIndex = 14;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.radioButtonFemale);
            this.panel1.Controls.Add(this.radioButtonMale);
            this.panel1.Controls.Add(this.radioButtonAll);
            this.panel1.Controls.Add(this.buttonCheck);
            this.panel1.Location = new System.Drawing.Point(13, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1163, 89);
            this.panel1.TabIndex = 17;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.dateTimePickerTo);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.dateTimePickerFrom);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.radioButtonNo);
            this.panel2.Controls.Add(this.radioButtonYes);
            this.panel2.Location = new System.Drawing.Point(255, 7);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(742, 75);
            this.panel2.TabIndex = 0;
            // 
            // dateTimePickerTo
            // 
            this.dateTimePickerTo.Location = new System.Drawing.Point(472, 47);
            this.dateTimePickerTo.Name = "dateTimePickerTo";
            this.dateTimePickerTo.Size = new System.Drawing.Size(229, 22);
            this.dateTimePickerTo.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(428, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "And";
            // 
            // dateTimePickerFrom
            // 
            this.dateTimePickerFrom.Location = new System.Drawing.Point(186, 47);
            this.dateTimePickerFrom.Name = "dateTimePickerFrom";
            this.dateTimePickerFrom.Size = new System.Drawing.Size(229, 22);
            this.dateTimePickerFrom.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(9, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "BirthDate between";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(9, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Use Date Range";
            // 
            // radioButtonNo
            // 
            this.radioButtonNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonNo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.radioButtonNo.Location = new System.Drawing.Point(222, 14);
            this.radioButtonNo.Name = "radioButtonNo";
            this.radioButtonNo.Size = new System.Drawing.Size(110, 21);
            this.radioButtonNo.TabIndex = 1;
            this.radioButtonNo.TabStop = true;
            this.radioButtonNo.Text = "No";
            this.radioButtonNo.UseVisualStyleBackColor = true;
            // 
            // radioButtonYes
            // 
            this.radioButtonYes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonYes.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.radioButtonYes.Location = new System.Drawing.Point(115, 14);
            this.radioButtonYes.Name = "radioButtonYes";
            this.radioButtonYes.Size = new System.Drawing.Size(104, 24);
            this.radioButtonYes.TabIndex = 0;
            this.radioButtonYes.TabStop = true;
            this.radioButtonYes.Text = "Yes";
            this.radioButtonYes.UseVisualStyleBackColor = true;
            // 
            // radioButtonFemale
            // 
            this.radioButtonFemale.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonFemale.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.radioButtonFemale.Location = new System.Drawing.Point(155, 39);
            this.radioButtonFemale.Name = "radioButtonFemale";
            this.radioButtonFemale.Size = new System.Drawing.Size(110, 21);
            this.radioButtonFemale.TabIndex = 2;
            this.radioButtonFemale.TabStop = true;
            this.radioButtonFemale.Text = "Female";
            this.radioButtonFemale.UseVisualStyleBackColor = true;
            // 
            // radioButtonMale
            // 
            this.radioButtonMale.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonMale.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.radioButtonMale.Location = new System.Drawing.Point(70, 39);
            this.radioButtonMale.Name = "radioButtonMale";
            this.radioButtonMale.Size = new System.Drawing.Size(110, 21);
            this.radioButtonMale.TabIndex = 3;
            this.radioButtonMale.TabStop = true;
            this.radioButtonMale.Text = "Male";
            this.radioButtonMale.UseVisualStyleBackColor = true;
            // 
            // radioButtonAll
            // 
            this.radioButtonAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonAll.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.radioButtonAll.Location = new System.Drawing.Point(3, 39);
            this.radioButtonAll.Name = "radioButtonAll";
            this.radioButtonAll.Size = new System.Drawing.Size(110, 21);
            this.radioButtonAll.TabIndex = 4;
            this.radioButtonAll.TabStop = true;
            this.radioButtonAll.Text = "All";
            this.radioButtonAll.UseVisualStyleBackColor = true;
            this.radioButtonAll.CheckedChanged += new System.EventHandler(this.radioButtonAll_CheckedChanged);
            // 
            // buttonCheck
            // 
            this.buttonCheck.BackColor = System.Drawing.Color.Red;
            this.buttonCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCheck.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonCheck.Location = new System.Drawing.Point(1025, 25);
            this.buttonCheck.Name = "buttonCheck";
            this.buttonCheck.Size = new System.Drawing.Size(97, 39);
            this.buttonCheck.TabIndex = 1;
            this.buttonCheck.Text = "Check";
            this.buttonCheck.UseVisualStyleBackColor = false;
            this.buttonCheck.Click += new System.EventHandler(this.buttonCheck_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label4.Location = new System.Drawing.Point(12, 503);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(216, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Nguyễn Thị Minh Thư_18128062";
            // 
            // PrintForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1188, 529);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonSaveToText);
            this.Controls.Add(this.buttonPrint);
            this.Controls.Add(this.dataGridViewListStudent);
            this.Name = "PrintForm";
            this.Text = "PrintForm";
            this.Load += new System.EventHandler(this.PrintForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListStudent)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSaveToText;
        private System.Windows.Forms.Button buttonPrint;
        private System.Windows.Forms.DataGridView dataGridViewListStudent;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioButtonFemale;
        private System.Windows.Forms.RadioButton radioButtonMale;
        private System.Windows.Forms.RadioButton radioButtonAll;
        private System.Windows.Forms.Button buttonCheck;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButtonNo;
        private System.Windows.Forms.RadioButton radioButtonYes;
        private System.Windows.Forms.DateTimePicker dateTimePickerTo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePickerFrom;
        private System.Windows.Forms.Label label4;
    }
}