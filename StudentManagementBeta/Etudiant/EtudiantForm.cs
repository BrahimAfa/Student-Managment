using Core.Database;
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

namespace StudentManagementBeta.Etudiant
{
  public partial class EtudiantForm : Form
  {
        Services.EtudiantService etudaiantService = new Services.EtudiantService();
        public EtudiantForm()
        {
            InitializeComponent();
            SqlCommand cmd = new SqlCommand("SELECT FiliereName from Filiere;", Connection.sqlConnection);
            Connection.open();
            SqlDataReader read = cmd.ExecuteReader();
            while (read.Read())
            {
                comboBox1.Items.Add(read.GetString(0));
            }
            Connection.close();
        }
        private void Form_Etudiant_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
                new DataEtudiant().Show();
        }

        private void AjouterEtudiant_Click(object sender, EventArgs e)
        {
            
            string CNE = inputCNEEtudiant.Text;
            string nom = inputNomEtudiant.Text;
            string prenom = inputPrenomEtudiant.Text;
            string sexe = CheckedSexe();
            string date = bunifuDatepicker1.Text;
            string adresse = inputAdresseEtudiant.Text;
            string tele = inputTeleEtudiant.Text;
            int id_filiere = comboBox();

            try
            {
                EtudiantModel etudiant = new EtudiantModel(CNE,nom,prenom,sexe,date,adresse,tele,id_filiere);
                int x = etudaiantService.insert(etudiant);
                MessageBox.Show(x + "est ligne ajoutée");
            }catch(Exception ex)
            {
                MessageBox.Show("ERROR");
            }
        }
        private bool checkInfo(string CNE, string nom, string prenom, string sexe, string date, string adresse, string tele, int id_filiere)
        {
            if (CNE.Equals(string.Empty) && prenom.Equals(string.Empty) && nom.Equals(string.Empty) && sexe.Equals(string.Empty) && date.Equals(string.Empty) && adresse.Equals(string.Empty) && tele.Equals(string.Empty) && id_filiere.Equals(string.Empty))
            {
                return false;
            }
             return true;
        }
        private String CheckedSexe()
        {
            if (Femme.Checked)
                return "F";
            else
                return "H";
        }
        
        private int comboBox()
        {
            string filiere = comboBox1.Text;
            SqlCommand comm = new SqlCommand("SELECT ID_Filiere from Filiere WHERE FiliereName = @filiere;", Connection.sqlConnection);
            comm.Parameters.AddWithValue("@filiere", filiere);
            Connection.open();
            SqlDataReader dr = comm.ExecuteReader();
            int x = -1;
            if (dr.Read())
            {
                x = (int)dr["ID_Filiere"];
            }
            Connection.close();
            return x;
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
