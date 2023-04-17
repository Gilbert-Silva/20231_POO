class Main {
  public static void main(String[] args) {
    Triangulo x;            // Referência
    x = new Triangulo();    // Instância ou objeto
    x.b = 10;
    x.h = 20;
    System.out.println(x);
    System.out.println(x.toString());   
    System.out.println(x.b);
    System.out.println(x.h);
    System.out.println(x.calcArea());
  }
}

class Triangulo {
  public double b, h;          // Campo ou atributo
  public double calcArea() {   // Método
    return b * h / 2;
  }  
}