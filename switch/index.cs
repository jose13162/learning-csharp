using System;

class Switch {
  static void Main(string[] args) {
    Console.WriteLine(getWeekDay(0));
    Console.WriteLine(getWeekDay(3));
    Console.WriteLine(getWeekDay(5));
    Console.WriteLine(getWeekDay(7));
  }

  static string getWeekDay(int index) {
    string day;

    switch (index) {
      case 0: 
        day = "Monday";
        break;
      case 1:
        day = "Tuesday";
        break;
      case 2:
        day = "Wednesday";
        break;
      case 3:
        day = "Thursday";
        break;
      case 4:
        day = "Friday";
        break;
      case 5:
        day = "Saturday";
        break;
      case 6:
        day = "Sunday";
        break;
      default:
        return "Invalid";
    }

    return day;
  }
}