using System;

enum Option { Rock, Paper, Scissors, Invalid };

class RockPaperScissors {
  static void Main(string[] args) {
    string separator = "================================";

    int userOptionIndex = ValidateInteger("Insert an option\n[1] - Rock\n[2] - Paper\n[3] - Scissors\nAnswer: ", 1, 3);
    Console.WriteLine(separator);
    Option userOption = GetOption(userOptionIndex);

    int randomIndex = new Random().Next(1, 4);
    Option computerOption = GetOption(randomIndex);

    bool isTie = userOption == computerOption;
    bool userLost =
    (userOption == Option.Rock & computerOption == Option.Paper) |
    (userOption == Option.Paper & computerOption == Option.Scissors) |
    (userOption == Option.Scissors & computerOption == Option.Rock);

    if (isTie) {
      Console.WriteLine("That's a tie!");
    } else if (userLost) {
      Console.WriteLine("You lost!");
    } else {
      Console.WriteLine("You win!");
    }

    Console.WriteLine("Your choice: {0}\nMy choice: {1}", userOption, computerOption);
    Console.WriteLine(separator);
  }

  static int ValidateInteger(string message, int min, int max) {
    int value = min;
    int _min = min;
    int _max = max;

    if (min > max) {
      _max = min;
      _min = max;
    }

    while (true) {
      Console.Write(message);
      int answer = int.Parse(Console.ReadLine());

      if (answer >= _min & answer <= max) {
        value = answer;
        break;
      }
    }

    return value;
  }

  static Option GetOption(int index) {
    switch (index) {
      case 1:
        return Option.Rock;
      case 2:
        return Option.Paper;
      case 3:
        return Option.Scissors;
      default:
        return Option.Invalid;
    }
  }
}