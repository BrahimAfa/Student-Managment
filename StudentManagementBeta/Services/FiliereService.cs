namespace StudentManagementBeta.Services
{
  using Core.Database;
  using System;
  using System.Collections.Generic;
  using System.Data;
  using System.Data.SqlClient;

  internal class FiliereService : IDAO<Filiere.Filiere>
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

    public bool insert(Filiere.Filiere data)
    {
      bool aide = false;
      string query = "INSERT INTO Filiere(FiliereName) VALUES (@data);";
      SqlConnection conn = Connection.sqlConnection;
      SqlCommand cmd = new SqlCommand(query, conn);
      cmd.Parameters.AddWithValue("@data", data.FilierName);
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

    public bool insertMany(List<Filiere.Filiere> data)
    {
      throw new NotImplementedException();
    }

    public bool update(Filiere.Filiere data)
    {
      bool aide = false;
      string query = "UPDATE Filiere SET FiliereName = @name where Id_Filiere=@id";
      SqlConnection conn = Connection.sqlConnection;
      SqlCommand cmd = new SqlCommand(query, conn);
      cmd.Parameters.AddWithValue("@id", data.Id);
      cmd.Parameters.AddWithValue("@name", data.FilierName);
      try {
        Connection.open();
        cmd.ExecuteNonQuery();
        aide = true;
      } catch (SqlException ex) {
        System.Windows.Forms.MessageBox.Show(ex.Message);
      }
      finally
      {
        Connection.close();
      }
      return aide;
    }

    public string getFiliereName(int id)
    {
            SqlCommand cmd = new SqlCommand("SELECT *  FROM Filiere where ID_Filiere=@id", Connection.sqlConnection);
            cmd.Parameters.AddWithValue("@id", id);
            Connection.open();
            SqlDataReader dr = cmd.ExecuteReader();
            dr.Read();
            if (!dr.HasRows) return null;
            string fiereName=  dr[1].ToString();
            Connection.close();
            return fiereName;
        }
  }
}
