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

      Console.WriteLine("---------------");
      Console.WriteLine(" Deseja salvar o arquivo");
      Console.WriteLine("Digite s para SIM");
      Console.WriteLine("Digite n para Não");
      string saveFile = Console.ReadLine().ToLower();
      if (saveFile == "s")
      {
        Save(text);
      }
      else if (saveFile == "n")
      {
        Menu.Show();
      }

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


    public static void Replace(string text)
    {
      var strong = new Regex(@"<\s*strong[^>]*>(.*?)<\s*/\s*strong>");
      var words = text.Split(' ');
      for (var i = 0; i < words.Length; i++)
      {
        if (strong.IsMatch(words[i]))
        {
          Console.ForegroundColor = ConsoleColor.DarkBlue;
          Console.Write(
            words[i].Substring(
              words[i].IndexOf('>') + 1,
              (
                (words[i].LastIndexOf('<') - 1) - words[i].IndexOf('>')
              )
            )
          );
          Console.Write(" ");
        }
        else
        {
          Console.ForegroundColor = ConsoleColor.Gray;
          Console.Write(words[i]);
          Console.Write(" ");
        }
      }
    }
  }
}