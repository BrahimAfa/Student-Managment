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
            this.dgvFiliere.DataSource = fil.getAll();

    }

    private void btnAjouterFiliere_Click(object sender, EventArgs e)
        {
            string nom = this.textBoxNomFiliere.Text;
            fil.insert(new Filiere(0,nom));
            this.dgvFiliere.DataSource = fil.getAll();
    }

    private void btnModifier_Click(object sender, EventArgs e)
    {
      string idFiliere = dgvFiliere.SelectedRows[0].Cells[0].Value.ToString();
      string nameFiliere = dgvFiliere.SelectedRows[0].Cells[1].Value.ToString();

      MessageBox.Show(nameFiliere);
      groupBox2.Text += nameFiliere;
      groupBox2.Visible = true;
    }

    private void dgvFiliere_CellEndEdit(object sender, DataGridViewCellEventArgs e)
    {
        int rowIdx = e.RowIndex;
        int colIdx = e.ColumnIndex;
        var dgv = (DataGridView)sender;
        var fillName = dgv.Rows[rowIdx].Cells[1].Value;
        var idFill = dgv.Rows[rowIdx].Cells[0].Value;
      if (!string.IsNullOrEmpty(fillName.ToString()))
        {
      MessageBox.Show("Test1 " + fillName);

        fil.update(new Filiere(int.Parse(idFill.ToString()), fillName.ToString()));
      };
  
    }

    private void dgvFiliere_CurrentCellChanged(object sender, EventArgs e)
    {
  
    }

    private void bunifuFlatButton1_Click(object sender, EventArgs e)
    {

    }
  }
}
