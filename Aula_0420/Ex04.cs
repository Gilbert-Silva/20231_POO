using System;
class Program {
  public static void Main() {
    ContaBancaria x = new ContaBancaria("Gilbert", "1234");
    //ContaBancaria x = new ContaBancaria();
    //x.SetTitular("Gilbert");
    //x.SetNumConta("1234");
    Console.WriteLine(x.GetTitular());
    Console.WriteLine(x.GetNumConta());
    Console.WriteLine(x.GetSaldo());
    x.Depositar(1000);
    Console.WriteLine(x.GetSaldo());
    if (x.Sacar(1400)) Console.WriteLine(x.GetSaldo());
    else Console.WriteLine("Saldo insuficiente");
    Console.WriteLine(x);
  }
}
class ContaBancaria {
  private string titular = "sem nome";
  private string numConta = "sem número";
  private double saldo;
  public ContaBancaria() { }
  public ContaBancaria(string t, string n) {
    if (t != "") titular = t;
    SetNumConta(n);
  }
  public void SetTitular(string titular) { 
    if (titular != "") this.titular = titular; 
  }
  public void SetNumConta(string numConta) { 
    if (numConta != "") this.numConta = numConta;
  }
  public void Depositar(double v) { 
    if (v < 0) throw new ArgumentOutOfRangeException();
    if (v > 0) saldo += v; 
  }
  public bool Sacar(double v) { 
    if (v < 0) throw new ArgumentOutOfRangeException();
    if (v > 0 && v <= saldo) { saldo -= v; return true; }
    return false;
  }
  public string GetTitular() { return titular; }
  public string GetNumConta() { return numConta; }
  public double GetSaldo() { return saldo; }
  public override string ToString() {
    return $"{titular} {numConta} {saldo:f2}";
  }
}