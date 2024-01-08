using Blog.src.modules.user.repositories;
using Blog.src.shared;


namespace Blog.src.modules.user.services
{
  public static class ListUser
  {
    public static void Load()
    {
      Console.Clear();
      Console.WriteLine("Lista de usuários");
      Console.WriteLine(" ");
      List();
      Console.ReadKey();
      MenuUser.Load();
    }

    private static void List()
    {
      var repository = new UserRepository(Database.connection);
      var users = repository.GetWithRoles();
      foreach (var user in users)
      {
        Console.WriteLine(user.Name);
        foreach (var role in user.Roles)
        {
          Console.WriteLine($" - {role.Name}");
        }
      }
    }
  }
}