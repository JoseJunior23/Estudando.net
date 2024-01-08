using Blog.src.modules.user.entities;
using Blog.src.shared;
using Blog.src.shared.repositories;

namespace Blog.src.modules.user.services
{
  public static class CreateUser
  {
    public static void Load()
    {
      Console.Clear();
      Console.WriteLine("Novo usuário");
      Console.WriteLine(" ");
      Console.WriteLine("Nome: ");
      var name = Console.ReadLine();

      Console.WriteLine("Email: ");
      var email = Console.ReadLine();

      Console.Write("Senha: ");
      var password = Console.ReadLine();

      Console.Write("Bio: ");
      var bio = Console.ReadLine();

      Console.Write("Imagem: ");
      var image = Console.ReadLine();

      Console.Write("Slug: ");
      var slug = Console.ReadLine();

      Create(new User
      {
        Name = name,
        Email = email,
        Password = password,
        Bio = bio,
        Image = image,
        Slug = slug,
      });
      Console.ReadKey();
      MenuUser.Load();
    }

    public static void Create(User user)
    {
      try
      {
        var repository = new Repository<User>(Database.connection);
        repository.Create(user);
        Console.WriteLine("Usuário cadastrado com sucesso");
      }
      catch (Exception ex)
      {
        Console.WriteLine("Não foi possível salvar o usuário");
        Console.WriteLine(ex.Message);
      }
    }
  }
}