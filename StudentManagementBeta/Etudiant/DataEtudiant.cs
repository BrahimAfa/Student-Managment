using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Core.Database;
namespace StudentManagementBeta.Etudiant
{
        public partial class DataEtudiant : Form
        {
            Services.EtudiantService etudaiantService = new Services.EtudiantService();
            public DataEtudiant()
            {
                InitializeComponent();
            }
        private void DataEtudiant_Load(object sender, EventArgs e){}
        private void AjouterEtudiant_Click(object sender, EventArgs e){new EtudiantForm().ShowDialog();}
        private void ChargerData_Click(object sender, EventArgs e){TableDataEtud.DataSource = etudaiantService.getAll();}
        private void TriDecroissant_Click(object sender, EventArgs e){}
        int position = -1;
        int idTable = -1;
        private void TableDataEtud_CellContentClick(object sender, DataGridViewCellEventArgs e){
            position = this.TableDataEtud.CurrentRow.Index;
            idTable = int.Parse(this.TableDataEtud.Rows[position].Cells[0].Value.ToString());
        }
        private void supprimerEtudiant_Click(object sender, EventArgs e)
        {
            if(position == -1)
            {
                MessageBox.Show("veuillez SVP selectionner une ligne !!");
                return;
            }
            etudaiantService.delete(idTable);
            this.TableDataEtud.Rows.RemoveAt(position);
            MessageBox.Show("bien suprimé");
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Connection.open();
            String search = "select * from Etudiant where CNE =@CNE";
            SqlCommand cmd = new SqlCommand(search, Connection.sqlConnection);
            cmd.Parameters.AddWithValue("@CNE", this.search.Text);
            SqlDataReader dt = cmd.ExecuteReader();
            if (dt.HasRows)
            {
                dt.Read();
                MessageBox.Show(" Id_Etudiant : " + dt[0] + " \n " + "CNE  : " + dt[1] + " \n " + "Nom  : " + dt[2] + " \n " + "prenom  : " + dt[3] + " \n " + "sexe  : " + dt[4] + " \n " + "date de naissance  : " + dt[5] + " \n " + "adresse  : " + dt[6] + " \n " + "tele  : " + dt[7]);
            }
            else
            {
                MessageBox.Show("CNE n'existe pas");
            }
            Connection.close();
           
        }
    }
}
