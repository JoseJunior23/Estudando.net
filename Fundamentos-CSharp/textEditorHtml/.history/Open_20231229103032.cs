namespace TextEditorHtml
{
  public class OpenFile
  {
    static void Open()
    {
      Console.Clear();
      Console.WriteLine("qual o caminho do arquivo? ");
      string path = Console.ReadLine();
      using (var file = new StreamReader(path))
      {
        string text = file.ReadToEnd();
        Console.WriteLine(text);
      }
      Console.WriteLine("");
      Console.ReadLine();
      Menu();
    }
  }
}
