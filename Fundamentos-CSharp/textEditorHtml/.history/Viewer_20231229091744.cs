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
    }

    public static void Replace() { }
  }
}