namespace StudentManagementBeta.Etudiant
{
  partial class EtudiantForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EtudiantForm));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.PanelDrag = new System.Windows.Forms.Panel();
            this.labelFiliere = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.comboBox12 = new System.Windows.Forms.ComboBox();
            this.Homme = new System.Windows.Forms.RadioButton();
            this.bunifuDatepicker1 = new Bunifu.Framework.UI.BunifuDatepicker();
            this.Femme = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.inputTeleEtudiant = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.inputAdresseEtudiant = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.inputNomEtudiant = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.inputPrenomEtudiant = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.inputCNEEtudiant = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuCustomLabel8 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel7 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel6 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.AjouterEtudiant = new Bunifu.Framework.UI.BunifuFlatButton();
            this.PanelDrag.SuspendLayout();
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
            this.PanelDrag.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(220)))), ((int)(((byte)(245)))));
            this.PanelDrag.Controls.Add(this.labelFiliere);
            this.PanelDrag.Controls.Add(this.bunifuImageButton1);
            this.PanelDrag.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.PanelDrag.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelDrag.Location = new System.Drawing.Point(0, 0);
            this.PanelDrag.Name = "PanelDrag";
            this.PanelDrag.Size = new System.Drawing.Size(849, 46);
            this.PanelDrag.TabIndex = 29;
            // 
            // labelFiliere
            // 
            this.labelFiliere.AutoSize = true;
            this.labelFiliere.Font = new System.Drawing.Font("Segoe UI Historic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFiliere.Location = new System.Drawing.Point(387, 8);
            this.labelFiliere.Name = "labelFiliere";
            this.labelFiliere.Size = new System.Drawing.Size(180, 30);
            this.labelFiliere.TabIndex = 4;
            this.labelFiliere.Text = "Ajouter Etudiant";
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(17)))), ((int)(((byte)(35)))));
            this.bunifuImageButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuImageButton1.Image = global::StudentManagementBeta.myResouces.icons8_Delete_32px;
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(800, 6);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(37, 33);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 3;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.PanelDrag;
            this.bunifuDragControl1.Vertical = true;
            // 
            // comboBox12
            // 
            this.comboBox12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(37)))), ((int)(((byte)(76)))));
            this.comboBox12.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox12.ForeColor = System.Drawing.SystemColors.Window;
            this.comboBox12.FormattingEnabled = true;
            this.comboBox12.ItemHeight = 24;
            this.comboBox12.Location = new System.Drawing.Point(130, 459);
            this.comboBox12.Name = "comboBox12";
            this.comboBox12.Size = new System.Drawing.Size(576, 32);
            this.comboBox12.TabIndex = 50;
            // 
            // Homme
            // 
            this.Homme.AutoSize = true;
            this.Homme.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Homme.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Homme.Location = new System.Drawing.Point(247, 272);
            this.Homme.Name = "Homme";
            this.Homme.Size = new System.Drawing.Size(84, 25);
            this.Homme.TabIndex = 49;
            this.Homme.TabStop = true;
            this.Homme.Text = "Homme";
            this.Homme.UseVisualStyleBackColor = true;
            // 
            // bunifuDatepicker1
            // 
            this.bunifuDatepicker1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(79)))), ((int)(((byte)(167)))));
            this.bunifuDatepicker1.BorderRadius = 2;
            this.bunifuDatepicker1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.bunifuDatepicker1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.bunifuDatepicker1.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.bunifuDatepicker1.FormatCustom = null;
            this.bunifuDatepicker1.Location = new System.Drawing.Point(422, 272);
            this.bunifuDatepicker1.Name = "bunifuDatepicker1";
            this.bunifuDatepicker1.Size = new System.Drawing.Size(286, 36);
            this.bunifuDatepicker1.TabIndex = 48;
            this.bunifuDatepicker1.Value = new System.DateTime(2020, 12, 22, 21, 0, 14, 895);
            // 
            // Femme
            // 
            this.Femme.AutoSize = true;
            this.Femme.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Femme.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Femme.Location = new System.Drawing.Point(135, 272);
            this.Femme.Name = "Femme";
            this.Femme.Size = new System.Drawing.Size(80, 25);
            this.Femme.TabIndex = 47;
            this.Femme.TabStop = true;
            this.Femme.Text = "Femme";
            this.Femme.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(254, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(327, 45);
            this.label1.TabIndex = 46;
            this.label1.Text = "Informations Etudiant";
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bunifuSeparator1.LineThickness = 3;
            this.bunifuSeparator1.Location = new System.Drawing.Point(222, 88);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(396, 17);
            this.bunifuSeparator1.TabIndex = 45;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // inputTeleEtudiant
            // 
            this.inputTeleEtudiant.BorderColorFocused = System.Drawing.Color.Blue;
            this.inputTeleEtudiant.BorderColorIdle = System.Drawing.Color.Silver;
            this.inputTeleEtudiant.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.inputTeleEtudiant.BorderThickness = 1;
            this.inputTeleEtudiant.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.inputTeleEtudiant.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.inputTeleEtudiant.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.inputTeleEtudiant.isPassword = false;
            this.inputTeleEtudiant.Location = new System.Drawing.Point(130, 395);
            this.inputTeleEtudiant.Margin = new System.Windows.Forms.Padding(4);
            this.inputTeleEtudiant.Name = "inputTeleEtudiant";
            this.inputTeleEtudiant.Size = new System.Drawing.Size(578, 33);
            this.inputTeleEtudiant.TabIndex = 44;
            this.inputTeleEtudiant.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // inputAdresseEtudiant
            // 
            this.inputAdresseEtudiant.BorderColorFocused = System.Drawing.Color.Blue;
            this.inputAdresseEtudiant.BorderColorIdle = System.Drawing.Color.Silver;
            this.inputAdresseEtudiant.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.inputAdresseEtudiant.BorderThickness = 1;
            this.inputAdresseEtudiant.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.inputAdresseEtudiant.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.inputAdresseEtudiant.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.inputAdresseEtudiant.isPassword = false;
            this.inputAdresseEtudiant.Location = new System.Drawing.Point(130, 329);
            this.inputAdresseEtudiant.Margin = new System.Windows.Forms.Padding(4);
            this.inputAdresseEtudiant.Name = "inputAdresseEtudiant";
            this.inputAdresseEtudiant.Size = new System.Drawing.Size(578, 33);
            this.inputAdresseEtudiant.TabIndex = 43;
            this.inputAdresseEtudiant.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // inputNomEtudiant
            // 
            this.inputNomEtudiant.BorderColorFocused = System.Drawing.Color.Blue;
            this.inputNomEtudiant.BorderColorIdle = System.Drawing.Color.Silver;
            this.inputNomEtudiant.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.inputNomEtudiant.BorderThickness = 1;
            this.inputNomEtudiant.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.inputNomEtudiant.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.inputNomEtudiant.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.inputNomEtudiant.isPassword = false;
            this.inputNomEtudiant.Location = new System.Drawing.Point(130, 206);
            this.inputNomEtudiant.Margin = new System.Windows.Forms.Padding(4);
            this.inputNomEtudiant.Name = "inputNomEtudiant";
            this.inputNomEtudiant.Size = new System.Drawing.Size(286, 33);
            this.inputNomEtudiant.TabIndex = 42;
            this.inputNomEtudiant.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // inputPrenomEtudiant
            // 
            this.inputPrenomEtudiant.BorderColorFocused = System.Drawing.Color.Blue;
            this.inputPrenomEtudiant.BorderColorIdle = System.Drawing.Color.Silver;
            this.inputPrenomEtudiant.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.inputPrenomEtudiant.BorderThickness = 1;
            this.inputPrenomEtudiant.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.inputPrenomEtudiant.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.inputPrenomEtudiant.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.inputPrenomEtudiant.isPassword = false;
            this.inputPrenomEtudiant.Location = new System.Drawing.Point(422, 206);
            this.inputPrenomEtudiant.Margin = new System.Windows.Forms.Padding(4);
            this.inputPrenomEtudiant.Name = "inputPrenomEtudiant";
            this.inputPrenomEtudiant.Size = new System.Drawing.Size(286, 33);
            this.inputPrenomEtudiant.TabIndex = 41;
            this.inputPrenomEtudiant.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // inputCNEEtudiant
            // 
            this.inputCNEEtudiant.BorderColorFocused = System.Drawing.Color.Blue;
            this.inputCNEEtudiant.BorderColorIdle = System.Drawing.Color.Silver;
            this.inputCNEEtudiant.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.inputCNEEtudiant.BorderThickness = 1;
            this.inputCNEEtudiant.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.inputCNEEtudiant.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.inputCNEEtudiant.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.inputCNEEtudiant.isPassword = false;
            this.inputCNEEtudiant.Location = new System.Drawing.Point(132, 141);
            this.inputCNEEtudiant.Margin = new System.Windows.Forms.Padding(4);
            this.inputCNEEtudiant.Name = "inputCNEEtudiant";
            this.inputCNEEtudiant.Size = new System.Drawing.Size(578, 33);
            this.inputCNEEtudiant.TabIndex = 40;
            this.inputCNEEtudiant.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel8
            // 
            this.bunifuCustomLabel8.AutoSize = true;
            this.bunifuCustomLabel8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel8.ForeColor = System.Drawing.SystemColors.Window;
            this.bunifuCustomLabel8.Location = new System.Drawing.Point(139, 376);
            this.bunifuCustomLabel8.Name = "bunifuCustomLabel8";
            this.bunifuCustomLabel8.Size = new System.Drawing.Size(61, 15);
            this.bunifuCustomLabel8.TabIndex = 39;
            this.bunifuCustomLabel8.Text = "Téléphone";
            // 
            // bunifuCustomLabel7
            // 
            this.bunifuCustomLabel7.AutoSize = true;
            this.bunifuCustomLabel7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel7.ForeColor = System.Drawing.SystemColors.Window;
            this.bunifuCustomLabel7.Location = new System.Drawing.Point(139, 310);
            this.bunifuCustomLabel7.Name = "bunifuCustomLabel7";
            this.bunifuCustomLabel7.Size = new System.Drawing.Size(48, 15);
            this.bunifuCustomLabel7.TabIndex = 38;
            this.bunifuCustomLabel7.Text = "Adresse";
            // 
            // bunifuCustomLabel6
            // 
            this.bunifuCustomLabel6.AutoSize = true;
            this.bunifuCustomLabel6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel6.ForeColor = System.Drawing.SystemColors.Window;
            this.bunifuCustomLabel6.Location = new System.Drawing.Point(428, 253);
            this.bunifuCustomLabel6.Name = "bunifuCustomLabel6";
            this.bunifuCustomLabel6.Size = new System.Drawing.Size(101, 15);
            this.bunifuCustomLabel6.TabIndex = 37;
            this.bunifuCustomLabel6.Text = "Date de naissance";
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel5.ForeColor = System.Drawing.SystemColors.Window;
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(136, 253);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(31, 15);
            this.bunifuCustomLabel5.TabIndex = 36;
            this.bunifuCustomLabel5.Text = "Sexe";
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel4.ForeColor = System.Drawing.SystemColors.Window;
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(136, 187);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(34, 15);
            this.bunifuCustomLabel4.TabIndex = 35;
            this.bunifuCustomLabel4.Text = "Nom";
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.ForeColor = System.Drawing.SystemColors.Window;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(429, 187);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(49, 15);
            this.bunifuCustomLabel3.TabIndex = 34;
            this.bunifuCustomLabel3.Text = "Prenom";
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.SystemColors.Window;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(136, 441);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(38, 15);
            this.bunifuCustomLabel2.TabIndex = 33;
            this.bunifuCustomLabel2.Text = "Filière";
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.SystemColors.Window;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(139, 122);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(33, 15);
            this.bunifuCustomLabel1.TabIndex = 32;
            this.bunifuCustomLabel1.Text = "CNE ";
            // 
            // AjouterEtudiant
            // 
            this.AjouterEtudiant.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.AjouterEtudiant.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.AjouterEtudiant.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AjouterEtudiant.BorderRadius = 0;
            this.AjouterEtudiant.ButtonText = "Ajouter";
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
            this.AjouterEtudiant.Location = new System.Drawing.Point(283, 520);
            this.AjouterEtudiant.Name = "AjouterEtudiant";
            this.AjouterEtudiant.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.AjouterEtudiant.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.AjouterEtudiant.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(37)))), ((int)(((byte)(76)))));
            this.AjouterEtudiant.selected = false;
            this.AjouterEtudiant.Size = new System.Drawing.Size(261, 45);
            this.AjouterEtudiant.TabIndex = 30;
            this.AjouterEtudiant.Text = "Ajouter";
            this.AjouterEtudiant.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.AjouterEtudiant.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(37)))), ((int)(((byte)(76)))));
            this.AjouterEtudiant.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AjouterEtudiant.Click += new System.EventHandler(this.AjouterEtudiant_Click_1);
            // 
            // EtudiantForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(79)))), ((int)(((byte)(167)))));
            this.ClientSize = new System.Drawing.Size(849, 577);
            this.Controls.Add(this.comboBox12);
            this.Controls.Add(this.Homme);
            this.Controls.Add(this.bunifuDatepicker1);
            this.Controls.Add(this.Femme);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bunifuSeparator1);
            this.Controls.Add(this.inputTeleEtudiant);
            this.Controls.Add(this.inputAdresseEtudiant);
            this.Controls.Add(this.inputNomEtudiant);
            this.Controls.Add(this.inputPrenomEtudiant);
            this.Controls.Add(this.inputCNEEtudiant);
            this.Controls.Add(this.bunifuCustomLabel8);
            this.Controls.Add(this.bunifuCustomLabel7);
            this.Controls.Add(this.bunifuCustomLabel6);
            this.Controls.Add(this.bunifuCustomLabel5);
            this.Controls.Add(this.bunifuCustomLabel4);
            this.Controls.Add(this.bunifuCustomLabel3);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.AjouterEtudiant);
            this.Controls.Add(this.PanelDrag);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EtudiantForm";
            this.Text = "Form_Etudiant";
            this.Load += new System.EventHandler(this.Form_Etudiant_Load);
            this.PanelDrag.ResumeLayout(false);
            this.PanelDrag.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

        #endregion
    private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
    private System.Windows.Forms.Panel PanelDrag;
    private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
    private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
    private Bunifu.Framework.UI.BunifuCustomLabel labelFiliere;
        private System.Windows.Forms.ComboBox comboBox12;
        private System.Windows.Forms.RadioButton Homme;
        private Bunifu.Framework.UI.BunifuDatepicker bunifuDatepicker1;
        private System.Windows.Forms.RadioButton Femme;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private Bunifu.Framework.UI.BunifuMetroTextbox inputTeleEtudiant;
        private Bunifu.Framework.UI.BunifuMetroTextbox inputAdresseEtudiant;
        private Bunifu.Framework.UI.BunifuMetroTextbox inputNomEtudiant;
        private Bunifu.Framework.UI.BunifuMetroTextbox inputPrenomEtudiant;
        private Bunifu.Framework.UI.BunifuMetroTextbox inputCNEEtudiant;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel8;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel7;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel6;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuFlatButton AjouterEtudiant;
    }
}