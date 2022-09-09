using System;

class ConsoleOutput {
  static void Main() {
    double price = 30;
    double sellingPrice;
    double profit = 0.5;
    string productName = "Some software";

    sellingPrice = price + price * profit;

    Console.WriteLine("Product............: {0, 16}", productName);
    Console.WriteLine("Price..............: {0, 16:c}", price);
    Console.WriteLine("Profit.............: {0, 16:p}", profit);
    Console.WriteLine("Selling price......: {0, 16:c}", sellingPrice);
  }
}