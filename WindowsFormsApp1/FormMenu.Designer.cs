namespace ApplicationUI
{
  partial class FormMenu
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenu));
      this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
      this.PanelDrag = new System.Windows.Forms.Panel();
      this.panel2 = new System.Windows.Forms.Panel();
      this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
      this.bunifuTileButton5 = new Bunifu.Framework.UI.BunifuTileButton();
      this.bunifuTileButton4 = new Bunifu.Framework.UI.BunifuTileButton();
      this.bunifuTileButton3 = new Bunifu.Framework.UI.BunifuTileButton();
      this.bunifuTileButton2 = new Bunifu.Framework.UI.BunifuTileButton();
      this.bunifuTileButton1 = new Bunifu.Framework.UI.BunifuTileButton();
      this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
      this.PanelDrag.SuspendLayout();
      this.panel2.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
      this.SuspendLayout();
      // 
      // bunifuElipse1
      // 
      this.bunifuElipse1.ElipseRadius = 5;
      this.bunifuElipse1.TargetControl = this;
      // 
      // PanelDrag
      // 
      this.PanelDrag.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(118)))), ((int)(((byte)(184)))));
      this.PanelDrag.Controls.Add(this.bunifuImageButton1);
      this.PanelDrag.Cursor = System.Windows.Forms.Cursors.SizeAll;
      this.PanelDrag.Dock = System.Windows.Forms.DockStyle.Top;
      this.PanelDrag.Location = new System.Drawing.Point(0, 0);
      this.PanelDrag.Name = "PanelDrag";
      this.PanelDrag.Size = new System.Drawing.Size(800, 42);
      this.PanelDrag.TabIndex = 0;
      // 
      // panel2
      // 
      this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(151)))), ((int)(((byte)(225)))));
      this.panel2.Controls.Add(this.bunifuTileButton5);
      this.panel2.Controls.Add(this.bunifuTileButton4);
      this.panel2.Controls.Add(this.bunifuTileButton3);
      this.panel2.Controls.Add(this.bunifuTileButton2);
      this.panel2.Controls.Add(this.bunifuTileButton1);
      this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
      this.panel2.Location = new System.Drawing.Point(0, 42);
      this.panel2.Name = "panel2";
      this.panel2.Size = new System.Drawing.Size(800, 358);
      this.panel2.TabIndex = 1;
      this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
      // 
      // bunifuDragControl1
      // 
      this.bunifuDragControl1.Fixed = true;
      this.bunifuDragControl1.Horizontal = true;
      this.bunifuDragControl1.TargetControl = this.PanelDrag;
      this.bunifuDragControl1.Vertical = true;
      // 
      // bunifuTileButton5
      // 
      this.bunifuTileButton5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(79)))), ((int)(((byte)(167)))));
      this.bunifuTileButton5.color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(79)))), ((int)(((byte)(167)))));
      this.bunifuTileButton5.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(97)))), ((int)(((byte)(204)))));
      this.bunifuTileButton5.Cursor = System.Windows.Forms.Cursors.Hand;
      this.bunifuTileButton5.Font = new System.Drawing.Font("Century Gothic", 15.75F);
      this.bunifuTileButton5.ForeColor = System.Drawing.Color.White;
      this.bunifuTileButton5.Image = global::ApplicationUI.Resource.icons8_Upload_64px_1;
      this.bunifuTileButton5.ImagePosition = 20;
      this.bunifuTileButton5.ImageZoom = 45;
      this.bunifuTileButton5.LabelPosition = 41;
      this.bunifuTileButton5.LabelText = "Import";
      this.bunifuTileButton5.Location = new System.Drawing.Point(441, 211);
      this.bunifuTileButton5.Margin = new System.Windows.Forms.Padding(6);
      this.bunifuTileButton5.Name = "bunifuTileButton5";
      this.bunifuTileButton5.Size = new System.Drawing.Size(136, 123);
      this.bunifuTileButton5.TabIndex = 5;
      this.bunifuTileButton5.Click += new System.EventHandler(this.bunifuTileButton5_Click);
      // 
      // bunifuTileButton4
      // 
      this.bunifuTileButton4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(79)))), ((int)(((byte)(167)))));
      this.bunifuTileButton4.color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(79)))), ((int)(((byte)(167)))));
      this.bunifuTileButton4.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(97)))), ((int)(((byte)(204)))));
      this.bunifuTileButton4.Cursor = System.Windows.Forms.Cursors.Hand;
      this.bunifuTileButton4.Font = new System.Drawing.Font("Century Gothic", 15.75F);
      this.bunifuTileButton4.ForeColor = System.Drawing.Color.White;
      this.bunifuTileButton4.Image = global::ApplicationUI.Resource.icons8_Edit_Pie_Chart_Report_64px;
      this.bunifuTileButton4.ImagePosition = 20;
      this.bunifuTileButton4.ImageZoom = 45;
      this.bunifuTileButton4.LabelPosition = 41;
      this.bunifuTileButton4.LabelText = "Reportig";
      this.bunifuTileButton4.Location = new System.Drawing.Point(218, 211);
      this.bunifuTileButton4.Margin = new System.Windows.Forms.Padding(6);
      this.bunifuTileButton4.Name = "bunifuTileButton4";
      this.bunifuTileButton4.Size = new System.Drawing.Size(136, 123);
      this.bunifuTileButton4.TabIndex = 4;
      this.bunifuTileButton4.Click += new System.EventHandler(this.bunifuTileButton4_Click);
      // 
      // bunifuTileButton3
      // 
      this.bunifuTileButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(79)))), ((int)(((byte)(167)))));
      this.bunifuTileButton3.color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(79)))), ((int)(((byte)(167)))));
      this.bunifuTileButton3.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(97)))), ((int)(((byte)(204)))));
      this.bunifuTileButton3.Cursor = System.Windows.Forms.Cursors.Hand;
      this.bunifuTileButton3.Font = new System.Drawing.Font("Century Gothic", 15.75F);
      this.bunifuTileButton3.ForeColor = System.Drawing.Color.White;
      this.bunifuTileButton3.Image = global::ApplicationUI.Resource.icons8_Statistics_64px;
      this.bunifuTileButton3.ImagePosition = 20;
      this.bunifuTileButton3.ImageZoom = 50;
      this.bunifuTileButton3.LabelPosition = 41;
      this.bunifuTileButton3.LabelText = "Statistics";
      this.bunifuTileButton3.Location = new System.Drawing.Point(567, 64);
      this.bunifuTileButton3.Margin = new System.Windows.Forms.Padding(6);
      this.bunifuTileButton3.Name = "bunifuTileButton3";
      this.bunifuTileButton3.Size = new System.Drawing.Size(136, 121);
      this.bunifuTileButton3.TabIndex = 3;
      this.bunifuTileButton3.Click += new System.EventHandler(this.bunifuTileButton3_Click);
      // 
      // bunifuTileButton2
      // 
      this.bunifuTileButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(79)))), ((int)(((byte)(167)))));
      this.bunifuTileButton2.color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(79)))), ((int)(((byte)(167)))));
      this.bunifuTileButton2.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(97)))), ((int)(((byte)(204)))));
      this.bunifuTileButton2.Cursor = System.Windows.Forms.Cursors.Hand;
      this.bunifuTileButton2.Font = new System.Drawing.Font("Century Gothic", 15.75F);
      this.bunifuTileButton2.ForeColor = System.Drawing.Color.White;
      this.bunifuTileButton2.Image = ((System.Drawing.Image)(resources.GetObject("bunifuTileButton2.Image")));
      this.bunifuTileButton2.ImagePosition = 20;
      this.bunifuTileButton2.ImageZoom = 50;
      this.bunifuTileButton2.LabelPosition = 41;
      this.bunifuTileButton2.LabelText = "Filiere";
      this.bunifuTileButton2.Location = new System.Drawing.Point(332, 64);
      this.bunifuTileButton2.Margin = new System.Windows.Forms.Padding(6);
      this.bunifuTileButton2.Name = "bunifuTileButton2";
      this.bunifuTileButton2.Size = new System.Drawing.Size(136, 121);
      this.bunifuTileButton2.TabIndex = 2;
      this.bunifuTileButton2.Click += new System.EventHandler(this.bunifuTileButton2_Click);
      // 
      // bunifuTileButton1
      // 
      this.bunifuTileButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(79)))), ((int)(((byte)(167)))));
      this.bunifuTileButton1.color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(79)))), ((int)(((byte)(167)))));
      this.bunifuTileButton1.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(97)))), ((int)(((byte)(204)))));
      this.bunifuTileButton1.Cursor = System.Windows.Forms.Cursors.Hand;
      this.bunifuTileButton1.Font = new System.Drawing.Font("Century Gothic", 15.75F);
      this.bunifuTileButton1.ForeColor = System.Drawing.Color.White;
      this.bunifuTileButton1.Image = global::ApplicationUI.Resource.icons8_Student_Male_64px;
      this.bunifuTileButton1.ImagePosition = 20;
      this.bunifuTileButton1.ImageZoom = 50;
      this.bunifuTileButton1.LabelPosition = 41;
      this.bunifuTileButton1.LabelText = "Etudiant";
      this.bunifuTileButton1.Location = new System.Drawing.Point(97, 64);
      this.bunifuTileButton1.Margin = new System.Windows.Forms.Padding(6);
      this.bunifuTileButton1.Name = "bunifuTileButton1";
      this.bunifuTileButton1.Size = new System.Drawing.Size(136, 121);
      this.bunifuTileButton1.TabIndex = 1;
      this.bunifuTileButton1.Click += new System.EventHandler(this.bunifuTileButton1_Click);
      // 
      // bunifuImageButton1
      // 
      this.bunifuImageButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(17)))), ((int)(((byte)(35)))));
      this.bunifuImageButton1.Cursor = System.Windows.Forms.Cursors.Hand;
      this.bunifuImageButton1.Image = global::ApplicationUI.Resource.icons8_Delete;
      this.bunifuImageButton1.ImageActive = null;
      this.bunifuImageButton1.Location = new System.Drawing.Point(759, 3);
      this.bunifuImageButton1.Name = "bunifuImageButton1";
      this.bunifuImageButton1.Size = new System.Drawing.Size(37, 33);
      this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
      this.bunifuImageButton1.TabIndex = 3;
      this.bunifuImageButton1.TabStop = false;
      this.bunifuImageButton1.Zoom = 10;
      this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
      // 
      // FormMenu
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 400);
      this.Controls.Add(this.panel2);
      this.Controls.Add(this.PanelDrag);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
      this.Name = "FormMenu";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Form1";
      this.PanelDrag.ResumeLayout(false);
      this.panel2.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
    private System.Windows.Forms.Panel panel2;
    private System.Windows.Forms.Panel PanelDrag;
    private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
    private Bunifu.Framework.UI.BunifuTileButton bunifuTileButton1;
    private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
    private Bunifu.Framework.UI.BunifuTileButton bunifuTileButton4;
    private Bunifu.Framework.UI.BunifuTileButton bunifuTileButton3;
    private Bunifu.Framework.UI.BunifuTileButton bunifuTileButton2;
    private Bunifu.Framework.UI.BunifuTileButton bunifuTileButton5;
  }
}

