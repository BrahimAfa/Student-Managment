namespace StudentManagementBeta.Services
{
  using Core.Database;
  using System;
  using System.Collections.Generic;
  using System.Data;
  using System.Data.SqlClient;

  internal class FiliereService : IDAO<object>
  {
    public bool delete(object id)
    {
      bool aide = true;
      string query = "DELETE FROM Filiere WHERE Id_Filiere=@id";
      SqlConnection conn = Connection.sqlConnection;
      SqlCommand cmd = new SqlCommand(query, conn);
      cmd.Parameters.AddWithValue("@id", id);
      DataTable dt = new DataTable("fil");
      Connection.open();

      try
      {

        cmd.ExecuteNonQuery();
        aide = true;

      }
      catch (SqlException ex)
      {
        Console.WriteLine(ex.Message);
      }


      return aide;
    }

    public DataTable get(object id)
    {
      return null;
    }

    public object get(int id)
    {
      throw new NotImplementedException();
    }

    public DataTable getAll()
    {
      string query = "SELECT * FROM Filiere";
      SqlConnection conn = Connection.sqlConnection;
      SqlCommand cmd = new SqlCommand(query, conn);
      DataTable dt = new DataTable("fil");
      Connection.open();
      SqlDataReader red = cmd.ExecuteReader();

      if (red.HasRows)
      {
        dt.Load(red);
        Connection.close();
        return dt;
      }
      else
      {
        return null;
      }
    }

    public bool insert(object data)
    {
      bool aide = false;
      string query = "INSERT INTO Filiere(FiliereName) VALUES (@data);";
      SqlConnection conn = Connection.sqlConnection;
      SqlCommand cmd = new SqlCommand(query, conn);
      cmd.Parameters.AddWithValue("@data", data);
      DataTable dt = new DataTable("fil");
      Connection.open();

      try
      {

        cmd.ExecuteNonQuery();
        aide = true;

      }
      catch (SqlException ex)
      {
        System.Windows.Forms.MessageBox.Show(ex.Message);
      }


      return aide;
    }

    public bool insertMany(List<object> data)
    {
      throw new NotImplementedException();
    }

    public bool update(object data)
    {
      throw new NotImplementedException();
    }
  }
}
