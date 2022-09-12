using System;

class For {
  static void Main(string[] args) {
    int[] primeNumbers = { 2, 3, 5, 7, 11, 13 };

    for (int i = 1; i < primeNumbers.Length; i++) {
      Console.WriteLine("{0} is a prime number", primeNumbers[i]);
    }
  }
}