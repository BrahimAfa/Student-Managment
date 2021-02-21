
namespace StudentManagementBeta.Reporting
{
    partial class ReportingForm
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
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelFiliere = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAfficher = new Bunifu.Framework.UI.BunifuFlatButton();
            this.textBoxCNE = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonAllStudent = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
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
            this.panel1.Location = new System.Drawing.Point(-4, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(615, 37);
            this.panel1.TabIndex = 1;
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
            this.labelFiliere.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelFiliere.Location = new System.Drawing.Point(21, 3);
            this.labelFiliere.Name = "labelFiliere";
            this.labelFiliere.Size = new System.Drawing.Size(113, 30);
            this.labelFiliere.TabIndex = 0;
            this.labelFiliere.Text = "Reporting";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(88)))), ((int)(((byte)(122)))));
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Location = new System.Drawing.Point(-1, 36);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(612, 322);
            this.panel2.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAfficher);
            this.groupBox1.Controls.Add(this.textBoxCNE);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Sitka Small", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Lavender;
            this.groupBox1.Location = new System.Drawing.Point(33, 197);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(548, 114);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Afficher un étudiant";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnAfficher
            // 
            this.btnAfficher.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(145)))));
            this.btnAfficher.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(145)))));
            this.btnAfficher.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAfficher.BorderRadius = 6;
            this.btnAfficher.ButtonText = "Afficher";
            this.btnAfficher.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAfficher.DisabledColor = System.Drawing.Color.Gray;
            this.btnAfficher.Font = new System.Drawing.Font("Symbol", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.btnAfficher.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAfficher.Iconimage = null;
            this.btnAfficher.Iconimage_right = null;
            this.btnAfficher.Iconimage_right_Selected = null;
            this.btnAfficher.Iconimage_Selected = null;
            this.btnAfficher.IconMarginLeft = 0;
            this.btnAfficher.IconMarginRight = 0;
            this.btnAfficher.IconRightVisible = true;
            this.btnAfficher.IconRightZoom = 0D;
            this.btnAfficher.IconVisible = true;
            this.btnAfficher.IconZoom = 90D;
            this.btnAfficher.IsTab = false;
            this.btnAfficher.Location = new System.Drawing.Point(402, 44);
            this.btnAfficher.Margin = new System.Windows.Forms.Padding(6);
            this.btnAfficher.Name = "btnAfficher";
            this.btnAfficher.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(145)))));
            this.btnAfficher.OnHovercolor = System.Drawing.Color.Teal;
            this.btnAfficher.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAfficher.selected = true;
            this.btnAfficher.Size = new System.Drawing.Size(115, 38);
            this.btnAfficher.TabIndex = 1;
            this.btnAfficher.Text = "Afficher";
            this.btnAfficher.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAfficher.Textcolor = System.Drawing.Color.White;
            this.btnAfficher.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAfficher.Click += new System.EventHandler(this.btnAfficher_Click);
            // 
            // textBoxCNE
            // 
            this.textBoxCNE.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBoxCNE.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.textBoxCNE.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCNE.Location = new System.Drawing.Point(145, 56);
            this.textBoxCNE.Name = "textBoxCNE";
            this.textBoxCNE.Size = new System.Drawing.Size(127, 26);
            this.textBoxCNE.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Saisir un CNE:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonAllStudent);
            this.groupBox2.Font = new System.Drawing.Font("Sitka Small", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Lavender;
            this.groupBox2.Location = new System.Drawing.Point(33, 49);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(548, 114);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Afficher Tous les Etudiants";
            // 
            // buttonAllStudent
            // 
            this.buttonAllStudent.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(145)))));
            this.buttonAllStudent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(145)))));
            this.buttonAllStudent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonAllStudent.BorderRadius = 6;
            this.buttonAllStudent.ButtonText = "Afficher";
            this.buttonAllStudent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAllStudent.DisabledColor = System.Drawing.Color.Gray;
            this.buttonAllStudent.Font = new System.Drawing.Font("Symbol", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.buttonAllStudent.Iconcolor = System.Drawing.Color.Transparent;
            this.buttonAllStudent.Iconimage = null;
            this.buttonAllStudent.Iconimage_right = null;
            this.buttonAllStudent.Iconimage_right_Selected = null;
            this.buttonAllStudent.Iconimage_Selected = null;
            this.buttonAllStudent.IconMarginLeft = 0;
            this.buttonAllStudent.IconMarginRight = 0;
            this.buttonAllStudent.IconRightVisible = true;
            this.buttonAllStudent.IconRightZoom = 0D;
            this.buttonAllStudent.IconVisible = true;
            this.buttonAllStudent.IconZoom = 90D;
            this.buttonAllStudent.IsTab = false;
            this.buttonAllStudent.Location = new System.Drawing.Point(201, 42);
            this.buttonAllStudent.Margin = new System.Windows.Forms.Padding(6);
            this.buttonAllStudent.Name = "buttonAllStudent";
            this.buttonAllStudent.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(145)))));
            this.buttonAllStudent.OnHovercolor = System.Drawing.Color.Teal;
            this.buttonAllStudent.OnHoverTextColor = System.Drawing.Color.White;
            this.buttonAllStudent.selected = true;
            this.buttonAllStudent.Size = new System.Drawing.Size(115, 38);
            this.buttonAllStudent.TabIndex = 3;
            this.buttonAllStudent.Text = "Afficher";
            this.buttonAllStudent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.buttonAllStudent.Textcolor = System.Drawing.Color.White;
            this.buttonAllStudent.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAllStudent.Click += new System.EventHandler(this.buttonAllStudent_Click);
            // 
            // Reporting_Etudiant_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 359);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Reporting_Etudiant_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Reporting_Etudiant_Form";
            this.Load += new System.EventHandler(this.Reporting_Etudiant_Form_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuCustomLabel labelFiliere;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private Bunifu.Framework.UI.BunifuFlatButton btnAfficher;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox textBoxCNE;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private Bunifu.Framework.UI.BunifuFlatButton buttonAllStudent;
    }
}