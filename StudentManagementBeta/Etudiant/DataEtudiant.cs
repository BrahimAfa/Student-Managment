namespace StudentManagementBeta.Etudiant
{
  using System;
  using System.Windows.Forms;
  using System.Data;
  public partial class DataEtudiant : Form
  {
    internal Services.EtudiantService etudaiantService = new Services.EtudiantService();

    public DataEtudiant()
    {
      InitializeComponent();
    }

    private void DataEtudiant_Load(object sender, EventArgs e)
    {
      TableDataEtud.DataSource = etudaiantService.getAll();
    }

    private void AjouterEtudiant_Click(object sender, EventArgs e)
    {
      EtudiantForm etdFrm = new EtudiantForm();
      etdFrm.refreshGridRegister += new EtudiantForm.GridRefrecher(ajouterEtudiant);
      etdFrm.ShowDialog();
    }

    private void ChargerData_Click(object sender, EventArgs e)
    {
      TableDataEtud.DataSource = etudaiantService.getAll();
    }

    private void TriDecroissant_Click(object sender, EventArgs e)
    {
      TableDataEtud.DataSource = sortbyFirstName("desc");
    }
    private void TriCroissant_Click(object sender, EventArgs e)
    {
      TableDataEtud.DataSource = sortbyFirstName("asc");
    }

    internal int position = -1;

    internal int idTable = -1;

    private void TableDataEtud_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {
      position = TableDataEtud.CurrentRow.Index;
      idTable = int.Parse(TableDataEtud.Rows[position].Cells[0].Value.ToString());
    }

    private void supprimerEtudiant_Click(object sender, EventArgs e)
    {
      if (position == -1)
      {
        MessageBox.Show("veuillez SVP selectionner une ligne !!");
        return;
      }
      etudaiantService.delete(idTable);
      TableDataEtud.Rows.RemoveAt(position);
      MessageBox.Show("bien suprimé");
    }

    private void bunifuImageButton1_Click(object sender, EventArgs e)
    {
      TableDataEtud.DataSource = etudaiantService.get(search.Text);
    }

    public void ajouterEtudiant(EtudiantModel etudiant)
    {
      try
      {
        int x = etudaiantService.insert(etudiant);
        MessageBox.Show(x + "est ligne ajoutée");
        TableDataEtud.DataSource = etudaiantService.getAll();

      }
      catch (Exception ex)
      {
        MessageBox.Show($"ERROR :: {ex.Message}");
      }
    }
    DataTable sortbyFirstName(string sortcondition)
    {
      DataTable dt = (DataTable)TableDataEtud.DataSource;
      if (dt == null) return null;
      DataView dv = dt.DefaultView;
      dv.Sort = $"FirstName {sortcondition}";
      return dv.ToTable();
    }

 
  }
}
