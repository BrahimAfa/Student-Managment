using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementBeta.Filiere
{
  public class Filiere
  {
    private int id;

    public int Id
    {
      get { return id; }
      set { id = value; }
    }
    private string fillName;

    public string FilierName
    {
      get { return fillName; }
      set { fillName = value; }
    }
    public Filiere(int id, string fillname)
    {
      Id = id;
      FilierName = fillname;
    }



  }
}
