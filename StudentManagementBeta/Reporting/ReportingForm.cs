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
    public partial class ReportingForm : Form
    {
        internal Services.EtudiantService etudaiantService = new Services.EtudiantService();
        internal Services.FiliereService fil = new Services.FiliereService();
        public ReportingForm()
        {
            InitializeComponent();
        }

        private void Reporting_Etudiant_Form_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAfficher_Click(object sender, EventArgs e)
        {
            string cne = this.textBoxCNE.Text;
            EtudiantModel etudiant = etudaiantService.getByCNE(cne);
            if (etudiant == null)
            {
                Core.Utils.Helpers.showErrorMessage("Etudiant non trouvé!!!");
            }
            else {
                string nomFillier = fil.getFiliereName(etudiant.id_filiere);

                using (Print__Etudiant_Form print = new Print__Etudiant_Form(etudiant, nomFillier))
                {
                    print.ShowDialog();
                }
            }


        }

        private void buttonAllStudent_Click(object sender, EventArgs e)
        {
            new printAllForm().ShowDialog();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
