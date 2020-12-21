using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Core.Database;
namespace Testing
{
  class Program
  {
    static void Main(string[] args)
    {
      var r = Connection.sqlConnection;
      Console.WriteLine(r.State);
      Console.WriteLine("opening....");
      Connection.open();
      Console.WriteLine(r.State);
      Console.ReadKey();
    }
  }
}
