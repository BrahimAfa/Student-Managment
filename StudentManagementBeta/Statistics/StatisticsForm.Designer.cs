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
      this.components = new System.ComponentModel.Container();
      System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
      System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
      System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
      System.Windows.Forms.DataVisualization.Charting.Title title4 = new System.Windows.Forms.DataVisualization.Charting.Title();
      this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
      this.label1 = new System.Windows.Forms.Label();
      this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
      this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
      this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
      this.panel1 = new System.Windows.Forms.Panel();
      this.pictureBox1 = new System.Windows.Forms.PictureBox();
      this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
      this.labelFiliere = new Bunifu.Framework.UI.BunifuCustomLabel();
      ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
      this.panel1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
      this.SuspendLayout();
      // 
      // chart1
      // 
      this.chart1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(225)))), ((int)(((byte)(231)))));
      this.chart1.BackSecondaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(225)))), ((int)(((byte)(231)))));
      this.chart1.BorderlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(225)))), ((int)(((byte)(231)))));
      chartArea4.Name = "ChartArea1";
      this.chart1.ChartAreas.Add(chartArea4);
      legend4.Name = "Legend1";
      this.chart1.Legends.Add(legend4);
      this.chart1.Location = new System.Drawing.Point(0, 126);
      this.chart1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
      this.chart1.Name = "chart1";
      series4.ChartArea = "ChartArea1";
      series4.IsVisibleInLegend = false;
      series4.Legend = "Legend1";
      series4.LegendText = "Nombre d\'etudiant";
      series4.Name = "NombreEtudiant";
      this.chart1.Series.Add(series4);
      this.chart1.Size = new System.Drawing.Size(800, 389);
      this.chart1.TabIndex = 0;
      this.chart1.Text = "chart1";
      title4.Name = "Title1snsnsn";
      this.chart1.Titles.Add(title4);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(65)))), ((int)(((byte)(109)))));
      this.label1.Location = new System.Drawing.Point(321, 40);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(169, 45);
      this.label1.TabIndex = 24;
      this.label1.Text = "Statistique";
      // 
      // bunifuSeparator1
      // 
      this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
      this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(65)))), ((int)(((byte)(109)))));
      this.bunifuSeparator1.LineThickness = 3;
      this.bunifuSeparator1.Location = new System.Drawing.Point(282, 79);
      this.bunifuSeparator1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.bunifuSeparator1.Name = "bunifuSeparator1";
      this.bunifuSeparator1.Size = new System.Drawing.Size(257, 17);
      this.bunifuSeparator1.TabIndex = 23;
      this.bunifuSeparator1.Transparency = 255;
      this.bunifuSeparator1.Vertical = false;
      // 
      // bunifuCustomLabel1
      // 
      this.bunifuCustomLabel1.AutoSize = true;
      this.bunifuCustomLabel1.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.bunifuCustomLabel1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
      this.bunifuCustomLabel1.Location = new System.Drawing.Point(169, 100);
      this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
      this.bunifuCustomLabel1.Size = new System.Drawing.Size(445, 37);
      this.bunifuCustomLabel1.TabIndex = 25;
      this.bunifuCustomLabel1.Text = "Nombre  des étudiants par Filière";
      // 
      // bunifuElipse1
      // 
      this.bunifuElipse1.ElipseRadius = 5;
      this.bunifuElipse1.TargetControl = this;
      // 
      // panel1
      // 
      this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(220)))), ((int)(((byte)(245)))));
      this.panel1.Controls.Add(this.labelFiliere);
      this.panel1.Controls.Add(this.pictureBox1);
      this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
      this.panel1.Location = new System.Drawing.Point(0, 0);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(800, 37);
      this.panel1.TabIndex = 26;
      // 
      // pictureBox1
      // 
      this.pictureBox1.BackColor = System.Drawing.Color.Red;
      this.pictureBox1.Image = global::StudentManagementBeta.Properties.Resources.icons8_Delete_32px;
      this.pictureBox1.Location = new System.Drawing.Point(755, 2);
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.Size = new System.Drawing.Size(33, 32);
      this.pictureBox1.TabIndex = 1;
      this.pictureBox1.TabStop = false;
      this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
      // 
      // bunifuDragControl1
      // 
      this.bunifuDragControl1.Fixed = true;
      this.bunifuDragControl1.Horizontal = true;
      this.bunifuDragControl1.TargetControl = this.panel1;
      this.bunifuDragControl1.Vertical = true;
      // 
      // labelFiliere
      // 
      this.labelFiliere.AutoSize = true;
      this.labelFiliere.Font = new System.Drawing.Font("Segoe UI Historic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.labelFiliere.Location = new System.Drawing.Point(347, 4);
      this.labelFiliere.Name = "labelFiliere";
      this.labelFiliere.Size = new System.Drawing.Size(121, 30);
      this.labelFiliere.TabIndex = 27;
      this.labelFiliere.Text = "Statistique";
      // 
      // StatisticsForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(225)))), ((int)(((byte)(231)))));
      this.ClientSize = new System.Drawing.Size(800, 518);
      this.Controls.Add(this.panel1);
      this.Controls.Add(this.bunifuCustomLabel1);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.bunifuSeparator1);
      this.Controls.Add(this.chart1);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
      this.Name = "StatisticsForm";
      this.Text = "FormStatistics";
      this.Load += new System.EventHandler(this.FormStatistics_Load);
      ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
    private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.PictureBox pictureBox1;
    private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
    private Bunifu.Framework.UI.BunifuCustomLabel labelFiliere;
  }
}