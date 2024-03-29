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
      Console.Write("+");
      for (int i = 0; i <= 30; i++)
      {
        Console.Write("-");
      }
      Console.Write("+");
      Console.Write("\n");

      for (int lines = 0; lines <= 10; lines++)
      {

        Console.Write("+");
        for (int i = 0; i <= 30; i++)
        {
          Console.Write("-");
        }
        Console.Write("+");
        Console.Write("\n");
      }
    }

    static void Line()
    {
      Console.Write("|");
      for (int i = 0; i <= 30; i++)
      {
        Console.Write(" ");
      }
      Console.Write("|");
      Console.Write("\n");
    }
  }
}
