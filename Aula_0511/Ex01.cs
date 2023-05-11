using System;
class Program {
  public static void Main() {
    PontoXY a = new PontoXY(1,2);
    PontoXY b = new PontoXY(3,4);
    Console.WriteLine(a);
    Console.WriteLine(b);
    PontoXY c = a.Somar(b);
    Console.WriteLine(c);
    PontoXY d = PontoXY.Somar(a, b);
    Console.WriteLine(d);
    PontoXY e = a + b; // Sobrecarga de operador
    Console.WriteLine(e);
  }
}
class PontoXY {
  private double x, y;
  public PontoXY(double x, double y) {
    this.x = x;
    this.y = y;
  }
  public PontoXY Somar(PontoXY p) {
    return new PontoXY(p.x + x, p.y + y);
  }
  public static PontoXY Somar(PontoXY p, PontoXY q) {
    return new PontoXY(p.x + q.x, p.y + q.y);
  }
  public static PontoXY operator +(PontoXY p, PontoXY q) {
    return new PontoXY(p.x + q.x, p.y + q.y);
  }
  public override string ToString() {
    return $"({x}, {y})";
  }
}
