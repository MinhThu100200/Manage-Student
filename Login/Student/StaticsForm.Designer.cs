
namespace Login
{
    partial class StaticsForm
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
            this.panelTotal = new System.Windows.Forms.Panel();
            this.labelTotal = new System.Windows.Forms.Label();
            this.panelMale = new System.Windows.Forms.Panel();
            this.labelMale = new System.Windows.Forms.Label();
            this.panelFemale = new System.Windows.Forms.Panel();
            this.labelFemale = new System.Windows.Forms.Label();
            this.panelTotal.SuspendLayout();
            this.panelMale.SuspendLayout();
            this.panelFemale.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTotal
            // 
            this.panelTotal.Controls.Add(this.labelTotal);
            this.panelTotal.Location = new System.Drawing.Point(1, 0);
            this.panelTotal.Name = "panelTotal";
            this.panelTotal.Size = new System.Drawing.Size(498, 104);
            this.panelTotal.TabIndex = 0;
            // 
            // labelTotal
            // 
            this.labelTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotal.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelTotal.Location = new System.Drawing.Point(135, 30);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(222, 40);
            this.labelTotal.TabIndex = 0;
            this.labelTotal.Text = "label1";
            this.labelTotal.MouseEnter += new System.EventHandler(this.labelTotal_MouseEnter);
            this.labelTotal.MouseLeave += new System.EventHandler(this.labelTotal_MouseLeave);
            // 
            // panelMale
            // 
            this.panelMale.Controls.Add(this.labelMale);
            this.panelMale.Location = new System.Drawing.Point(1, 110);
            this.panelMale.Name = "panelMale";
            this.panelMale.Size = new System.Drawing.Size(249, 110);
            this.panelMale.TabIndex = 1;
            // 
            // labelMale
            // 
            this.labelMale.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMale.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelMale.Location = new System.Drawing.Point(11, 31);
            this.labelMale.Name = "labelMale";
            this.labelMale.Size = new System.Drawing.Size(235, 40);
            this.labelMale.TabIndex = 1;
            this.labelMale.Text = "label1";
            this.labelMale.MouseEnter += new System.EventHandler(this.labelMale_MouseEnter);
            this.labelMale.MouseLeave += new System.EventHandler(this.labelMale_MouseLeave);
            // 
            // panelFemale
            // 
            this.panelFemale.Controls.Add(this.labelFemale);
            this.panelFemale.Location = new System.Drawing.Point(256, 110);
            this.panelFemale.Name = "panelFemale";
            this.panelFemale.Size = new System.Drawing.Size(243, 110);
            this.panelFemale.TabIndex = 2;
            // 
            // labelFemale
            // 
            this.labelFemale.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFemale.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelFemale.Location = new System.Drawing.Point(6, 31);
            this.labelFemale.Name = "labelFemale";
            this.labelFemale.Size = new System.Drawing.Size(226, 40);
            this.labelFemale.TabIndex = 3;
            this.labelFemale.Text = "label1";
            this.labelFemale.MouseEnter += new System.EventHandler(this.labelFemale_MouseEnter);
            this.labelFemale.MouseLeave += new System.EventHandler(this.labelFemale_MouseLeave);
            // 
            // StaticsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 220);
            this.Controls.Add(this.panelFemale);
            this.Controls.Add(this.panelMale);
            this.Controls.Add(this.panelTotal);
            this.Name = "StaticsForm";
            this.Text = "StaticsForm";
            this.Load += new System.EventHandler(this.StaticsForm_Load);
            this.panelTotal.ResumeLayout(false);
            this.panelMale.ResumeLayout(false);
            this.panelFemale.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTotal;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Panel panelMale;
        private System.Windows.Forms.Panel panelFemale;
        private System.Windows.Forms.Label labelMale;
        private System.Windows.Forms.Label labelFemale;
    }
}