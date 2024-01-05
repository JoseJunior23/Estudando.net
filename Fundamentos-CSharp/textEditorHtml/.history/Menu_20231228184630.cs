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
      HandleMenuOptions(option);
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
      Console.SetCursorPosition(4, 5);
      Console.WriteLine("Editor HTML");
      Console.SetCursorPosition(3, 3);
      Console.WriteLine("###################");
      Console.SetCursorPosition(3, 4);
      Console.WriteLine("Selecione uma opção abaixo:");
      Console.SetCursorPosition(3, 6);
      Console.WriteLine("Tecle 1- Novo arquivo");
      Console.SetCursorPosition(3, 7);
      Console.WriteLine("Tecle 2- Abrir um Arquivo");
      Console.SetCursorPosition(3, 9);
      Console.WriteLine("tecle 0- Sair");
      Console.SetCursorPosition(3, 10);
      Console.Write("Opção: ");
    }

    public static void HandleMenuOptions(short option)
    {
      switch (option)
      {
        case 1: Console.WriteLine("Editor"); break;
        case 2: Console.WriteLine("View"); break;
        case 0:
          {
            Console.Clear();
            Environment.Exit(0);
            break;
          }
        default: Show(); break;
      }
    }
  }
}
