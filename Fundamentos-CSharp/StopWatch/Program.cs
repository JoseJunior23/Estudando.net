static void MainMenu()
{
  Console.Clear();
  Console.WriteLine("Bem vindo ao Chronus");
  int time = TimeMenu();
  Console.WriteLine("-----------------");
  Console.WriteLine("Escolha o tipo de cronometro:");
  Console.WriteLine("Para cronometro progressivo digite P");
  Console.WriteLine("Para cronometro regressivo digite R");

  string data = Console.ReadLine().ToLower();
  char type = char.Parse(data.Substring(data.Length - 1, 1));
  Console.WriteLine(type);

  if (type == 'p' && time != 0)
  {
    PreStart();
    Progressive(time);
  }
  else if (type == 'r' && time != 0)
  {
    PreStart();
    Regressive(time);
  }

}

static int TimeMenu()
{
  Console.WriteLine("Digite o tempo a ser cronometrado em segundos");
  int time = int.Parse(Console.ReadLine());
  return time;
}

static void ReturnMenu()
{
  Console.Clear();
  Console.WriteLine("Para sair digite zero(0)");
  Console.WriteLine("--------------------------");
  Console.WriteLine("Ou Qualquer tecla para voltar ao menu");
  string data = Console.ReadLine();
  if (data == "0")
  {
    Console.WriteLine("Finalizando ...");
    Thread.Sleep(1500);
    System.Environment.Exit(0);
  }
  else
  {
    MainMenu();
  }
}

static void PreStart()
{
  Console.Clear();
  Console.WriteLine("Ready ...");
  Thread.Sleep(1000);
  Console.WriteLine("Set ...");
  Thread.Sleep(1000);
  Console.WriteLine("Go ...");
  Thread.Sleep(2500);
}

static void Progressive(int time)
{
  int currentTime = 0;

  while (currentTime != time)
  {
    Console.Clear();
    currentTime++;
    Console.WriteLine(currentTime);
    Thread.Sleep(1000);
  }

  Console.Clear();
  Console.WriteLine("Cronometro finalizado !!!");
  Thread.Sleep(2500);
  ReturnMenu();
}

static void Regressive(int time)
{
  for (int i = time; i >= 0; i--)
  {
    Console.Clear();
    Console.WriteLine(i);
    Thread.Sleep(1000);
  }
  ReturnMenu();
}

MainMenu();
