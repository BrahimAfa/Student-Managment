namespace StudentManagementBeta.Etudiant
{
  partial class ImportForm
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImportForm));
      this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
      this.panel1 = new System.Windows.Forms.Panel();
      this.panel2 = new System.Windows.Forms.Panel();
      this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
      this.bunifuCustomLabel7 = new Bunifu.Framework.UI.BunifuCustomLabel();
      this.txtDelim = new Bunifu.Framework.UI.BunifuMetroTextbox();
      this.label1 = new System.Windows.Forms.Label();
      this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
      this.txtImport = new Bunifu.Framework.UI.BunifuMetroTextbox();
      this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
      this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
      this.AjouterEtudiant = new Bunifu.Framework.UI.BunifuFlatButton();
      this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
      this.pictureBox1 = new System.Windows.Forms.PictureBox();
      this.panel1.SuspendLayout();
      this.panel2.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
      this.SuspendLayout();
      // 
      // bunifuElipse1
      // 
      this.bunifuElipse1.ElipseRadius = 5;
      this.bunifuElipse1.TargetControl = this;
      // 
      // panel1
      // 
      this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(220)))), ((int)(((byte)(245)))));
      this.panel1.Controls.Add(this.bunifuImageButton1);
      this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
      this.panel1.Location = new System.Drawing.Point(0, 0);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(592, 44);
      this.panel1.TabIndex = 0;
      // 
      // panel2
      // 
      this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(37)))), ((int)(((byte)(76)))));
      this.panel2.Controls.Add(this.pictureBox1);
      this.panel2.Controls.Add(this.bunifuCustomLabel1);
      this.panel2.Controls.Add(this.bunifuCustomLabel7);
      this.panel2.Controls.Add(this.txtDelim);
      this.panel2.Controls.Add(this.AjouterEtudiant);
      this.panel2.Controls.Add(this.label1);
      this.panel2.Controls.Add(this.bunifuSeparator1);
      this.panel2.Controls.Add(this.txtImport);
      this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
      this.panel2.Location = new System.Drawing.Point(0, 44);
      this.panel2.Name = "panel2";
      this.panel2.Size = new System.Drawing.Size(592, 219);
      this.panel2.TabIndex = 1;
      // 
      // bunifuCustomLabel1
      // 
      this.bunifuCustomLabel1.AutoSize = true;
      this.bunifuCustomLabel1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.bunifuCustomLabel1.ForeColor = System.Drawing.SystemColors.Window;
      this.bunifuCustomLabel1.Location = new System.Drawing.Point(353, 78);
      this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
      this.bunifuCustomLabel1.Size = new System.Drawing.Size(55, 15);
      this.bunifuCustomLabel1.TabIndex = 26;
      this.bunifuCustomLabel1.Text = "Delimiter";
      this.bunifuCustomLabel1.Visible = false;
      // 
      // bunifuCustomLabel7
      // 
      this.bunifuCustomLabel7.AutoSize = true;
      this.bunifuCustomLabel7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.bunifuCustomLabel7.ForeColor = System.Drawing.SystemColors.Window;
      this.bunifuCustomLabel7.Location = new System.Drawing.Point(12, 78);
      this.bunifuCustomLabel7.Name = "bunifuCustomLabel7";
      this.bunifuCustomLabel7.Size = new System.Drawing.Size(31, 15);
      this.bunifuCustomLabel7.TabIndex = 25;
      this.bunifuCustomLabel7.Text = "File: ";
      // 
      // txtDelim
      // 
      this.txtDelim.BorderColorFocused = System.Drawing.Color.Blue;
      this.txtDelim.BorderColorIdle = System.Drawing.Color.Silver;
      this.txtDelim.BorderColorMouseHover = System.Drawing.Color.Blue;
      this.txtDelim.BorderThickness = 1;
      this.txtDelim.Cursor = System.Windows.Forms.Cursors.IBeam;
      this.txtDelim.Font = new System.Drawing.Font("Century Gothic", 12F);
      this.txtDelim.ForeColor = System.Drawing.Color.Silver;
      this.txtDelim.isPassword = false;
      this.txtDelim.Location = new System.Drawing.Point(353, 99);
      this.txtDelim.Margin = new System.Windows.Forms.Padding(6);
      this.txtDelim.Name = "txtDelim";
      this.txtDelim.Size = new System.Drawing.Size(60, 33);
      this.txtDelim.TabIndex = 24;
      this.txtDelim.Text = ",";
      this.txtDelim.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
      this.txtDelim.Visible = false;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
      this.label1.Location = new System.Drawing.Point(164, 6);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(285, 45);
      this.label1.TabIndex = 22;
      this.label1.Text = "Importer Etudiants";
      // 
      // bunifuSeparator1
      // 
      this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
      this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      this.bunifuSeparator1.LineThickness = 3;
      this.bunifuSeparator1.Location = new System.Drawing.Point(92, 54);
      this.bunifuSeparator1.Name = "bunifuSeparator1";
      this.bunifuSeparator1.Size = new System.Drawing.Size(396, 17);
      this.bunifuSeparator1.TabIndex = 21;
      this.bunifuSeparator1.Transparency = 255;
      this.bunifuSeparator1.Vertical = false;
      // 
      // txtImport
      // 
      this.txtImport.BorderColorFocused = System.Drawing.Color.Blue;
      this.txtImport.BorderColorIdle = System.Drawing.Color.Silver;
      this.txtImport.BorderColorMouseHover = System.Drawing.Color.Blue;
      this.txtImport.BorderThickness = 1;
      this.txtImport.Cursor = System.Windows.Forms.Cursors.Hand;
      this.txtImport.Font = new System.Drawing.Font("Century Gothic", 9.75F);
      this.txtImport.ForeColor = System.Drawing.Color.Silver;
      this.txtImport.isPassword = false;
      this.txtImport.Location = new System.Drawing.Point(13, 97);
      this.txtImport.Margin = new System.Windows.Forms.Padding(4);
      this.txtImport.Name = "txtImport";
      this.txtImport.Size = new System.Drawing.Size(316, 33);
      this.txtImport.TabIndex = 12;
      this.txtImport.Text = "Import...";
      this.txtImport.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
      this.txtImport.Click += new System.EventHandler(this.txtImport_Click);
      // 
      // bunifuDragControl1
      // 
      this.bunifuDragControl1.Fixed = true;
      this.bunifuDragControl1.Horizontal = true;
      this.bunifuDragControl1.TargetControl = this.panel1;
      this.bunifuDragControl1.Vertical = true;
      // 
      // AjouterEtudiant
      // 
      this.AjouterEtudiant.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
      this.AjouterEtudiant.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
      this.AjouterEtudiant.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.AjouterEtudiant.BorderRadius = 0;
      this.AjouterEtudiant.ButtonText = "Import...";
      this.AjouterEtudiant.Cursor = System.Windows.Forms.Cursors.Hand;
      this.AjouterEtudiant.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(37)))), ((int)(((byte)(76)))));
      this.AjouterEtudiant.Iconcolor = System.Drawing.Color.Transparent;
      this.AjouterEtudiant.Iconimage = ((System.Drawing.Image)(resources.GetObject("AjouterEtudiant.Iconimage")));
      this.AjouterEtudiant.Iconimage_right = null;
      this.AjouterEtudiant.Iconimage_right_Selected = null;
      this.AjouterEtudiant.Iconimage_Selected = null;
      this.AjouterEtudiant.IconMarginLeft = 0;
      this.AjouterEtudiant.IconMarginRight = 0;
      this.AjouterEtudiant.IconRightVisible = true;
      this.AjouterEtudiant.IconRightZoom = 0D;
      this.AjouterEtudiant.IconVisible = false;
      this.AjouterEtudiant.IconZoom = 90D;
      this.AjouterEtudiant.IsTab = false;
      this.AjouterEtudiant.Location = new System.Drawing.Point(451, 97);
      this.AjouterEtudiant.Name = "AjouterEtudiant";
      this.AjouterEtudiant.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
      this.AjouterEtudiant.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
      this.AjouterEtudiant.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(37)))), ((int)(((byte)(76)))));
      this.AjouterEtudiant.selected = false;
      this.AjouterEtudiant.Size = new System.Drawing.Size(129, 33);
      this.AjouterEtudiant.TabIndex = 23;
      this.AjouterEtudiant.Text = "Import...";
      this.AjouterEtudiant.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      this.AjouterEtudiant.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(37)))), ((int)(((byte)(76)))));
      this.AjouterEtudiant.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.AjouterEtudiant.Visible = false;
      this.AjouterEtudiant.Click += new System.EventHandler(this.AjouterEtudiant_Click);
      // 
      // bunifuImageButton1
      // 
      this.bunifuImageButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(17)))), ((int)(((byte)(35)))));
      this.bunifuImageButton1.Cursor = System.Windows.Forms.Cursors.Hand;
      this.bunifuImageButton1.Image = global::StudentManagementBeta.myResouces.icons8_Delete_32px;
      this.bunifuImageButton1.ImageActive = null;
      this.bunifuImageButton1.Location = new System.Drawing.Point(543, 5);
      this.bunifuImageButton1.Name = "bunifuImageButton1";
      this.bunifuImageButton1.Size = new System.Drawing.Size(37, 33);
      this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
      this.bunifuImageButton1.TabIndex = 4;
      this.bunifuImageButton1.TabStop = false;
      this.bunifuImageButton1.Zoom = 10;
      this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
      // 
      // pictureBox1
      // 
      this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
      this.pictureBox1.Image = global::StudentManagementBeta.myResouces.Loader;
      this.pictureBox1.Location = new System.Drawing.Point(230, 137);
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.Size = new System.Drawing.Size(143, 107);
      this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
      this.pictureBox1.TabIndex = 27;
      this.pictureBox1.TabStop = false;
      // 
      // ImportForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(592, 263);
      this.Controls.Add(this.panel2);
      this.Controls.Add(this.panel1);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
      this.Name = "ImportForm";
      this.Text = "ImportForm";
      this.Load += new System.EventHandler(this.ImportForm_Load);
      this.panel1.ResumeLayout(false);
      this.panel2.ResumeLayout(false);
      this.panel2.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
    private System.Windows.Forms.Panel panel2;
    private System.Windows.Forms.Panel panel1;
    private Bunifu.Framework.UI.BunifuMetroTextbox txtImport;
    private System.Windows.Forms.Label label1;
    private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
    private Bunifu.Framework.UI.BunifuFlatButton AjouterEtudiant;
    private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
    private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
    private Bunifu.Framework.UI.BunifuMetroTextbox txtDelim;
    private System.ComponentModel.BackgroundWorker backgroundWorker1;
    private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
    private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel7;
    private System.Windows.Forms.PictureBox pictureBox1;
  }
}