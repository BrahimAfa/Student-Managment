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

    private void DataEtudiant_Load(object sender, EventArgs e)
    {
            

    }

        private void AjouterEtudiant_Click(object sender, EventArgs e)
        {
            new EtudiantForm().ShowDialog();
        }

        private void ChargerData_Click(object sender, EventArgs e)
        {

            TableDataEtud.DataSource = etudaiantService.getAll();
        }

        private void TriDecroissant_Click(object sender, EventArgs e)
        {
            List<EtudiantModel> l = new List<EtudiantModel>();
            DataTable dt = etudaiantService.getAll();
            
            foreach (DataRow row1 in dt.Rows)
            {
                int id = Int32.Parse(row1[0].ToString());
                String cne = row1[1].ToString();
                String firstName = row1[2].ToString();
                String lastName = row1[3].ToString();
                String gender = row1[4].ToString();
                //DateTime dob = DateTime.Parse(row1[5].ToString());
                String adresse = row1[6].ToString();
                String tele = row1[7].ToString();
                String filiere = row1[8].ToString();
                //l.Add(new EtudiantModel(id,cne, firstName, lastName,gender,dob,adresse,tele, filiere));
            }
            l.Sort();
        }
        int position = -1;
        int idTable = -1;
        private void TableDataEtud_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
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
    }
}
