using System;
class Program {
  public static void Main() {
    Console.WriteLine(Metodo1(12, 8));
    Console.WriteLine(Metodo1(33, 6));
    Console.WriteLine(Metodo1(33, 5));
  }
  public static int Metodo1(int x, int y) {
    if (y == 0) return x;
    else return Metodo1(y, x % y);
  }
}