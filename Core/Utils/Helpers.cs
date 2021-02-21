using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace Core.Utils
{
  public class Helpers
  {
    public static void showErrorMessage(String Message)
    {
      MessageBox.Show(Message,"Error Accured!",MessageBoxButtons.OK,MessageBoxIcon.Error);
    }

    public static void showSuccessMessage(String Message)
    {
      MessageBox.Show(Message, "Valid Operation", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }
  }
}
