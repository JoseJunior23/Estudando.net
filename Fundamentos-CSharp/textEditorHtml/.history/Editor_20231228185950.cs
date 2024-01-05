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
    }
  }
}

