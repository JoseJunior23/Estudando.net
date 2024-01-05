static void Menu(){
  Console.Clear();
  Console.WriteLine("Ola seja bem vindo a super calculadora ");
  Console.WriteLine("Selecione uma opção: ");
  Console.WriteLine("1- Soma");
  Console.WriteLine("2- Subtração");
  Console.WriteLine("3- Divisão");
  Console.WriteLine("4- Multiplicação");
   Console.WriteLine("5- Sair");
  Console.WriteLine("---------------------");

  short selection = short.Parse(Console.ReadLine());

  switch(selection){
    case 1: Sum(); break;
    case 2: Sub(); break;
    case 3: Div(); break;
    case 4: Multi(); break;
    case 5: System.Environment.Exit(0); break;
    default: Menu(); break;
  }
}

static void Sum(){
  Console.WriteLine("Primeiro Valor: ");
  float valor1 = float.Parse(Console.ReadLine());

  Console.WriteLine("Segundo valor: ");
  float valor2 = float.Parse(Console.ReadLine());

  float sum = (valor1 + valor2);

  Console.WriteLine($"O resultado da soma é: {sum}");

  Console.ReadKey();
  Menu();
}

 static void Sub(){
  Console.Clear();

  Console.WriteLine("Primeiro valor:");
  float number1 = float.Parse(Console.ReadLine());

  Console.WriteLine("Segundo valor:");
  float number2 = float.Parse(Console.ReadLine());

  float subtraction = number1 - number2;
  Console.WriteLine($"O resultado da subtração é: {subtraction}");
 }

static void Div(){
  Console.Clear();

  Console.WriteLine("Primeiro valor: ");
  float number1 = float.Parse(Console.ReadLine());

  Console.WriteLine("Segundo valor: ");
  float number2 = float.Parse(Console.ReadLine());

  float division = number1 / number2;
  Console.WriteLine($"O resultado da divisaõ é: {division}");

  Console.ReadKey();
}

static void Multi(){
  Console.Clear();

  Console.WriteLine("Primeiro valor: ");
  float number1 = float.Parse(Console.ReadLine());

  Console.WriteLine("Segundo valor: ");
  float number2 = float.Parse(Console.ReadLine());

  float multiplication = number1 * number2;
  Console.WriteLine($"O resultado da multiplicação é: {multiplication}");

  Console.ReadKey();
}

Menu();