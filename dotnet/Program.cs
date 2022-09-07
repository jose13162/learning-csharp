using System;

namespace dotnet
{
  class Program
  {
    static void Main(string[] args)
    {
      if (args.GetLength(0) > 0)
      {
        Console.WriteLine(args.GetValue(0));
      }
    }
  }
}