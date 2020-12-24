using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Database;
using System.Data.SqlClient;
using System.Data;
using StudentManagementBeta.Filiere;
namespace StudentManagementBeta.Services
{
    class FiliereService : IDAO<Object>
    {
        public bool delete(int id)
        {
            bool aide = true;
            string query = "DELETE * FROM Filiere WHERE Id_Filiere=@id";
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
            catch(SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }


            return aide;
            
        }

        public object get(int id)
        {
            return null;
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
            bool aide=true;
            string query = "INSERT INTO Filiere(FiliereName) VALUES (@data);";
            SqlConnection conn = Connection.sqlConnection;
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@data",data);
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
