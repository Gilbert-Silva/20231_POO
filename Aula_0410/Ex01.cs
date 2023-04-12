using System; 
using System.Globalization;
using System.Threading;

public class Program {
  public static void Main(string[] args) {
    Thread.CurrentThread.CurrentCulture = new CultureInfo("pt-BR");
    
    Console.WriteLine("Python".CompareTo("Java"));
    Console.WriteLine("Python".CompareTo("Python"));
    Console.WriteLine("Java".CompareTo("Python"));
    int x = 7;
    //Console.WriteLine(1 <= x <= 10);
    Console.WriteLine(1 <= x && x <= 10);
    x++;
    Console.WriteLine(x);
    Console.WriteLine(x++);
    Console.WriteLine(++x);
    Console.WriteLine(DateTime.Now);
    Console.WriteLine(2.5);
  }
}