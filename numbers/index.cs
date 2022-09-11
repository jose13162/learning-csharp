using System;

class Numbers {
  static void Main(string[] args) {
    double first_number, second_number, result;

    Console.Write("Enter an operation\n[1] - sum\n[2] - subtract\n[3] - divide\n[4] - multiply\nOperation: ");
    int operation = int.Parse(Console.ReadLine());

    if (operation < 1 | operation > 4) {
      Console.WriteLine("Invalid operation.");
    }

    if (operation >= 1 & operation <= 4) {
      Console.Write("Write the first number: ");
      first_number = double.Parse(Console.ReadLine());

      Console.Write("Write the second number: ");
      second_number = double.Parse(Console.ReadLine());

      if (operation == 1) {
        result = first_number + second_number;

        Console.WriteLine("{0} + {1} = {2}", first_number, second_number, result);
      }

      if (operation == 2) {
        result = first_number - second_number;

        Console.WriteLine("{0} - {1} = {2}", first_number, second_number, result);
      }

      if (operation == 3) {
        result = first_number / second_number;

        Console.WriteLine("{0} : {1} = {2}", first_number, second_number, result);
      }

      if (operation == 4) {
        result = first_number * second_number;

        Console.WriteLine("{0} x {1} = {2}", first_number, second_number, result);
      }
    }
  }
}