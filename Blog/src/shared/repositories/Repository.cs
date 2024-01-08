using Dapper.Contrib.Extensions;
using Microsoft.Data.SqlClient;

namespace Blog.src.shared.repositories
{
  public class Repository<T> where T : class
  {
    public Repository(SqlConnection connection)
    => Database.connection = connection;

    public IEnumerable<T> GetAll()
      => Database.connection.GetAll<T>();


    public T Get(int id)
      => Database.connection.Get<T>(id);

    public void Create(T model)
      => Database.connection.Insert<T>(model);

    public void Update(T model)
        => Database.connection.Update<T>(model);

    public void Delete(int id)
    {
      var model = Database.connection.Get<T>(id);
      Database.connection.Delete<T>(model);
    }
  }
}