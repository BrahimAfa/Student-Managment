using StudentManagementBeta.Etudiant;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagementBeta.Reporting
{
    public partial class Print__Etudiant_Form : Form
    {
        EtudiantModel _etudiant;
        string _filiereName;

        public Print__Etudiant_Form(EtudiantModel etudiant,string filiereName)
        {
            InitializeComponent();
            _etudiant = etudiant;
            _filiereName = filiereName;
        }

        private void Print__Etudiant_Form_Load(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.UtcNow.Date;
            
            Microsoft.Reporting.WinForms.ReportParameter[] p = new Microsoft.Reporting.WinForms.ReportParameter[]
            {
                new Microsoft.Reporting.WinForms.ReportParameter("CNE",_etudiant.CNE),
                new Microsoft.Reporting.WinForms.ReportParameter("LastName",_etudiant.nomEtudiant),
                new Microsoft.Reporting.WinForms.ReportParameter("FirstName",_etudiant.prenomEtudiant),
                new Microsoft.Reporting.WinForms.ReportParameter("DOB",_etudiant.DOBEtudiant),
                new Microsoft.Reporting.WinForms.ReportParameter("adresse",_etudiant.adresseEtudiant),
                new Microsoft.Reporting.WinForms.ReportParameter("tele",_etudiant.teleEtudiant),
                new Microsoft.Reporting.WinForms.ReportParameter("Filiere",_filiereName),
                new Microsoft.Reporting.WinForms.ReportParameter("DateActuel",dateTime.ToString("dd/MM/yyyy"))
            };
            this.reportViewer.LocalReport.SetParameters(p);

            this.reportViewer.RefreshReport();
        }

       
    }
}
