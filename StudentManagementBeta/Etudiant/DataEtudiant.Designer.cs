
namespace StudentManagementBeta.Etudiant
{
  partial class DataEtudiant
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataEtudiant));
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuCustomDataGrid1 = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.CNE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prenom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sexe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DOB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Adresse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tele = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Filiere = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuMaterialTextbox1 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.AjouterEtudiant = new Bunifu.Framework.UI.BunifuFlatButton();
            this.supprimerEtudiant = new Bunifu.Framework.UI.BunifuFlatButton();
            this.ChargerData = new Bunifu.Framework.UI.BunifuFlatButton();
            this.ModifierEtudiant = new Bunifu.Framework.UI.BunifuFlatButton();
            this.TriCroissant = new Bunifu.Framework.UI.BunifuFlatButton();
            this.TriDecroissant = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.bunifuCustomDataGrid1);
            this.panel1.Location = new System.Drawing.Point(11, 72);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(880, 358);
            this.panel1.TabIndex = 0;
            // 
            // bunifuCustomDataGrid1
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bunifuCustomDataGrid1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.bunifuCustomDataGrid1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.bunifuCustomDataGrid1.BackgroundColor = System.Drawing.Color.White;
            this.bunifuCustomDataGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bunifuCustomDataGrid1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.bunifuCustomDataGrid1.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.bunifuCustomDataGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(65)))), ((int)(((byte)(109)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bunifuCustomDataGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.bunifuCustomDataGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bunifuCustomDataGrid1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CNE,
            this.Nom,
            this.Prenom,
            this.Sexe,
            this.DOB,
            this.Adresse,
            this.Tele,
            this.Filiere});
            this.bunifuCustomDataGrid1.DoubleBuffered = true;
            this.bunifuCustomDataGrid1.EnableHeadersVisualStyles = false;
            this.bunifuCustomDataGrid1.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(65)))), ((int)(((byte)(109)))));
            this.bunifuCustomDataGrid1.HeaderForeColor = System.Drawing.Color.White;
            this.bunifuCustomDataGrid1.Location = new System.Drawing.Point(0, 0);
            this.bunifuCustomDataGrid1.Name = "bunifuCustomDataGrid1";
            this.bunifuCustomDataGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.bunifuCustomDataGrid1.Size = new System.Drawing.Size(880, 358);
            this.bunifuCustomDataGrid1.TabIndex = 0;
            // 
            // CNE
            // 
            this.CNE.HeaderText = "CNE";
            this.CNE.Name = "CNE";
            // 
            // Nom
            // 
            this.Nom.HeaderText = "Nom";
            this.Nom.Name = "Nom";
            // 
            // Prenom
            // 
            this.Prenom.HeaderText = "Prénom";
            this.Prenom.Name = "Prenom";
            // 
            // Sexe
            // 
            this.Sexe.HeaderText = "Sexe";
            this.Sexe.Name = "Sexe";
            // 
            // DOB
            // 
            this.DOB.HeaderText = "Date de naissance";
            this.DOB.Name = "DOB";
            // 
            // Adresse
            // 
            this.Adresse.HeaderText = "Adresse";
            this.Adresse.Name = "Adresse";
            // 
            // Tele
            // 
            this.Tele.HeaderText = "Téléphone";
            this.Tele.Name = "Tele";
            // 
            // Filiere
            // 
            this.Filiere.HeaderText = "Filière";
            this.Filiere.Name = "Filiere";
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 8;
            this.bunifuElipse1.TargetControl = this.bunifuCustomDataGrid1;
            // 
            // bunifuMaterialTextbox1
            // 
            this.bunifuMaterialTextbox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuMaterialTextbox1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.bunifuMaterialTextbox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuMaterialTextbox1.HintForeColor = System.Drawing.Color.Empty;
            this.bunifuMaterialTextbox1.HintText = "";
            this.bunifuMaterialTextbox1.isPassword = false;
            this.bunifuMaterialTextbox1.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(65)))), ((int)(((byte)(109)))));
            this.bunifuMaterialTextbox1.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(65)))), ((int)(((byte)(109)))));
            this.bunifuMaterialTextbox1.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(65)))), ((int)(((byte)(109)))));
            this.bunifuMaterialTextbox1.LineThickness = 3;
            this.bunifuMaterialTextbox1.Location = new System.Drawing.Point(24, 23);
            this.bunifuMaterialTextbox1.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuMaterialTextbox1.Name = "bunifuMaterialTextbox1";
            this.bunifuMaterialTextbox1.Size = new System.Drawing.Size(850, 33);
            this.bunifuMaterialTextbox1.TabIndex = 1;
            this.bunifuMaterialTextbox1.Text = "Chercher un Etudiant ";
            this.bunifuMaterialTextbox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(225)))), ((int)(((byte)(231)))));
            this.bunifuImageButton1.Image = global::StudentManagementBeta.myResouces.icons8_search_96px_1;
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(841, 23);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(33, 24);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 8;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            // 
            // AjouterEtudiant
            // 
            this.AjouterEtudiant.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.AjouterEtudiant.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(65)))), ((int)(((byte)(109)))));
            this.AjouterEtudiant.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AjouterEtudiant.BorderRadius = 0;
            this.AjouterEtudiant.ButtonText = "Ajouter";
            this.AjouterEtudiant.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AjouterEtudiant.DisabledColor = System.Drawing.Color.Gray;
            this.AjouterEtudiant.Iconcolor = System.Drawing.Color.Transparent;
            this.AjouterEtudiant.Iconimage = ((System.Drawing.Image)(resources.GetObject("AjouterEtudiant.Iconimage")));
            this.AjouterEtudiant.Iconimage_right = null;
            this.AjouterEtudiant.Iconimage_right_Selected = null;
            this.AjouterEtudiant.Iconimage_Selected = null;
            this.AjouterEtudiant.IconMarginLeft = 0;
            this.AjouterEtudiant.IconMarginRight = 0;
            this.AjouterEtudiant.IconRightVisible = true;
            this.AjouterEtudiant.IconRightZoom = 0D;
            this.AjouterEtudiant.IconVisible = true;
            this.AjouterEtudiant.IconZoom = 90D;
            this.AjouterEtudiant.IsTab = false;
            this.AjouterEtudiant.Location = new System.Drawing.Point(452, 488);
            this.AjouterEtudiant.Name = "AjouterEtudiant";
            this.AjouterEtudiant.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(65)))), ((int)(((byte)(109)))));
            this.AjouterEtudiant.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(65)))), ((int)(((byte)(109)))));
            this.AjouterEtudiant.OnHoverTextColor = System.Drawing.Color.White;
            this.AjouterEtudiant.selected = false;
            this.AjouterEtudiant.Size = new System.Drawing.Size(422, 48);
            this.AjouterEtudiant.TabIndex = 7;
            this.AjouterEtudiant.Text = "Ajouter";
            this.AjouterEtudiant.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AjouterEtudiant.Textcolor = System.Drawing.Color.White;
            this.AjouterEtudiant.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AjouterEtudiant.Click += new System.EventHandler(this.AjouterEtudiant_Click);
            // 
            // supprimerEtudiant
            // 
            this.supprimerEtudiant.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.supprimerEtudiant.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(65)))), ((int)(((byte)(109)))));
            this.supprimerEtudiant.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.supprimerEtudiant.BorderRadius = 0;
            this.supprimerEtudiant.ButtonText = "Supprimer ";
            this.supprimerEtudiant.Cursor = System.Windows.Forms.Cursors.Hand;
            this.supprimerEtudiant.DisabledColor = System.Drawing.Color.Gray;
            this.supprimerEtudiant.Iconcolor = System.Drawing.Color.Transparent;
            this.supprimerEtudiant.Iconimage = ((System.Drawing.Image)(resources.GetObject("supprimerEtudiant.Iconimage")));
            this.supprimerEtudiant.Iconimage_right = null;
            this.supprimerEtudiant.Iconimage_right_Selected = null;
            this.supprimerEtudiant.Iconimage_Selected = null;
            this.supprimerEtudiant.IconMarginLeft = 0;
            this.supprimerEtudiant.IconMarginRight = 0;
            this.supprimerEtudiant.IconRightVisible = true;
            this.supprimerEtudiant.IconRightZoom = 0D;
            this.supprimerEtudiant.IconVisible = true;
            this.supprimerEtudiant.IconZoom = 90D;
            this.supprimerEtudiant.IsTab = false;
            this.supprimerEtudiant.Location = new System.Drawing.Point(666, 436);
            this.supprimerEtudiant.Name = "supprimerEtudiant";
            this.supprimerEtudiant.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(65)))), ((int)(((byte)(109)))));
            this.supprimerEtudiant.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(65)))), ((int)(((byte)(109)))));
            this.supprimerEtudiant.OnHoverTextColor = System.Drawing.Color.White;
            this.supprimerEtudiant.selected = false;
            this.supprimerEtudiant.Size = new System.Drawing.Size(208, 46);
            this.supprimerEtudiant.TabIndex = 6;
            this.supprimerEtudiant.Text = "Supprimer ";
            this.supprimerEtudiant.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.supprimerEtudiant.Textcolor = System.Drawing.Color.White;
            this.supprimerEtudiant.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // ChargerData
            // 
            this.ChargerData.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.ChargerData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(65)))), ((int)(((byte)(109)))));
            this.ChargerData.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ChargerData.BorderRadius = 0;
            this.ChargerData.ButtonText = "Charger Données";
            this.ChargerData.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ChargerData.DisabledColor = System.Drawing.Color.Gray;
            this.ChargerData.Iconcolor = System.Drawing.Color.Transparent;
            this.ChargerData.Iconimage = ((System.Drawing.Image)(resources.GetObject("ChargerData.Iconimage")));
            this.ChargerData.Iconimage_right = null;
            this.ChargerData.Iconimage_right_Selected = null;
            this.ChargerData.Iconimage_Selected = null;
            this.ChargerData.IconMarginLeft = 0;
            this.ChargerData.IconMarginRight = 0;
            this.ChargerData.IconRightVisible = true;
            this.ChargerData.IconRightZoom = 0D;
            this.ChargerData.IconVisible = true;
            this.ChargerData.IconZoom = 90D;
            this.ChargerData.IsTab = false;
            this.ChargerData.Location = new System.Drawing.Point(24, 488);
            this.ChargerData.Name = "ChargerData";
            this.ChargerData.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(65)))), ((int)(((byte)(109)))));
            this.ChargerData.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(65)))), ((int)(((byte)(109)))));
            this.ChargerData.OnHoverTextColor = System.Drawing.Color.White;
            this.ChargerData.selected = false;
            this.ChargerData.Size = new System.Drawing.Size(422, 48);
            this.ChargerData.TabIndex = 5;
            this.ChargerData.Text = "Charger Données";
            this.ChargerData.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ChargerData.Textcolor = System.Drawing.Color.White;
            this.ChargerData.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // ModifierEtudiant
            // 
            this.ModifierEtudiant.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.ModifierEtudiant.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(65)))), ((int)(((byte)(109)))));
            this.ModifierEtudiant.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ModifierEtudiant.BorderRadius = 0;
            this.ModifierEtudiant.ButtonText = "Modifier";
            this.ModifierEtudiant.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ModifierEtudiant.DisabledColor = System.Drawing.Color.Gray;
            this.ModifierEtudiant.Iconcolor = System.Drawing.Color.Transparent;
            this.ModifierEtudiant.Iconimage = ((System.Drawing.Image)(resources.GetObject("ModifierEtudiant.Iconimage")));
            this.ModifierEtudiant.Iconimage_right = null;
            this.ModifierEtudiant.Iconimage_right_Selected = null;
            this.ModifierEtudiant.Iconimage_Selected = null;
            this.ModifierEtudiant.IconMarginLeft = 0;
            this.ModifierEtudiant.IconMarginRight = 0;
            this.ModifierEtudiant.IconRightVisible = true;
            this.ModifierEtudiant.IconRightZoom = 0D;
            this.ModifierEtudiant.IconVisible = true;
            this.ModifierEtudiant.IconZoom = 90D;
            this.ModifierEtudiant.IsTab = false;
            this.ModifierEtudiant.Location = new System.Drawing.Point(452, 436);
            this.ModifierEtudiant.Name = "ModifierEtudiant";
            this.ModifierEtudiant.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(65)))), ((int)(((byte)(109)))));
            this.ModifierEtudiant.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(65)))), ((int)(((byte)(109)))));
            this.ModifierEtudiant.OnHoverTextColor = System.Drawing.Color.White;
            this.ModifierEtudiant.selected = false;
            this.ModifierEtudiant.Size = new System.Drawing.Size(208, 46);
            this.ModifierEtudiant.TabIndex = 4;
            this.ModifierEtudiant.Text = "Modifier";
            this.ModifierEtudiant.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ModifierEtudiant.Textcolor = System.Drawing.Color.White;
            this.ModifierEtudiant.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // TriCroissant
            // 
            this.TriCroissant.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.TriCroissant.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(65)))), ((int)(((byte)(109)))));
            this.TriCroissant.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.TriCroissant.BorderRadius = 0;
            this.TriCroissant.ButtonText = "Tri Décroissant";
            this.TriCroissant.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TriCroissant.DisabledColor = System.Drawing.Color.Gray;
            this.TriCroissant.Iconcolor = System.Drawing.Color.Transparent;
            this.TriCroissant.Iconimage = ((System.Drawing.Image)(resources.GetObject("TriCroissant.Iconimage")));
            this.TriCroissant.Iconimage_right = null;
            this.TriCroissant.Iconimage_right_Selected = null;
            this.TriCroissant.Iconimage_Selected = null;
            this.TriCroissant.IconMarginLeft = 0;
            this.TriCroissant.IconMarginRight = 0;
            this.TriCroissant.IconRightVisible = true;
            this.TriCroissant.IconRightZoom = 0D;
            this.TriCroissant.IconVisible = true;
            this.TriCroissant.IconZoom = 90D;
            this.TriCroissant.IsTab = false;
            this.TriCroissant.Location = new System.Drawing.Point(24, 436);
            this.TriCroissant.Name = "TriCroissant";
            this.TriCroissant.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(65)))), ((int)(((byte)(109)))));
            this.TriCroissant.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(65)))), ((int)(((byte)(109)))));
            this.TriCroissant.OnHoverTextColor = System.Drawing.Color.White;
            this.TriCroissant.selected = false;
            this.TriCroissant.Size = new System.Drawing.Size(208, 46);
            this.TriCroissant.TabIndex = 3;
            this.TriCroissant.Text = "Tri Décroissant";
            this.TriCroissant.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TriCroissant.Textcolor = System.Drawing.Color.White;
            this.TriCroissant.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // TriDecroissant
            // 
            this.TriDecroissant.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.TriDecroissant.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(65)))), ((int)(((byte)(109)))));
            this.TriDecroissant.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.TriDecroissant.BorderRadius = 0;
            this.TriDecroissant.ButtonText = "Tri Croissant";
            this.TriDecroissant.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TriDecroissant.DisabledColor = System.Drawing.Color.Gray;
            this.TriDecroissant.Iconcolor = System.Drawing.Color.Transparent;
            this.TriDecroissant.Iconimage = ((System.Drawing.Image)(resources.GetObject("TriDecroissant.Iconimage")));
            this.TriDecroissant.Iconimage_right = null;
            this.TriDecroissant.Iconimage_right_Selected = null;
            this.TriDecroissant.Iconimage_Selected = null;
            this.TriDecroissant.IconMarginLeft = 0;
            this.TriDecroissant.IconMarginRight = 0;
            this.TriDecroissant.IconRightVisible = true;
            this.TriDecroissant.IconRightZoom = 0D;
            this.TriDecroissant.IconVisible = true;
            this.TriDecroissant.IconZoom = 90D;
            this.TriDecroissant.IsTab = false;
            this.TriDecroissant.Location = new System.Drawing.Point(238, 436);
            this.TriDecroissant.Name = "TriDecroissant";
            this.TriDecroissant.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(65)))), ((int)(((byte)(109)))));
            this.TriDecroissant.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(65)))), ((int)(((byte)(109)))));
            this.TriDecroissant.OnHoverTextColor = System.Drawing.Color.White;
            this.TriDecroissant.selected = false;
            this.TriDecroissant.Size = new System.Drawing.Size(208, 46);
            this.TriDecroissant.TabIndex = 2;
            this.TriDecroissant.Text = "Tri Croissant";
            this.TriDecroissant.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TriDecroissant.Textcolor = System.Drawing.Color.White;
            this.TriDecroissant.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // DataEtudiant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(225)))), ((int)(((byte)(231)))));
            this.ClientSize = new System.Drawing.Size(907, 549);
            this.Controls.Add(this.bunifuImageButton1);
            this.Controls.Add(this.AjouterEtudiant);
            this.Controls.Add(this.supprimerEtudiant);
            this.Controls.Add(this.ChargerData);
            this.Controls.Add(this.ModifierEtudiant);
            this.Controls.Add(this.TriCroissant);
            this.Controls.Add(this.TriDecroissant);
            this.Controls.Add(this.bunifuMaterialTextbox1);
            this.Controls.Add(this.panel1);
            this.Name = "DataEtudiant";
            this.Text = "DataEtudiant";
            this.Load += new System.EventHandler(this.DataEtudiant_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Panel panel1;
    private Bunifu.Framework.UI.BunifuCustomDataGrid bunifuCustomDataGrid1;
    private System.Windows.Forms.DataGridViewTextBoxColumn CNE;
    private System.Windows.Forms.DataGridViewTextBoxColumn Nom;
    private System.Windows.Forms.DataGridViewTextBoxColumn Prenom;
    private System.Windows.Forms.DataGridViewTextBoxColumn Sexe;
    private System.Windows.Forms.DataGridViewTextBoxColumn DOB;
    private System.Windows.Forms.DataGridViewTextBoxColumn Adresse;
    private System.Windows.Forms.DataGridViewTextBoxColumn Tele;
    private System.Windows.Forms.DataGridViewTextBoxColumn Filiere;
    private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
    private Bunifu.Framework.UI.BunifuMaterialTextbox bunifuMaterialTextbox1;
    private Bunifu.Framework.UI.BunifuFlatButton TriDecroissant;
    private Bunifu.Framework.UI.BunifuFlatButton TriCroissant;
    private Bunifu.Framework.UI.BunifuFlatButton ModifierEtudiant;
    private Bunifu.Framework.UI.BunifuFlatButton supprimerEtudiant;
    private Bunifu.Framework.UI.BunifuFlatButton ChargerData;
        private Bunifu.Framework.UI.BunifuFlatButton AjouterEtudiant;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
    }
}