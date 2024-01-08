using Blog.src.modules.tag.entities;
using Blog.src.shared;
using Blog.src.shared.repositories;

namespace Blog.src.modules.tag.services
{
  public class ListTag
  {
    public static void Load()
    {
      Console.Clear();
      Console.WriteLine("Lista de tags");
      Console.WriteLine("-------------");
      List();
      Console.ReadKey();
      MenuTag.Load();
    }

    private static void List()
    {
      var repository = new Repository<Tag>(Database.connection);
      var tags = repository.GetAll();
      foreach (var item in tags)
        Console.WriteLine($"{item.Id} - {item.Name} ({item.Slug})");
    }
  }
}