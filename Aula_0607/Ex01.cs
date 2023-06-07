using System;
using System.Collections;

class Program {
  public static void Main() {
    ContaReceber a = new ContaReceber("Gilbert", DateTime.Parse("6/2/2023"), 100);                     // 5
    ContaReceber b = new ContaReceber("Eduardo", DateTime.Parse("6/1/2023"), 200); 
    ContaReceber c = new ContaReceber("Jorgiano", DateTime.Parse("7/1/2022"), 300); 
    ContaReceber d = new ContaReceber("Minora", DateTime.Parse("7/15/2023"), 400); 
    ContaReceber e = new ContaReceber("Janser", DateTime.Parse("6/10/2023"), 500);
    a.Receber();
    c.Receber();
    Console.WriteLine(a);
    Console.WriteLine(b);
    Console.WriteLine(c);
    Console.WriteLine(d);
    Console.WriteLine(e);

    Financeiro f = new Financeiro();   // 5 
    f.Inserir(a);
    f.Inserir(b);
    f.Inserir(c);
    f.Inserir(d);
    f.Inserir(e);
    Console.WriteLine("\nTodas as contas");
    //foreach (ContaReceber conta in f.Listar()) 
    foreach (ContaReceber conta in f) // 5 a 10 pontos
      Console.WriteLine(conta);
    Console.WriteLine("\nContas recebidas");   
    foreach (ContaReceber conta in f.ContasRecebidas()) 
      Console.WriteLine(conta);
    Console.WriteLine("\nContas a receber");   
    foreach (ContaReceber conta in f.ContasAReceber()) 
      Console.WriteLine(conta);
    Console.WriteLine("\nContas vencidas");   
    foreach (ContaReceber conta in f.ContasVencidas()) 
      Console.WriteLine(conta);
    Console.WriteLine($"\nNº de contas a receber: {f}");   
    
  }
}
class Financeiro : IEnumerable {
  private ContaReceber[] contas = new ContaReceber[10]; // Atributos - 4
  private int k;                                        // New - 4
  public void Inserir(ContaReceber conta) {             // Inserir - 6
    contas[k++] = conta;
  }
  public ContaReceber[] Listar() {                      // Listar - 6
    ContaReceber[] aux = new ContaReceber[k];
    Array.Copy(contas, aux, k);
    Array.Sort(aux);
    return aux;
  }
  public ContaReceber[] ContasRecebidas() {              // 6
    ContaReceber[] aux = new ContaReceber[k];
    int c = 0;
    foreach(ContaReceber conta in Listar())
      if (conta.Recebido) aux[c++] = conta;
    Array.Resize(ref aux, c);
    return aux;
  }
  public ContaReceber[] ContasAReceber() {              // 6
    ContaReceber[] aux = new ContaReceber[k];
    int c = 0;
    foreach(ContaReceber conta in Listar())
      if (!conta.Recebido && 
        conta.DataVencimento >= DateTime.Today &&
        conta.DataVencimento <= DateTime.Today.AddDays(15)) 
        aux[c++] = conta;
    Array.Resize(ref aux, c);
    return aux;
  }  
  public ContaReceber[] ContasVencidas() {              // 6
    ContaReceber[] aux = new ContaReceber[k];
    int c = 0;
    foreach(ContaReceber conta in Listar())
      if (!conta.Recebido && 
        conta.DataVencimento <= DateTime.Today) 
        aux[c++] = conta;
    Array.Resize(ref aux, c);
    return aux;
  }  
  public override string ToString() {                   // 6
    return $"{ContasAReceber().Length} conta(s) a receber";
  }
  public IEnumerator GetEnumerator() {                  // 6
    return Listar().GetEnumerator();
  } 
}
class ContaReceber : IComparable {
  private string cliente;             // Atributo - 5 pontos
  private DateTime dataVencimento;
  private double valor;
  private bool recebido;
  public ContaReceber(string c, DateTime d, double v) {  // Const - 5 pontos
    if (c != "") this.cliente = c;
    dataVencimento = d;
    if (v > 0) this.valor = v;
    this.recebido = false;
  }
  public string Cliente {   // Prop - 5 pontos
    get { return cliente; }
    set { if (value != "") this.cliente = value; }
  }
  public DateTime DataVencimento { 
    get { return dataVencimento; }
    set { this.dataVencimento = value; }
  }  
  public double Valor { 
    get { return valor; }
    set { if (valor > 0) this.valor = value; }
  }
  public bool Recebido { 
    get { return recebido; }
    set { this.recebido = value; }
  }
  public void Receber() { // Receber - 5 pontos
    this.recebido = true;
  }
  public int CompareTo(object obj) { // CompareTo - 5 pontos
    ContaReceber x = obj as ContaReceber;
    return dataVencimento.CompareTo(x.dataVencimento);
  }
  public override string ToString() { // ToString - 5 pontos
    return $"{cliente} {dataVencimento:dd/MM/yyyy} {valor:0.00} {recebido}";
  }
}
