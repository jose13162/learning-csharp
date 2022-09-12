using System;

class IsPrime {
  static void Main(string[] args) {
    Console.Write("Insert a number: ");
    int number = int.Parse(Console.ReadLine());
    int absoluteNumber = Math.Abs(number);

    bool isPrime = true;

    for (int divider = 2; divider <= Math.Sqrt(absoluteNumber); divider++) {
      if (absoluteNumber % divider == 0) {
        isPrime = false;

        break;
      }
    }

    if (isPrime) {
      Console.WriteLine("{0} is prime!", absoluteNumber);
    } else {
      Console.WriteLine("{0} is not prime!", absoluteNumber);
    }
  }
}