using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Database;
using StudentManagementBeta.Etudiant;
using System.Data.SqlClient;
namespace StudentManagementBeta.Services
{
  class EtudiantService : IDAO<EtudiantModel>
  {
    // public SqlCommand sqlcommand { get; set; }
    public EtudiantService()
    {
    }
    public bool delete(int id)
    {
      // SqlCommand sqlcommand = new SqlCommand("query",Connection.sqlConnection)
      throw new NotImplementedException();
    }

    public EtudiantModel get(int id)
    {
      throw new NotImplementedException();
    }

    public List<EtudiantModel> getAll()
    {
      throw new NotImplementedException();
    }

    public bool insert(EtudiantModel data)
    {
      throw new NotImplementedException();
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
