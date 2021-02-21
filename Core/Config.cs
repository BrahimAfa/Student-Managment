using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Core
{
  public class Config {
    public static string getConnection()
    {
        SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
        builder.DataSource = "c-sharp-winform-project.database.windows.net";
        builder.UserID = "GI";
        builder.Password = "9NfAhSPc";
        builder.InitialCatalog = "GestionEtudiant";
        return builder.ConnectionString;
    }
    public static string CONNECTION_STRING = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=GestionEtudiant2;Integrated Security=True";
  }
}
