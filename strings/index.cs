using System;

class Name {
  static void Main(string[] args) {
    string text = "Free code camp"; 
    int codeCampIndex = text.IndexOf("code camp");

    Console.WriteLine(text.Substring(codeCampIndex, 4));
  }
}