using System.Text;

namespace TextEditorHtml
{

  public static class Editor
  {
    public static void Show()
    {
      Console.Clear();
      Console.BackgroundColor = ConsoleColor.Gray;
      Console.ForegroundColor = ConsoleColor.White;
      Console.Clear();
      Console.WriteLine("MODO EDITOR");
      Console.WriteLine("-----------");
      Start();
    }

    public static void Start()
    {
      var file = new StringBuilder();
      do
      {
        file.Append(Console.ReadLine());
        file.Append(Environment.NewLine);
      } while (Console.ReadKey().Key != ConsoleKey.Escape);

      Console.WriteLine("---------------");
      Console.WriteLine(" Deseja salvar o arquivo");
      bool saveFile = bool.Parse(Console.ReadLine())
      Save(file.ToString());
    }

    static void Save(string text)
    {
      Console.Clear();
      Console.WriteLine("Qual caminho para salvar o arquivo");
      var path = Console.ReadLine();

      using (var file = new StreamWriter(path))
      {
        file.Write(text);
      }

      Console.WriteLine($"Arquivo {path} salvo com sucesso");
      Console.ReadLine();
      Menu.Show();
    }
  }
}

