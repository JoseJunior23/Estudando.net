using Blog.Models;
using Blog.Repositories;
using Dapper.Contrib.Extensions;
using Microsoft.Data.SqlClient;

const string connectionString = "Server=localhost,1433;Database=Blog;User ID=sa;Password=110620#Db;Trusted_Connection=False; TrustServerCertificate=True;";
using (var connection = new SqlConnection(connectionString))
{
  ReadUsers(connection);
  // ReadRoles(connection);
  ReadTag(connection);
};



static void ReadUsers(SqlConnection connection)
{
  var repository = new UserRepository(connection);
  var items = repository.GetWithRoles();

  foreach (var item in items)
  {
    Console.WriteLine(item.Name);
    foreach (var role in item.Roles)
    {
      Console.WriteLine($" - {role.Name}");
    }
  }
}

static void ReadRoles(SqlConnection connection)
{
  var repository = new Repository<Role>(connection);
  var roles = repository.GetAll();
  foreach (var role in roles)
    Console.WriteLine(role.Name);
}

static void ReadTag(SqlConnection connection)
{
  var repository = new Repository<Role>(connection);
  var Items = repository.GetAll();
  foreach (var item in Items)
    Console.WriteLine(item.Name);
}