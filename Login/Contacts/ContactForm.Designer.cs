
namespace Login
{
    partial class ContactForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonAddContact = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonEditContact = new System.Windows.Forms.Button();
            this.textBoxGroupName = new System.Windows.Forms.TextBox();
            this.buttonAddGroup = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.textBoxContactId = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxNewNameGroup = new System.Windows.Forms.TextBox();
            this.buttonShowFullList = new System.Windows.Forms.Button();
            this.buttonSelectContact = new System.Windows.Forms.Button();
            this.comboBoxSelectGroupEdit = new System.Windows.Forms.ComboBox();
            this.buttonEditGroup = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.buttonRemoveGroup = new System.Windows.Forms.Button();
            this.comboBoxSelectGroupRemove = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 13F, System.Drawing.FontStyle.Underline);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(190, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Contact";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonAddGroup);
            this.groupBox1.Controls.Add(this.textBoxGroupName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(475, 77);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(439, 100);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(455, 42);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(14, 470);
            this.button1.TabIndex = 2;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 13F, System.Drawing.FontStyle.Underline);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(660, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 27);
            this.label2.TabIndex = 3;
            this.label2.Text = "Group";
            // 
            // buttonAddContact
            // 
            this.buttonAddContact.BackColor = System.Drawing.Color.Orange;
            this.buttonAddContact.Location = new System.Drawing.Point(12, 97);
            this.buttonAddContact.Name = "buttonAddContact";
            this.buttonAddContact.Size = new System.Drawing.Size(125, 35);
            this.buttonAddContact.TabIndex = 4;
            this.buttonAddContact.Text = "Add";
            this.buttonAddContact.UseVisualStyleBackColor = false;
            this.buttonAddContact.Click += new System.EventHandler(this.buttonAddContact_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(6, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Enter Group Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(6, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 21);
            this.label4.TabIndex = 6;
            this.label4.Text = "Enter New Name:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonEditGroup);
            this.groupBox2.Controls.Add(this.comboBoxSelectGroupEdit);
            this.groupBox2.Controls.Add(this.textBoxNewNameGroup);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(475, 195);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(439, 145);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(6, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 21);
            this.label5.TabIndex = 5;
            this.label5.Text = "Select Group:";
            // 
            // buttonEditContact
            // 
            this.buttonEditContact.BackColor = System.Drawing.Color.Orange;
            this.buttonEditContact.Location = new System.Drawing.Point(328, 97);
            this.buttonEditContact.Name = "buttonEditContact";
            this.buttonEditContact.Size = new System.Drawing.Size(121, 35);
            this.buttonEditContact.TabIndex = 7;
            this.buttonEditContact.Text = "Edit";
            this.buttonEditContact.UseVisualStyleBackColor = false;
            this.buttonEditContact.Click += new System.EventHandler(this.buttonEditContact_Click);
            // 
            // textBoxGroupName
            // 
            this.textBoxGroupName.Location = new System.Drawing.Point(152, 17);
            this.textBoxGroupName.Name = "textBoxGroupName";
            this.textBoxGroupName.Size = new System.Drawing.Size(274, 24);
            this.textBoxGroupName.TabIndex = 6;
            // 
            // buttonAddGroup
            // 
            this.buttonAddGroup.BackColor = System.Drawing.Color.DarkOrange;
            this.buttonAddGroup.Location = new System.Drawing.Point(9, 59);
            this.buttonAddGroup.Name = "buttonAddGroup";
            this.buttonAddGroup.Size = new System.Drawing.Size(417, 35);
            this.buttonAddGroup.TabIndex = 8;
            this.buttonAddGroup.Text = "Add";
            this.buttonAddGroup.UseVisualStyleBackColor = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.buttonSelectContact);
            this.groupBox3.Controls.Add(this.buttonRemove);
            this.groupBox3.Controls.Add(this.textBoxContactId);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Location = new System.Drawing.Point(12, 150);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(437, 113);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            // 
            // buttonRemove
            // 
            this.buttonRemove.BackColor = System.Drawing.Color.Orange;
            this.buttonRemove.Location = new System.Drawing.Point(9, 66);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(414, 35);
            this.buttonRemove.TabIndex = 8;
            this.buttonRemove.Text = "Remove";
            this.buttonRemove.UseVisualStyleBackColor = false;
            // 
            // textBoxContactId
            // 
            this.textBoxContactId.Location = new System.Drawing.Point(147, 23);
            this.textBoxContactId.Name = "textBoxContactId";
            this.textBoxContactId.Size = new System.Drawing.Size(132, 24);
            this.textBoxContactId.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(6, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(141, 21);
            this.label6.TabIndex = 5;
            this.label6.Text = "Enter Contact ID:";
            // 
            // textBoxNewNameGroup
            // 
            this.textBoxNewNameGroup.Location = new System.Drawing.Point(152, 67);
            this.textBoxNewNameGroup.Name = "textBoxNewNameGroup";
            this.textBoxNewNameGroup.Size = new System.Drawing.Size(274, 24);
            this.textBoxNewNameGroup.TabIndex = 9;
            // 
            // buttonShowFullList
            // 
            this.buttonShowFullList.BackColor = System.Drawing.Color.Orange;
            this.buttonShowFullList.Location = new System.Drawing.Point(12, 300);
            this.buttonShowFullList.Name = "buttonShowFullList";
            this.buttonShowFullList.Size = new System.Drawing.Size(153, 35);
            this.buttonShowFullList.TabIndex = 9;
            this.buttonShowFullList.Text = "Show Full List";
            this.buttonShowFullList.UseVisualStyleBackColor = false;
            this.buttonShowFullList.Click += new System.EventHandler(this.buttonShowFullList_Click);
            // 
            // buttonSelectContact
            // 
            this.buttonSelectContact.BackColor = System.Drawing.Color.Firebrick;
            this.buttonSelectContact.Location = new System.Drawing.Point(285, 18);
            this.buttonSelectContact.Name = "buttonSelectContact";
            this.buttonSelectContact.Size = new System.Drawing.Size(138, 35);
            this.buttonSelectContact.TabIndex = 10;
            this.buttonSelectContact.Text = "Select Contact";
            this.buttonSelectContact.UseVisualStyleBackColor = false;
            this.buttonSelectContact.Click += new System.EventHandler(this.buttonSelectContact_Click);
            // 
            // comboBoxSelectGroupEdit
            // 
            this.comboBoxSelectGroupEdit.FormattingEnabled = true;
            this.comboBoxSelectGroupEdit.Location = new System.Drawing.Point(152, 23);
            this.comboBoxSelectGroupEdit.Name = "comboBoxSelectGroupEdit";
            this.comboBoxSelectGroupEdit.Size = new System.Drawing.Size(274, 24);
            this.comboBoxSelectGroupEdit.TabIndex = 10;
            // 
            // buttonEditGroup
            // 
            this.buttonEditGroup.BackColor = System.Drawing.Color.DarkOrange;
            this.buttonEditGroup.Location = new System.Drawing.Point(9, 105);
            this.buttonEditGroup.Name = "buttonEditGroup";
            this.buttonEditGroup.Size = new System.Drawing.Size(417, 35);
            this.buttonEditGroup.TabIndex = 9;
            this.buttonEditGroup.Text = "Edit";
            this.buttonEditGroup.UseVisualStyleBackColor = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.buttonRemoveGroup);
            this.groupBox4.Controls.Add(this.comboBoxSelectGroupRemove);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Location = new System.Drawing.Point(475, 359);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(439, 110);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            // 
            // buttonRemoveGroup
            // 
            this.buttonRemoveGroup.BackColor = System.Drawing.Color.DarkOrange;
            this.buttonRemoveGroup.Location = new System.Drawing.Point(9, 64);
            this.buttonRemoveGroup.Name = "buttonRemoveGroup";
            this.buttonRemoveGroup.Size = new System.Drawing.Size(417, 35);
            this.buttonRemoveGroup.TabIndex = 9;
            this.buttonRemoveGroup.Text = "Reomve";
            this.buttonRemoveGroup.UseVisualStyleBackColor = false;
            // 
            // comboBoxSelectGroupRemove
            // 
            this.comboBoxSelectGroupRemove.FormattingEnabled = true;
            this.comboBoxSelectGroupRemove.Location = new System.Drawing.Point(152, 23);
            this.comboBoxSelectGroupRemove.Name = "comboBoxSelectGroupRemove";
            this.comboBoxSelectGroupRemove.Size = new System.Drawing.Size(274, 24);
            this.comboBoxSelectGroupRemove.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(6, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 21);
            this.label7.TabIndex = 5;
            this.label7.Text = "Select Group:";
            // 
            // ContactForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(930, 516);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.buttonShowFullList);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.buttonEditContact);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.buttonAddContact);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "ContactForm";
            this.Text = "ContactForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonAddGroup;
        private System.Windows.Forms.TextBox textBoxGroupName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonAddContact;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonEditGroup;
        private System.Windows.Forms.ComboBox comboBoxSelectGroupEdit;
        private System.Windows.Forms.TextBox textBoxNewNameGroup;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonEditContact;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button buttonSelectContact;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.TextBox textBoxContactId;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonShowFullList;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button buttonRemoveGroup;
        private System.Windows.Forms.ComboBox comboBoxSelectGroupRemove;
        private System.Windows.Forms.Label label7;
    }
}