using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Database
{
  public interface IDAO<T>
  {
    bool insert(T data);
    bool update(T data);
    bool delete(int id);
    T get(int id);
    List<T> getAll();
    bool insertMany(List<T> data);
  }
}
