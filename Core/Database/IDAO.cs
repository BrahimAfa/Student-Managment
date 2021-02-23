namespace Core.Database
{
  using System.Collections.Generic;
  using System.Data;

  public interface IDAO<T>
  {
    bool insert(T data);

    bool update(T data);

    bool delete(object id);

    DataTable get(object id); // filter

    DataTable getAll();

    bool insertMany(List<T> data);
  }
}
