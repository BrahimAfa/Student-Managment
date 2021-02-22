namespace StudentManagementBeta.Statistics
{
  partial class StatisticsForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(82, 156);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.IsVisibleInLegend = false;
            series2.Legend = "Legend1";
            series2.LegendText = "Nombre d\'etudiant";
            series2.Name = "NombreEtudiant";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(899, 456);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            title2.Name = "Title1snsnsn";
            this.chart1.Titles.Add(title2);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(65)))), ((int)(((byte)(109)))));
            this.label1.Location = new System.Drawing.Point(433, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 54);
            this.label1.TabIndex = 24;
            this.label1.Text = "Statistique";
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(65)))), ((int)(((byte)(109)))));
            this.bunifuSeparator1.LineThickness = 3;
            this.bunifuSeparator1.Location = new System.Drawing.Point(381, 57);
            this.bunifuSeparator1.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(343, 21);
            this.bunifuSeparator1.TabIndex = 23;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(92, 107);
            this.bunifuCustomLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(552, 46);
            this.bunifuCustomLabel1.TabIndex = 25;
            this.bunifuCustomLabel1.Text = "Nombre  des étudiants par Filière";
            // 
            // StatisticsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 637);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bunifuSeparator1);
            this.Controls.Add(this.chart1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "StatisticsForm";
            this.Text = "FormStatistics";
            this.Load += new System.EventHandler(this.FormStatistics_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
    }
}