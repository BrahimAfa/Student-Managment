
namespace StudentManagementBeta.Reporting
{
    partial class printAllForm
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.filiere = new StudentManagementBeta.filiere();
            this.etudfilBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.etud_filTableAdapter = new StudentManagementBeta.filiereTableAdapters.etud_filTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.filiere)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.etudfilBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet3";
            reportDataSource1.Value = this.etudfilBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "StudentManagementBeta.Reporting.REPORTALL.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // filiere
            // 
            this.filiere.DataSetName = "filiere";
            this.filiere.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // etudfilBindingSource
            // 
            this.etudfilBindingSource.DataMember = "etud_fil";
            this.etudfilBindingSource.DataSource = this.filiere;
            // 
            // etud_filTableAdapter
            // 
            this.etud_filTableAdapter.ClearBeforeFill = true;
            // 
            // printAllForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "printAllForm";
            this.Text = "printAllForm";
            this.Load += new System.EventHandler(this.printAllForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.filiere)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.etudfilBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private filiere filiere;
        private System.Windows.Forms.BindingSource etudfilBindingSource;
        private filiereTableAdapters.etud_filTableAdapter etud_filTableAdapter;
    }
}