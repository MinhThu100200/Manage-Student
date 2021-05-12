
namespace Login
{
    partial class ShowFullListContactsForm
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
            this.dataGridViewContacts = new System.Windows.Forms.DataGridView();
            this.listBoxNameGroup = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelShowAll = new System.Windows.Forms.Label();
            this.richTextBoxAddress = new System.Windows.Forms.RichTextBox();
            this.label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewContacts)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewContacts
            // 
            this.dataGridViewContacts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewContacts.Location = new System.Drawing.Point(439, 66);
            this.dataGridViewContacts.Name = "dataGridViewContacts";
            this.dataGridViewContacts.RowHeadersWidth = 51;
            this.dataGridViewContacts.RowTemplate.Height = 26;
            this.dataGridViewContacts.Size = new System.Drawing.Size(954, 404);
            this.dataGridViewContacts.TabIndex = 0;
            this.dataGridViewContacts.Click += new System.EventHandler(this.dataGridViewContacts_Click);
            this.dataGridViewContacts.DoubleClick += new System.EventHandler(this.dataGridViewContacts_DoubleClick);
            // 
            // listBoxNameGroup
            // 
            this.listBoxNameGroup.FormattingEnabled = true;
            this.listBoxNameGroup.ItemHeight = 16;
            this.listBoxNameGroup.Location = new System.Drawing.Point(14, 66);
            this.listBoxNameGroup.Name = "listBoxNameGroup";
            this.listBoxNameGroup.Size = new System.Drawing.Size(419, 404);
            this.listBoxNameGroup.TabIndex = 1;
            this.listBoxNameGroup.Click += new System.EventHandler(this.listBoxNameGroup_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 13F, System.Drawing.FontStyle.Underline);
            this.label1.ForeColor = System.Drawing.Color.DarkOrange;
            this.label1.Location = new System.Drawing.Point(14, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 27);
            this.label1.TabIndex = 2;
            this.label1.Text = "Group";
            // 
            // labelShowAll
            // 
            this.labelShowAll.AutoSize = true;
            this.labelShowAll.Font = new System.Drawing.Font("Tahoma", 13F, System.Drawing.FontStyle.Underline);
            this.labelShowAll.ForeColor = System.Drawing.Color.DarkOrange;
            this.labelShowAll.Location = new System.Drawing.Point(437, 30);
            this.labelShowAll.Name = "labelShowAll";
            this.labelShowAll.Size = new System.Drawing.Size(87, 27);
            this.labelShowAll.TabIndex = 3;
            this.labelShowAll.Text = "ShowAll";
            this.labelShowAll.Click += new System.EventHandler(this.labelShowAll_Click);
            // 
            // richTextBoxAddress
            // 
            this.richTextBoxAddress.Location = new System.Drawing.Point(442, 476);
            this.richTextBoxAddress.Name = "richTextBoxAddress";
            this.richTextBoxAddress.Size = new System.Drawing.Size(425, 51);
            this.richTextBoxAddress.TabIndex = 4;
            this.richTextBoxAddress.Text = "";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label.Location = new System.Drawing.Point(314, 479);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(108, 20);
            this.label.TabIndex = 5;
            this.label.Text = "Full Address:";
            // 
            // ShowFullListContactsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Purple;
            this.ClientSize = new System.Drawing.Size(1408, 532);
            this.Controls.Add(this.label);
            this.Controls.Add(this.richTextBoxAddress);
            this.Controls.Add(this.labelShowAll);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxNameGroup);
            this.Controls.Add(this.dataGridViewContacts);
            this.Name = "ShowFullListContactsForm";
            this.Text = "ShowFullListContactsForm";
            this.Load += new System.EventHandler(this.ShowFullListContactsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewContacts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox listBoxNameGroup;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelShowAll;
        private System.Windows.Forms.RichTextBox richTextBoxAddress;
        private System.Windows.Forms.Label label;
        public System.Windows.Forms.DataGridView dataGridViewContacts;
    }
}