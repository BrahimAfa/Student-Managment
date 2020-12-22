using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagementBeta.Etudiant
{
  public partial class EtudiantForm : Form
  {
    public EtudiantForm()
    {
      InitializeComponent();
    }

    private void Form_Etudiant_Load(object sender, EventArgs e)
    {

    }

    private void button1_Click(object sender, EventArgs e)
    {
      new DataEtudiant().Show();
    }
  }
}
