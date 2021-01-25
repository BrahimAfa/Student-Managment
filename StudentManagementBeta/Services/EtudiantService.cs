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

    public bool delete(object id)
    {
      Connection.open();
      string requete = "DELETE FROM Etudiant WHERE ID_Etudiant = @id ";
      SqlCommand cmd = new SqlCommand(requete, Connection.sqlConnection);
      cmd.Parameters.AddWithValue("@id", id);
      int a = cmd.ExecuteNonQuery();
      Connection.close();
      return a > 0;
    }

    public DataTable get(object id)
    {
      SqlCommand cmd = new SqlCommand("SELECT e.*,f.FiliereName from Etudiant e,Filiere f where e.ID_Filiere=f.ID_Filiere and e.CNE like @cne", Connection.sqlConnection);
      cmd.Parameters.AddWithValue("@cne", $"%{id}%");

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

    public EtudiantModel get(int id)
    {

      SqlCommand cmd = new SqlCommand("SELECT *  FROM Etudiant where ID_Etudiant=@id", Connection.sqlConnection);
      cmd.Parameters.AddWithValue("@id", id);
      Connection.open();
      SqlDataReader dr = cmd.ExecuteReader();
      dr.Read();
      if (!dr.HasRows) return null;
      int idEtud = int.Parse(dr[0].ToString());
      string CNE = dr[1].ToString();
      string nom = dr[2].ToString();
      string prenom = dr[3].ToString();
      string sexe = dr[4].ToString();
      string date = dr[5].ToString();
      string adresse = dr[6].ToString();
      string tele = dr[7].ToString();
      int id_filiere = int.Parse(dr[9].ToString());
      EtudiantModel etud  =  new EtudiantModel(idEtud,CNE, nom, prenom, sexe, date, adresse, tele, id_filiere);
      Connection.close();
      return etud;
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

    public bool insert(EtudiantModel data)
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
      return a>0;
    }

    public bool insertMany(List<EtudiantModel> data)
    {
      throw new NotImplementedException();
    }

    public bool update(EtudiantModel data)
    {
      string requete = "update Etudiant set CNE=@CNE,FirstName=@prenomEtudiant,LastName=@nomEtudiant,gender=@sexeEtudiant,DOB=@DOBEtudiant,adresse=@adresseEtudiant,tele=@teleEtudiant,ID_filiere=@filiere where ID_Etudiant=@id";
      SqlCommand cmd = new SqlCommand(requete, Connection.sqlConnection);
      cmd.Parameters.AddWithValue("@id", data.id);
      cmd.Parameters.AddWithValue("@CNE", data.CNE);
      cmd.Parameters.AddWithValue("@prenomEtudiant", data.prenomEtudiant);
      cmd.Parameters.AddWithValue("@nomEtudiant", data.nomEtudiant);
      cmd.Parameters.AddWithValue("@sexeEtudiant", data.sexeEtudiant);
      cmd.Parameters.AddWithValue("@DOBEtudiant", data.DOBEtudiant);
      cmd.Parameters.AddWithValue("@adresseEtudiant", data.adresseEtudiant);
      cmd.Parameters.AddWithValue("@teleEtudiant", data.teleEtudiant);
      cmd.Parameters.AddWithValue("@filiere", data.id_filiere);
      Connection.open();
      int a = cmd.ExecuteNonQuery();
      Connection.close();
      return a > 0;
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

     public EtudiantModel getByCNE(string cne)
      {

            SqlCommand cmd = new SqlCommand("SELECT *  FROM Etudiant where CNE=@cne", Connection.sqlConnection);
            cmd.Parameters.AddWithValue("@cne", cne);
            Connection.open();
            SqlDataReader dr = cmd.ExecuteReader();
            dr.Read();
            if (!dr.HasRows) return null;
            int idEtud = int.Parse(dr["ID_Etudiant"].ToString());
            string CNE = dr["CNE"].ToString();
            string nom = dr["LastName"].ToString();
            string prenom = dr["FirstName"].ToString();
            string sexe = dr["gender"].ToString();
            string date = String.Format("{0:d/M/yyyy }", dr["DOB"]);
            string adresse = dr["adresse"].ToString();
            string tele = dr["tele"].ToString();
            int id_filiere = int.Parse(dr["ID_Filiere"].ToString());
            EtudiantModel etud = new EtudiantModel(idEtud, CNE, nom, prenom, sexe, date, adresse, tele, id_filiere);
            Connection.close();
            return etud;
        }
    }
}
