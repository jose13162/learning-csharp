using System;

class KeyboardInput {
  static void Main() {
    int number1, number2, result;

    Console.Write("Digite o primeiro número: ");
    number1 = int.Parse(Console.ReadLine());

    Console.Write("Digite o segundo número: ");
    number2 = Convert.ToInt32(Console.ReadLine());

    result = number1 + number2;

    Console.WriteLine("{0} + {1} = {2}", number1, number2, result);
  }
}