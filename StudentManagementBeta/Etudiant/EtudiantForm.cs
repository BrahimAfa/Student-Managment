namespace StudentManagementBeta.Etudiant
{
  using Core.Database;
  using System;
  using System.Data.SqlClient;
  using System.Windows.Forms;

  public partial class EtudiantForm : Form
  {
    internal Services.EtudiantService etudaiantService = new Services.EtudiantService();
    internal Services.FiliereService filiereService = new Services.FiliereService();

    public delegate void GridRefrecher(EtudiantModel etd);

    public event GridRefrecher refreshGridRegister;
    private bool isUpdate { get; set; }
    private EtudiantModel updateEtud { get; set; }

    public EtudiantForm(bool isUpdate=false,EtudiantModel updateEtud=null)
    {
      InitializeComponent();
      fillFiliereCombo();
      this.isUpdate = isUpdate;
      this.updateEtud = updateEtud;
      if (isUpdate)
      {
        if (updateEtud == null)
        {
          throw new Exception("Etudiant is required in case of an update");
        }
        labelFiliere.Text = "Modifier Etudiant";
        fillInputsWithUpdateEtude(updateEtud);
        this.AjouterEtudiant.Text = "Modifier";
        this.Text = "Modifier Etudiant";
      }
    }

    private void fillInputsWithUpdateEtude(EtudiantModel updateEtud)
    {
        inputCNEEtudiant.Text = updateEtud.CNE;
        inputNomEtudiant.Text = updateEtud.nomEtudiant;
        inputPrenomEtudiant.Text = updateEtud.prenomEtudiant;
        selectSexe(updateEtud.sexeEtudiant);
        bunifuDatepicker1.Value = Convert.ToDateTime(updateEtud.DOBEtudiant);
        inputAdresseEtudiant.Text = updateEtud.adresseEtudiant;
        inputTeleEtudiant.Text = updateEtud.teleEtudiant;
      comboBox12.SelectedValue = updateEtud.id_filiere;
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
      EtudiantModel etudiant = getEtudiantFromInputs();
      refreshGridRegister(etudiant);
    }

    private bool checkInfo(string CNE, string nom, string prenom, string sexe, string date, string adresse, string tele, int id_filiere)
    {
      if (CNE.Equals(string.Empty) && prenom.Equals(string.Empty) && nom.Equals(string.Empty) && sexe.Equals(string.Empty) && date.Equals(string.Empty) && adresse.Equals(string.Empty) && tele.Equals(string.Empty) && id_filiere.Equals(string.Empty))
      {
        return false;
      }
      return true;
    }

    private string CheckedSexe()
    {
      if (Femme.Checked)
      {
        return "F";
      }
      else
      {
        return "H";
      }
    }
    private void selectSexe(string sexe)
    {
      Femme.Checked = sexe == "F";
      Homme.Checked = !Femme.Checked;
    }

    private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
    {
    }
    void fillFiliereCombo()
    {
      comboBox12.DataSource = filiereService.getAll();
      comboBox12.ValueMember = "ID_Filiere";
      comboBox12.DisplayMember = "FiliereName";
    }
    EtudiantModel getEtudiantFromInputs()
    {
      string CNE = inputCNEEtudiant.Text;
      string nom = inputNomEtudiant.Text;
      string prenom = inputPrenomEtudiant.Text;
      string sexe = CheckedSexe();
      string date = bunifuDatepicker1.Text;
      string adresse = inputAdresseEtudiant.Text;
      string tele = inputTeleEtudiant.Text;
      int id_filiere = int.Parse(comboBox12.SelectedValue.ToString());
      if (this.updateEtud != null) return new EtudiantModel(this.updateEtud.id,CNE, nom, prenom, sexe, date, adresse, tele, id_filiere);
      return new EtudiantModel(CNE, nom, prenom, sexe, date, adresse, tele, id_filiere);
    }

    private void bunifuImageButton1_Click(object sender, EventArgs e)
    {
      this.Close();
    }
  }
}
