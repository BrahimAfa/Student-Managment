using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Database;
using StudentManagementBeta.Etudiant;
using System.Data.SqlClient;
using System.Data;

namespace StudentManagementBeta.Services
{
      class EtudiantService : IDAO<EtudiantModel>
      {
            public EtudiantService()
            {
            }
            public void delete(int id)
            {
                    Connection.open();
                    string requete = "DELETE FROM Etudiant WHERE ID_Etudiant = @id ";
                    SqlCommand cmd = new SqlCommand(requete, Connection.sqlConnection);
                    cmd.Parameters.AddWithValue("@id", id);
                    int a = cmd.ExecuteNonQuery();
                    Connection.close();
            }
            public EtudiantModel get(int id)
            {
              throw new NotImplementedException();
            }
            public DataTable getAll()
            {
                    SqlCommand cmd = new SqlCommand("SELECT e.CNE,e.FirstName,e.LastName,e.gender,e.DOB,e.adresse,e.tele,f.FiliereName from Etudiant e,Filiere f where e.ID_Filiere=f.ID_Filiere;", Connection.sqlConnection);
                    Connection.open();
                    DataTable dt = new DataTable("Etud");
                    SqlDataReader rd = cmd.ExecuteReader();
                    if (rd.HasRows == true)
                    {
                        dt.Load(rd);
                        return dt;
                    }
                    return null;
            }
            public int insert(EtudiantModel data)
            {
                    Connection.open();
                    String requete = "INSERT INTO Etudiant (CNE,FirstName,LastName,gender,DOB,adresse,tele,ID_filiere) Values(@CNE,@prenomEtudiant,@nomEtudiant,@sexeEtudiant,@DOBEtudiant,@adresseEtudiant,@teleEtudiant,@filiere) ";
                    SqlCommand cmd = new SqlCommand(requete, Connection.sqlConnection);
                    cmd.CommandText = requete;
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
      }
}
