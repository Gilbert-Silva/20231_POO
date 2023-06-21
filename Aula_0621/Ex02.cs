using System;

class Program {
  public static void Main() {
    Triangulo t = new Triangulo();
    try {
      t.Base = double.Parse(Console.ReadLine());
      Console.WriteLine(t.Base);
      t.Altura = double.Parse(Console.ReadLine());
      Console.WriteLine(t.Altura);
    }
    catch (FormatException) {
      Console.WriteLine("Erro de formatação");
    }
    catch (ArgumentOutOfRangeException) {
      Console.WriteLine("Valor negativo");
    }
    catch (DimensaoInvalidaException x) {
      Console.WriteLine($"O valor informado {x.GetValor()} não é válido");
    }
  }
}

class Triangulo {
  private double b, h;
  public double Base {
    get { return b; }
    set { 
      if (value < 0) throw new ArgumentOutOfRangeException();
      else b = value;
    }
  }
  public double Altura {
    get { return h; }
    set { 
      if (value < 0) throw new DimensaoInvalidaException(value);
      else h = value;
    }
  }
}

class DimensaoInvalidaException : Exception {
  private double valor;
  public DimensaoInvalidaException(double v) {
    valor = v;
  }
  public double GetValor() {
    return valor;
  }
}