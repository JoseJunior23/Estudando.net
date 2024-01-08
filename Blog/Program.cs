using Blog.src.modules.user.services;
using Microsoft.Data.SqlClient;

const string connectionString = "Server=localhost,1433;Database=Blog;User ID=sa;Password=110620#Db;Trusted_Connection=False; TrustServerCertificate=True;";
using (var connection = new SqlConnection(connectionString))
{
  Load();

  Console.ReadKey();
};
static void Load()
{
  Console.Clear();
  Console.WriteLine("Meu Blog");
  Console.WriteLine("-----------------");
  Console.WriteLine("O que deseja fazer?");
  Console.WriteLine();
  Console.WriteLine("1 - Gestão de usuário");
  Console.WriteLine("2 - Gestão de perfil");
  Console.WriteLine("3 - Gestão de categoria");
  Console.WriteLine("4 - Gestão de tag");
  Console.WriteLine("5 - Vincular perfil/usuário");
  Console.WriteLine("6 - Vincular post/tag");
  Console.WriteLine("7 - Relatórios");
  Console.WriteLine();
  Console.WriteLine();
  var option = short.Parse(Console.ReadLine()!);

  switch (option)
  {
    case 1:
      MenuUser.Load();
      break;
    default: Load(); break;
  }
}





// static void ReadUsers(SqlConnection connection)
// {
//   var repository = new UserRepository(connection);
//   var items = repository.GetWithRoles();

//   foreach (var item in items)
//   {
//     Console.WriteLine(item.Name);
//     foreach (var role in item.Roles)
//     {
//       Console.WriteLine($" - {role.Name}");
//     }
//   }
// }

// static void ReadRoles(SqlConnection connection)
// {
//   var repository = new Repository<Role>(connection);
//   var roles = repository.GetAll();
//   foreach (var role in roles)
//     Console.WriteLine(role.Name);
// }

// static void ReadTag(SqlConnection connection)
// {
//   var repository = new Repository<Role>(connection);
//   var Items = repository.GetAll();
//   foreach (var item in Items)
//     Console.WriteLine(item.Name);
// }