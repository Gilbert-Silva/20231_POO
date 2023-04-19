using System;
class Program {  // UI
  public static void Main() {
    Triangulo x = new Triangulo();
    x.SetBase(10);   // x.b = 10;
    x.SetAltura(20); // x.h = 20;
    Console.WriteLine(x.GetBase());
    Console.WriteLine(x.GetAltura());
    Console.WriteLine(x.CalcArea());
    Triangulo y = new Triangulo();
    Console.WriteLine(y.GetBase());
    Console.WriteLine(y.GetAltura());
    Console.WriteLine(y.CalcArea());    
  }
}

class Triangulo {  // Entidade
  private double b, h; // Encapsulamento
  public void SetBase(double v) {
    if (v >= 0) b = v;
  }
  public double GetBase() {
    return b;
  }
  public void SetAltura(double v) {
    if (v >= 0) h = v;
  }
  public double GetAltura() {
    return h;
  }
  public double CalcArea() {
    return b * h / 2;
  }
}