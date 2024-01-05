using System.Text.RegularExpressions;

namespace TextEditorHtml
{
  public class Viewer
  {
    public static void Show(string text)
    {
      Console.Clear();
      Console.BackgroundColor = ConsoleColor.Gray;
      Console.ForegroundColor = ConsoleColor.White;
      Console.Clear();
      Console.WriteLine("MODO LEITURA");
      Console.WriteLine("-----------");
      Replace(text);
      Console.WriteLine("-----------");
      Console.ReadKey();
      Menu.Show();
    }

    public static void Replace(string text)
    {
      var strong = new Regex(@"<\s*strong[^>]*>(.*?)<\s*/\s*trong>");
      var words = text.Split(' ');
      for (var i = 0; i <= words.Length; i++)
      {
        if (strong.IsMatch(words[i]))
        {
          Console.ForegroundColor = ConsoleColor.DarkBlue;
          Console.Write(
            words[i].Substring(
              words[i].IndexOf('>') + 1,
              (
                (words[i].LastIndexOf('<') - 1) -
                words[i].LastIndexOf('>')
              )
            )
          );
        }
      }
    }
  }
}