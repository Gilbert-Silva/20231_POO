using System;

class Program {
  public static void Main() {
    DateTime d = DateTime.Parse("1998-12-11");
    Console.WriteLine(d);
    Console.WriteLine(d.Day);
    Console.WriteLine(d.Month);
    Console.WriteLine(d.Year);
    Console.WriteLine(d.DayOfWeek);
    Console.WriteLine(d.DayOfYear);
    Console.WriteLine(d.ToString("dd/MM/yyyy"));
    Console.WriteLine(d.ToString("ddd/MMM/yyyy"));
    Console.WriteLine(d.ToString("dddd/MMMM/yyyy"));
    Console.WriteLine(DateTime.Now);
    Console.WriteLine(DateTime.Today);
  }
}
