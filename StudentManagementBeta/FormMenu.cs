using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StudentManagementBeta.Etudiant;
using StudentManagementBeta.Filiere;
using StudentManagementBeta.Reporting;
using StudentManagementBeta.Statistics;

namespace StudentManagementBeta
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

    private void panel2_Paint(object sender, PaintEventArgs e)
    {

    }

    private void bunifuImageButton1_Click(object sender, EventArgs e)
    {
      Application.Exit();
    }

    private void bunifuTileButton1_Click(object sender, EventArgs e)
    {
      new EtudiantForm().ShowDialog();
    }

    private void bunifuTileButton5_Click(object sender, EventArgs e)
    {
      new ImportForm().ShowDialog();
    }

    private void bunifuTileButton2_Click(object sender, EventArgs e)
    {
      new FiliereForm().ShowDialog();
    }

    private void bunifuTileButton3_Click(object sender, EventArgs e)
    {
      new StatisticsForm().ShowDialog();
    }

    private void bunifuTileButton4_Click(object sender, EventArgs e)
    {
      new ReportingForm().ShowDialog();
    }
  }
}
