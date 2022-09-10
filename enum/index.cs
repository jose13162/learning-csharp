using System;

class Enum {
  enum WeekDays {
    Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday
  }

  static void Main() {
    WeekDays friday = (WeekDays)4;
    WeekDays saturday = (WeekDays)5;
    int sundayIndex = (int)WeekDays.Sunday;

    Console.WriteLine(friday);
    Console.WriteLine(saturday);
    Console.WriteLine(sundayIndex);
  }
}