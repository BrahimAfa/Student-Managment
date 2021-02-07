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

namespace StudentManagementBeta.Statistics
{
  public partial class StatisticsForm : Form
  {
    public StatisticsForm()
    {
        InitializeComponent();

            Services.FiliereService filiereService = new Services.FiliereService();
            Services.EtudiantService etudiantService = new Services.EtudiantService();
            //sjsjs

            DataTable dataFiliere = filiereService.getAll();
            DataTable dataEtudiant = etudiantService.getAll();
            Dictionary<String, int> nbEtudiantFiliere = new Dictionary<String, int>();

            double nbTotalEtudiant = Convert.ToDouble(dataEtudiant.Rows.Count);

            for (int i = 0; i < dataFiliere.Rows.Count; i++)
            {
                nbEtudiantFiliere.Add(dataFiliere.Rows[i]["FiliereName"].ToString(), 0);
            }

            for (int i = 0; i < dataEtudiant.Rows.Count; i++)
            {
                int idFiliere = Convert.ToInt32(dataEtudiant.Rows[i]["ID_Filiere"]);
                String nomFiliere = dataFiliere.Rows[idFiliere - 1]["FiliereName"].ToString();
                nbEtudiantFiliere[nomFiliere] += 1;
            }

            int k = 0;
            foreach(KeyValuePair<string, int> kvp in nbEtudiantFiliere)
            {
                this.chart1.Series["NombreEtudiant"].Points.AddXY(kvp.Key, kvp.Value);
                this.chart1.Series["NombreEtudiant"].Points[k].Label = Math.Round((kvp.Value / nbTotalEtudiant)*100, 2) + "%";
                k++;
            }
           


        }

    private void FormStatistics_Load(object sender, EventArgs e)
    {

    }
  }
}
