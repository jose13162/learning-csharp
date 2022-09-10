using System;

class IfConditional {
  static void Main() {
    string result = "Reprovado";

    Console.Write("Informe sua nota 1: ");
    int score1 = int.Parse(Console.ReadLine());
    Console.Write("Informe sua nota 2: ");
    int score2 = int.Parse(Console.ReadLine());
    Console.Write("Informe sua nota 3: ");
    int score3 = int.Parse(Console.ReadLine());
    Console.Write("Informe sua nota 4: ");
    int score4 = int.Parse(Console.ReadLine());

    int average = (score1 + score2 + score3 + score4) / 4;

    if (average >= 60) {
      result = "Aprovado";
    }

    Console.WriteLine("Média: {0}\nResultado: {1}", average, result);
  }
}