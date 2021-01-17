using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Database
{
      public interface IDAO<T>
      {
            bool insert(T data);
            bool update(T data);
            bool delete(object id);
            DataTable get(object id);
            DataTable getAll();
            bool insertMany(List<T> data);
      }
}
