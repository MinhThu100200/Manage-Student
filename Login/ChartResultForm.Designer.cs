
namespace Login
{
    partial class ChartResultForm
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
            this.buttonChartByCourse = new System.Windows.Forms.Button();
            this.buttonChartByResult = new System.Windows.Forms.Button();
            this.chartScore = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chartScore)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonChartByCourse
            // 
            this.buttonChartByCourse.BackColor = System.Drawing.Color.LightSeaGreen;
            this.buttonChartByCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonChartByCourse.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonChartByCourse.Location = new System.Drawing.Point(30, 12);
            this.buttonChartByCourse.Name = "buttonChartByCourse";
            this.buttonChartByCourse.Size = new System.Drawing.Size(176, 40);
            this.buttonChartByCourse.TabIndex = 0;
            this.buttonChartByCourse.Text = "Chart By Course";
            this.buttonChartByCourse.UseVisualStyleBackColor = false;
            // 
            // buttonChartByResult
            // 
            this.buttonChartByResult.BackColor = System.Drawing.Color.LightSeaGreen;
            this.buttonChartByResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonChartByResult.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonChartByResult.Location = new System.Drawing.Point(560, 12);
            this.buttonChartByResult.Name = "buttonChartByResult";
            this.buttonChartByResult.Size = new System.Drawing.Size(164, 40);
            this.buttonChartByResult.TabIndex = 1;
            this.buttonChartByResult.Text = "Chart By Result";
            this.buttonChartByResult.UseVisualStyleBackColor = false;
            // 
            // chartScore
            // 
            chartArea1.Name = "ChartArea1";
            this.chartScore.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartScore.Legends.Add(legend1);
            this.chartScore.Location = new System.Drawing.Point(30, 58);
            this.chartScore.Name = "chartScore";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartScore.Series.Add(series1);
            this.chartScore.Size = new System.Drawing.Size(694, 388);
            this.chartScore.TabIndex = 2;
            this.chartScore.Text = "chartScore";
            title1.Name = "Chart Score";
            title1.Text = "Chart Score";
            this.chartScore.Titles.Add(title1);
            // 
            // ChartResultForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(750, 458);
            this.Controls.Add(this.chartScore);
            this.Controls.Add(this.buttonChartByResult);
            this.Controls.Add(this.buttonChartByCourse);
            this.Name = "ChartResultForm";
            this.Text = "ChartResultForm";
            ((System.ComponentModel.ISupportInitialize)(this.chartScore)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonChartByCourse;
        private System.Windows.Forms.Button buttonChartByResult;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartScore;
    }
}