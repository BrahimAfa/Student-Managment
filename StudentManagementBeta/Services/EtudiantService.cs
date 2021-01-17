namespace StudentManagementBeta.Services
{
  using Core.Database;
  using StudentManagementBeta.Etudiant;
  using System;
  using System.Collections.Generic;
  using System.Data;
  using System.Data.SqlClient;

  internal class EtudiantService : IDAO<EtudiantModel>
  {
    public EtudiantService()
    {
    }

    public void delete(object id)
    {
      Connection.open();
      string requete = "DELETE FROM Etudiant WHERE ID_Etudiant = @id ";
      SqlCommand cmd = new SqlCommand(requete, Connection.sqlConnection);
      cmd.Parameters.AddWithValue("@id", id);
      int a = cmd.ExecuteNonQuery();
      Connection.close();
    }

    public DataTable get(object id)
    {
      SqlCommand cmd = new SqlCommand("SELECT e.*,f.FiliereName from Etudiant e,Filiere f where e.ID_Filiere=f.ID_Filiere and e.CNE=@cne", Connection.sqlConnection);
      cmd.Parameters.AddWithValue("@cne", id);

      Connection.open();
      DataTable dt = new DataTable("Etud");
      SqlDataReader rd = cmd.ExecuteReader();
      if (rd.HasRows == true)
      {
        dt.Load(rd);
        return dt;
      }
      rd.Close();
      return notFoundDT();
    }

    public DataTable getAll()
    {
      SqlCommand cmd = new SqlCommand("SELECT e.*,f.FiliereName from Etudiant e,Filiere f where e.ID_Filiere=f.ID_Filiere;", Connection.sqlConnection);
      Connection.open();
      DataTable dt = new DataTable("Etud");
      SqlDataReader rd = cmd.ExecuteReader();
      if (rd.HasRows == true)
      {
        dt.Load(rd);
        return dt;
      }
      rd.Close();
      return notFoundDT();
    }

    public int insert(EtudiantModel data)
    {
      Connection.open();
      string requete = "INSERT INTO Etudiant (CNE,FirstName,LastName,gender,DOB,adresse,tele,ID_filiere) Values(@CNE,@prenomEtudiant,@nomEtudiant,@sexeEtudiant,@DOBEtudiant,@adresseEtudiant,@teleEtudiant,@filiere) ";
      SqlCommand cmd = new SqlCommand(requete, Connection.sqlConnection)
      {
        CommandText = requete
      };
      cmd.Parameters.AddWithValue("@id", data.id);
      cmd.Parameters.AddWithValue("@CNE", data.CNE);
      cmd.Parameters.AddWithValue("@prenomEtudiant", data.prenomEtudiant);
      cmd.Parameters.AddWithValue("@nomEtudiant", data.nomEtudiant);
      cmd.Parameters.AddWithValue("@sexeEtudiant", data.sexeEtudiant);
      cmd.Parameters.AddWithValue("@DOBEtudiant", data.DOBEtudiant);
      cmd.Parameters.AddWithValue("@adresseEtudiant", data.adresseEtudiant);
      cmd.Parameters.AddWithValue("@teleEtudiant", data.teleEtudiant);
      cmd.Parameters.AddWithValue("@filiere", data.id_filiere);
      int a = cmd.ExecuteNonQuery();
      Connection.close();
      return a;
    }

    public bool insertMany(List<EtudiantModel> data)
    {
      throw new NotImplementedException();
    }

    public bool update(EtudiantModel data)
    {
      throw new NotImplementedException();
    }

    internal DataTable notFoundDT()
    {
      DataTable dt = new DataTable();
      dt.Columns.Add(new DataColumn("ETUDIAN"));
      DataRow dr = dt.NewRow();
      dr[0] = "NOT FOUND";
      dt.Rows.Add(dr);
      return dt;
    }
  }
}
