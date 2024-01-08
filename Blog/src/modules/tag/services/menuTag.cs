namespace Blog.src.modules.tag.services
{
  public static class MenuTag
  {
    public static void Load()
    {
      Console.Clear();
      Console.WriteLine("Gestão de tags");
      Console.WriteLine("--------------");
      Console.WriteLine("O que deseja fazer?");
      Console.WriteLine();
      Console.WriteLine("1 - Listar tags");
      Console.WriteLine("2 - Cadastrar tags");
      Console.WriteLine("3 - Atualizar tag");
      Console.WriteLine("4 - Excluir tag");
      Console.WriteLine();
      Console.WriteLine();
      var option = short.Parse(Console.ReadLine());

      switch (option)
      {
        case 1:
          ListTag.Load();
          break;
        // case 2:
        //   CreateTag.Load();
        //   break;
        // case 3:
        //   UpdateTag.Load();
        //   break;
        // case 4:
        //   DeleteTag.Load();
        //   break;
        default: Load(); break;
      }
    }
  }
}