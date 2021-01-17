namespace StudentManagementBeta.Filiere
{
  partial class FiliereForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelFiliere = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSupprimer = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnModifier = new Bunifu.Framework.UI.BunifuFlatButton();
            this.dgvFiliere = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAjouterFiliere = new Bunifu.Framework.UI.BunifuFlatButton();
            this.textBoxNomFiliere = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFiliere)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 3;
            this.bunifuElipse1.TargetControl = this;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(48)))), ((int)(((byte)(87)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.labelFiliere);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(615, 37);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Red;
            this.pictureBox1.Image = global::StudentManagementBeta.Properties.Resources.icons8_Delete_32px;
            this.pictureBox1.Location = new System.Drawing.Point(582, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(33, 32);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // labelFiliere
            // 
            this.labelFiliere.AutoSize = true;
            this.labelFiliere.Font = new System.Drawing.Font("Segoe UI Historic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFiliere.Location = new System.Drawing.Point(21, 3);
            this.labelFiliere.Name = "labelFiliere";
            this.labelFiliere.Size = new System.Drawing.Size(74, 30);
            this.labelFiliere.TabIndex = 0;
            this.labelFiliere.Text = "Filière";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(88)))), ((int)(((byte)(122)))));
            this.panel2.Controls.Add(this.btnSupprimer);
            this.panel2.Controls.Add(this.btnModifier);
            this.panel2.Controls.Add(this.dgvFiliere);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Location = new System.Drawing.Point(0, 34);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(615, 578);
            this.panel2.TabIndex = 1;
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(145)))));
            this.btnSupprimer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(145)))));
            this.btnSupprimer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSupprimer.BorderRadius = 6;
            this.btnSupprimer.ButtonText = "Supprimer";
            this.btnSupprimer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSupprimer.DisabledColor = System.Drawing.Color.Gray;
            this.btnSupprimer.Font = new System.Drawing.Font("Symbol", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.btnSupprimer.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSupprimer.Iconimage = null;
            this.btnSupprimer.Iconimage_right = null;
            this.btnSupprimer.Iconimage_right_Selected = null;
            this.btnSupprimer.Iconimage_Selected = null;
            this.btnSupprimer.IconMarginLeft = 0;
            this.btnSupprimer.IconMarginRight = 0;
            this.btnSupprimer.IconRightVisible = true;
            this.btnSupprimer.IconRightZoom = 0D;
            this.btnSupprimer.IconVisible = true;
            this.btnSupprimer.IconZoom = 90D;
            this.btnSupprimer.IsTab = false;
            this.btnSupprimer.Location = new System.Drawing.Point(319, 389);
            this.btnSupprimer.Margin = new System.Windows.Forms.Padding(6);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(145)))));
            this.btnSupprimer.OnHovercolor = System.Drawing.Color.Teal;
            this.btnSupprimer.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSupprimer.selected = true;
            this.btnSupprimer.Size = new System.Drawing.Size(158, 38);
            this.btnSupprimer.TabIndex = 3;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSupprimer.Textcolor = System.Drawing.Color.White;
            this.btnSupprimer.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // btnModifier
            // 
            this.btnModifier.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(145)))));
            this.btnModifier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(145)))));
            this.btnModifier.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnModifier.BorderRadius = 6;
            this.btnModifier.ButtonText = "Modifier";
            this.btnModifier.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModifier.DisabledColor = System.Drawing.Color.Gray;
            this.btnModifier.Font = new System.Drawing.Font("Symbol", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.btnModifier.Iconcolor = System.Drawing.Color.Transparent;
            this.btnModifier.Iconimage = null;
            this.btnModifier.Iconimage_right = null;
            this.btnModifier.Iconimage_right_Selected = null;
            this.btnModifier.Iconimage_Selected = null;
            this.btnModifier.IconMarginLeft = 0;
            this.btnModifier.IconMarginRight = 0;
            this.btnModifier.IconRightVisible = true;
            this.btnModifier.IconRightZoom = 0D;
            this.btnModifier.IconVisible = true;
            this.btnModifier.IconZoom = 90D;
            this.btnModifier.IsTab = false;
            this.btnModifier.Location = new System.Drawing.Point(156, 389);
            this.btnModifier.Margin = new System.Windows.Forms.Padding(6);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(145)))));
            this.btnModifier.OnHovercolor = System.Drawing.Color.Teal;
            this.btnModifier.OnHoverTextColor = System.Drawing.Color.White;
            this.btnModifier.selected = true;
            this.btnModifier.Size = new System.Drawing.Size(151, 38);
            this.btnModifier.TabIndex = 4;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnModifier.Textcolor = System.Drawing.Color.White;
            this.btnModifier.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // dgvFiliere
            // 
            this.dgvFiliere.AllowUserToAddRows = false;
            this.dgvFiliere.AllowUserToDeleteRows = false;
            this.dgvFiliere.AllowUserToResizeColumns = false;
            this.dgvFiliere.AllowUserToResizeRows = false;
            this.dgvFiliere.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFiliere.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.dgvFiliere.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvFiliere.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvFiliere.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFiliere.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvFiliere.ColumnHeadersHeight = 27;
            this.dgvFiliere.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvFiliere.EnableHeadersVisualStyles = false;
            this.dgvFiliere.GridColor = System.Drawing.Color.SteelBlue;
            this.dgvFiliere.Location = new System.Drawing.Point(156, 190);
            this.dgvFiliere.Name = "dgvFiliere";
            this.dgvFiliere.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFiliere.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvFiliere.RowHeadersVisible = false;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgvFiliere.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvFiliere.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvFiliere.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFiliere.Size = new System.Drawing.Size(321, 170);
            this.dgvFiliere.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAjouterFiliere);
            this.groupBox1.Controls.Add(this.textBoxNomFiliere);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Sitka Small", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Lavender;
            this.groupBox1.Location = new System.Drawing.Point(26, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(548, 114);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ajouter une filière";
            // 
            // btnAjouterFiliere
            // 
            this.btnAjouterFiliere.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(145)))));
            this.btnAjouterFiliere.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(145)))));
            this.btnAjouterFiliere.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAjouterFiliere.BorderRadius = 6;
            this.btnAjouterFiliere.ButtonText = "Ajouter";
            this.btnAjouterFiliere.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAjouterFiliere.DisabledColor = System.Drawing.Color.Gray;
            this.btnAjouterFiliere.Font = new System.Drawing.Font("Symbol", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.btnAjouterFiliere.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAjouterFiliere.Iconimage = null;
            this.btnAjouterFiliere.Iconimage_right = null;
            this.btnAjouterFiliere.Iconimage_right_Selected = null;
            this.btnAjouterFiliere.Iconimage_Selected = null;
            this.btnAjouterFiliere.IconMarginLeft = 0;
            this.btnAjouterFiliere.IconMarginRight = 0;
            this.btnAjouterFiliere.IconRightVisible = true;
            this.btnAjouterFiliere.IconRightZoom = 0D;
            this.btnAjouterFiliere.IconVisible = true;
            this.btnAjouterFiliere.IconZoom = 90D;
            this.btnAjouterFiliere.IsTab = false;
            this.btnAjouterFiliere.Location = new System.Drawing.Point(410, 44);
            this.btnAjouterFiliere.Margin = new System.Windows.Forms.Padding(6);
            this.btnAjouterFiliere.Name = "btnAjouterFiliere";
            this.btnAjouterFiliere.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(145)))));
            this.btnAjouterFiliere.OnHovercolor = System.Drawing.Color.Teal;
            this.btnAjouterFiliere.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAjouterFiliere.selected = true;
            this.btnAjouterFiliere.Size = new System.Drawing.Size(115, 38);
            this.btnAjouterFiliere.TabIndex = 1;
            this.btnAjouterFiliere.Text = "Ajouter";
            this.btnAjouterFiliere.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAjouterFiliere.Textcolor = System.Drawing.Color.White;
            this.btnAjouterFiliere.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouterFiliere.Click += new System.EventHandler(this.btnAjouterFiliere_Click);
            // 
            // textBoxNomFiliere
            // 
            this.textBoxNomFiliere.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBoxNomFiliere.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.textBoxNomFiliere.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNomFiliere.Location = new System.Drawing.Point(208, 56);
            this.textBoxNomFiliere.Name = "textBoxNomFiliere";
            this.textBoxNomFiliere.Size = new System.Drawing.Size(127, 26);
            this.textBoxNomFiliere.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom de filière :";
            // 
            // FiliereForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(615, 550);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FiliereForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormFiliere";
            this.Load += new System.EventHandler(this.FormFiliere_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFiliere)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

    }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuCustomLabel labelFiliere;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private Bunifu.Framework.UI.BunifuFlatButton btnAjouterFiliere;
        private System.Windows.Forms.Label label1;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox textBoxNomFiliere;
        private System.Windows.Forms.DataGridView dgvFiliere;
        private Bunifu.Framework.UI.BunifuFlatButton btnSupprimer;
        private Bunifu.Framework.UI.BunifuFlatButton btnModifier;
    }
}