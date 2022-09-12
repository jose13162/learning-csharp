using System;

class Lol {
  static void Main(string[] args) {
    int current = 2;
    int count = 1;
    float amount = 1000000f;

    while (true) {
      if (IsPrime(current)) {
        count++;

        Console.Clear();
        Console.WriteLine("{0} - {1}", current, 100 * (count / amount));
      }

      if (count == amount) {
        Console.WriteLine("Finished");

        break;
      }

      current++;
    }
  }

  static bool IsPrime(int number) {
    bool isPrime = true;

    for (int divider = 2; divider <= Math.Sqrt(number); divider++) {
      if (number % divider == 0) {
        isPrime = false;

        break;
      }
    }

    return isPrime;
  }
}