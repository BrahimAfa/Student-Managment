using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Core.Database;
using StudentManagementBeta.Services;

namespace StudentManagementBeta.Filiere
{
  public partial class FiliereForm : Form
  {
    public FiliereForm()
    {
      InitializeComponent();
    }
        FiliereService fil = new FiliereService();
       
        private void FormFiliere_Load(object sender, EventArgs e)
        {
            this.dgvFiliere.DataSource =fil.getAll();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            int position = this.dgvFiliere.CurrentRow.Index;
            int id = int.Parse(this.dgvFiliere.Rows[position].Cells[0].Value.ToString());
            fil.delete(id);
            this.dgvFiliere.Rows.RemoveAt(position);
            MessageBox.Show("La ligne a été supprimé .");
            
            
        }

        private void btnAjouterFiliere_Click(object sender, EventArgs e)
        {
            string nom = this.textBoxNomFiliere.Text;
            fil.insert(nom);
           // this.dgvFiliere.Rows.Add()
        }
    }
}
