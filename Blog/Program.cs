using Blog.Models;
using Dapper.Contrib.Extensions;
using Microsoft.Data.SqlClient;

const string connectionString = "Server=localhost,1433;Database=Blog;User ID=sa;Password=110620#Db;Trusted_Connection=False; TrustServerCertificate=True;";

static void ReadUsers()
{
  using (var connection = new SqlConnection(connectionString))
  {
    var users = connection.GetAll<User>();

    foreach (var user in users)
    {
      Console.WriteLine(user.Name);
    }
  }
}

static void ReadUser()
{
  using (var connection = new SqlConnection(connectionString))
  {
    var user = connection.Get<User>(1);
    Console.WriteLine(user.Name);

  }
}

static void CreateUser()
{

  var user = new User()
  {
    Bio = "dev",
    Email = "teste@teste",
    Image = "https://...",
    Name = "John Doe",
    Password = "1234",
    Slug = "dev-c#"
  };

  using (var connection = new SqlConnection(connectionString))
  {
    connection.Insert<User>(user);
    Console.WriteLine("Cadastro  realizado com sucesso");

  }
}

static void UpdateUser()
{

  var user = new User()
  {
    Id = 2,
    Bio = "dev|suporte",
    Email = "teste@teste",
    Image = "https://...",
    Name = "John Doe ",
    Password = "*****",
    Slug = "dev-c#"
  };

  using (var connection = new SqlConnection(connectionString))
  {
    connection.Update<User>(user);
    Console.WriteLine("Atualização realizado com sucesso");

  }
}

static void DeleteUser()
{

  using (var connection = new SqlConnection(connectionString))
  {
    var user = connection.Get<User>(2);
    connection.Delete<User>(user);
    Console.WriteLine("Exclusão realizado com sucesso");

  }
}
// CreateUser();
// ReadUser();
// UpdateUser();
DeleteUser();
ReadUsers();