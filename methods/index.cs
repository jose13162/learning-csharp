using System;

class Arrays {
  static void Main(string[] args) {
    Console.Write("Insert a number: ");
    int value = readInteger();

    Console.WriteLine(value);
  }

  static int readInteger() {
    int value = int.Parse(Console.ReadLine());

    return value;

    Console.WriteLine("Writing something");
  }
}