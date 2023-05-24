// Questão 01
// Classe PontoXY - Atributos   5
//                - Construtor  5
//                - Get/Set     5
//                - Distancia   5
//                - Somar       5
//                - ToString    5
// Classe Main    - ReadLine    5
//                - new Ponto   5
//                - Distancia   5
//                - Somar       5

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
    PontoXY e = a + b;   // Sobrecarga de operador PontoXY.operator+(a , b)
    Console.WriteLine(e);
  }
}
class PontoXY {
  private double x, y;
  public PontoXY(double x, double y) {
    this.x = x;
    this.y = y;
  }
  public void SetX(double x) {
    this.x = x;
  }
  public void SetY(double y) {
    this.y = y;
  }
  public double GetX() {
    return x;
  }
  public double GetY() {
    return y;
  }
  public double Distancia() {
    return Math.Sqrt(x * x + y * y);
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
