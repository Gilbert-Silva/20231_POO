using System;
class Program {
  public static void Main() {
    int a = int.Parse(Console.ReadLine());
    Console.WriteLine(a + a);
    int b;
    if (int.TryParse(Console.ReadLine(), out b))
      Console.WriteLine(b + b);
    else
      Console.WriteLine("Você não digitou um número inteiro");
    
    double x = Program.AreaTriangulo(10, 20);
    double y = Figuras.AreaRetangulo(10, 20);
    Console.WriteLine(x);
    Console.WriteLine(y);
  }
  public static double AreaTriangulo(double b, double h) {
    double area = b * h / 2;
    return area;
  }
}
class Figuras {
  public static double AreaRetangulo(double b, double h) {
    double area = b * h;
    return area;
  }
}