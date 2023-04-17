using System;

class Program {
  public static void Main() {
    //double d;
    //Console.WriteLine(d);
    // Triangulo t;
    // Console.WriteLine(t);
    Triangulo x, y;             // Referência
    x = new Triangulo();        // Instância ou objeto
    y = new Triangulo();
    Triangulo z = new Triangulo();

    x.b = 10;
    x.h = 20;
    Console.WriteLine(x);
    Console.WriteLine(x.ToString());   
    Console.WriteLine(x.b);
    Console.WriteLine(x.h);
    // Console.WriteLine(x.b * x.h / 2);
    Console.WriteLine(x.CalcArea());
    y.b = -10;
    y.h = 20;
    Console.WriteLine(y);
    Console.WriteLine(y.CalcArea());
    z.b = 10;
    z.h = -30;
    Console.WriteLine(z);
    Console.WriteLine(z.CalcArea());

 
    
    x = null;
    // x.b = 40;  
    Triangulo.CalcArea(y.b, y.h);
    
  }
}

/*
class Object {
  public virtual string ToString() {
    
  }
}
*/

class Triangulo : Object {
  public double b, h;          // Campo ou atributo
  public double CalcArea() {   // Método
    return b * h / 2;
  }
  public static double CalcArea(double b, double h) {
    return b * h / 2;
  }
  public override string ToString() {
    return $"Eu sou um triângulo com base {b} e altura {h}";
  }  
}
