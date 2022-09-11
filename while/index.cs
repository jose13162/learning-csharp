using System;

class While {
  static void Main(string[] args) {
    int index = 6;

    do {
      Console.WriteLine("That's called at least once (do while)");
      index++;
    } while (index <= 5);

    while (index <= 5) {
      Console.WriteLine("That's not called");
      index++;
    }
  }
}