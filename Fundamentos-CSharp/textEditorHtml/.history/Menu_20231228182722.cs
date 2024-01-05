using System;

namespace TextEditorHtml
{
  public static class Menu
  {
    public static void Show()
    {
      Console.Clear();
      Console.BackgroundColor = ConsoleColor.DarkBlue;
      Console.ForegroundColor = ConsoleColor.White;
      DrawScreen();
      WriteOptions();

      var option = short.Parse(Console.ReadLine());
    }

    public static void DrawScreen()
    {
      Line('+', '-', 30);
      for (int lines = 0; lines <= 10; lines++)
      {
        Line('|', ' ', 30);
      }

      Line('+', '-', 30);

    }

    public static void Line(char figure1, char figure2, int cont)
    {
      Console.Write(figure1);
      for (int i = 0; i <= cont; i++)
      {
        Console.Write(figure2);
      }
      Console.Write(figure1);
      Console.Write("\n");
    }

    public static void WriteOptions()
    {
      Console.SetCursorPosition(3, 2);
      Console.WriteLine("Editor HTML");
      Console.SetCursorPosition(3, 3);
      Console.WriteLine("###################");
    }
  }
}
