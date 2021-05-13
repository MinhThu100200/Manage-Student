
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.panelTotal = new System.Windows.Forms.Panel();
            this.labelTotal = new System.Windows.Forms.Label();
            this.panelMale = new System.Windows.Forms.Panel();
            this.labelMale = new System.Windows.Forms.Label();
            this.panelFemale = new System.Windows.Forms.Panel();
            this.labelFemale = new System.Windows.Forms.Label();
            this.chartGender = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panelTotal.SuspendLayout();
            this.panelMale.SuspendLayout();
            this.panelFemale.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartGender)).BeginInit();
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
            // chartGender
            // 
            chartArea1.Name = "ChartArea1";
            this.chartGender.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartGender.Legends.Add(legend1);
            this.chartGender.Location = new System.Drawing.Point(1, 225);
            this.chartGender.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chartGender.Name = "chartGender";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartGender.Series.Add(series1);
            this.chartGender.Size = new System.Drawing.Size(498, 194);
            this.chartGender.TabIndex = 3;
            this.chartGender.Text = "chartGender";
            title1.Name = "Chart Score";
            title1.Text = "Chart Score";
            this.chartGender.Titles.Add(title1);
            // 
            // StaticsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 424);
            this.Controls.Add(this.chartGender);
            this.Controls.Add(this.panelFemale);
            this.Controls.Add(this.panelMale);
            this.Controls.Add(this.panelTotal);
            this.Name = "StaticsForm";
            this.Text = "StaticsForm";
            this.Load += new System.EventHandler(this.StaticsForm_Load);
            this.panelTotal.ResumeLayout(false);
            this.panelMale.ResumeLayout(false);
            this.panelFemale.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartGender)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTotal;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Panel panelMale;
        private System.Windows.Forms.Panel panelFemale;
        private System.Windows.Forms.Label labelMale;
        private System.Windows.Forms.Label labelFemale;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartGender;
    }
}