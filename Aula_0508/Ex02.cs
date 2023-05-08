using System;
class Program {
  public static void Main() {
    Cliente a = new Cliente("Gilbert", 1000);
    Cliente b = new Cliente("Jorgiano", 1500);
    Cliente c = new Cliente("Eduardo", 2000);
    Cliente d = new Cliente("Marília", 2000);
    a.SetSocio(b);
    Console.WriteLine(a);
    Console.WriteLine(b);
    Console.WriteLine(c);
    Console.WriteLine(d);
    Console.WriteLine();
    c.SetSocio(d);
    Console.WriteLine(a);
    Console.WriteLine(b);
    Console.WriteLine(c);
    Console.WriteLine(d);
    Console.WriteLine();
    a.SetSocio(c);
    Console.WriteLine(a);
    Console.WriteLine(b);
    Console.WriteLine(c);
    Console.WriteLine(d);   
  }
}
class Cliente {
  private string nome;
  private double limite;
  private Cliente socio = null;
  public Cliente(string nome, double limite) {
    if (nome != "") this.nome = nome;
    if (limite > 0) this.limite = limite;
  }
  public void SetSocio(Cliente x) {
    Cliente sociodeThis = this.socio;
    Cliente sociodeX = x.socio;
    if (sociodeThis != null) sociodeThis.socio = null;
    if (sociodeX != null) sociodeX.socio = null;
    this.socio = x;
    x.socio = this;
  }
  public override string ToString() {
    if (socio == null)
      return $"{nome} - {limite}";
    else
      return $"{nome} - {limite} - {socio.nome}";
  }
}
