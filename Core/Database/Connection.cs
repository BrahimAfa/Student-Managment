using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Core.Database
{
  public class Connection
  {

    private Connection(){}
    private static SqlConnection sqlCon;

    public static SqlConnection sqlConnection
    {
      get {
        if (sqlCon is null) sqlCon =  new SqlConnection(Config.CONNECTION_STRING);
        return sqlCon;
      }
    }

    public static void open()
    {
      if(sqlConnection.State != System.Data.ConnectionState.Open)
      {
        sqlConnection.Open();
      }
    }

    public static void close()
    {
      if (sqlConnection.State != System.Data.ConnectionState.Closed)
      {
        sqlConnection.Close();
      }
    }

  }
}
