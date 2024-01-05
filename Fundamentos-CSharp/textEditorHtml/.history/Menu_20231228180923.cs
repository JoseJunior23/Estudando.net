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
    }

    public static void DrawScreen()
    {
      Line('+', 30);
      Line('|', 10);
      Line('+', 30);

    }

    static void Line(char figure1, int cont)
    {
      Console.Write(figure1);
      for (int i = 0; i <= cont; i++)
      {
        Console.Write(" ");
      }
      Console.Write(figure1);
      Console.Write("\n");
    }
  }
}
