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
    int insert(T data);
    bool update(T data);
    void delete(int id);
    T get(int id);
    DataTable getAll();
    bool insertMany(List<T> data);
  }
}
