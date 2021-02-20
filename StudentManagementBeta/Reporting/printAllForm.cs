using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagementBeta.Reporting
{
    public partial class printAllForm : Form
    {
        public printAllForm()
        {
            InitializeComponent();
        }

        private void printAllForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'filiere.etud_fil' table. You can move, or remove it, as needed.
            this.etud_filTableAdapter.Fill(this.filiere.etud_fil);

            this.reportViewer1.RefreshReport();
        }
    }
}
