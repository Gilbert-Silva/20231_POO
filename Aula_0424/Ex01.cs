using System;
class Triangulo {
  private double b = 1, h;
  public Triangulo() { h = 2; }
  public Triangulo(double b, double h) {
    if (b > 0) this.b = b;
    if (h > 0) this.h = h;
  }
  public void SetBase(double b) {
    if (b > 0) this.b = b; }
  public void SetAltura(double h) {
    if (h > 0) this.h = h; }
  public override string ToString() {
    return $"Base = {b}, Altura = {h}";
  }
}
class Program {
  public static void Main() {
    Triangulo x = new Triangulo();
    Console.WriteLine(x);
    Triangulo y = new Triangulo(1, 2);
    Console.WriteLine(y);
    //x = y;
    Console.WriteLine(x.Equals(y));
  }
}
