// Questão 01
// Classe Veículo - Atributos   5
//                - Construtor  5
//                - Get/Set     5
//                - Validação   5
//                - Peso/Pot    5
//                - ToString    5
// Classe Main    - ReadLine    5
//                - new Veiculo 5
//                - Laço        5
//                - Menor       5
using System;

class Veiculo : IComparable {
  private string nome = "Sem nome";
  private int potencia = 1;
  private double peso = 1;
  public Veiculo(string n, int pot, double pes) {
    SetNome(n);
    SetPotencia(pot);
    SetPeso(pes);
  }
  public void SetNome(string nome) {
    if (nome != "") this.nome = nome;
    else throw new ArgumentOutOfRangeException();
  }
  public void SetPotencia(int pot) {
    if (pot > 0) this.potencia = pot;
    else throw new ArgumentOutOfRangeException();
  }
  public void SetPeso(double pes) {
    if (pes > 0) this.peso = pes;
    else throw new ArgumentOutOfRangeException();
  }
  public string GetNome() {
    return nome;
  }
  public int GetPotencia() {
    return potencia;
  }  
  public double GetPeso() {
    return peso;
  } 
  public double PesoPotencia() {
    return peso/potencia;
  }
  public override string ToString() {
    return $"{nome} - {potencia} cv - {peso} kg";
  }
  public int CompareTo(object obj) {
    // this, obj
    Veiculo x = (Veiculo) obj;
    return this.PesoPotencia().CompareTo(x.PesoPotencia());
  }
}
/* Questão da avaliação: O(n)
class Program {
  public static void Main() {
    Console.WriteLine("Informe nome, potencia e peso do 1º veículo");
    Veiculo m = new Veiculo(
      Console.ReadLine(),
      int.Parse(Console.ReadLine()),
      double.Parse(Console.ReadLine())
    );
    for (int i = 2; i <= 10; i++) {
      Console.WriteLine($"Informe nome, potencia e peso do {i}º veículo");
      Veiculo v = new Veiculo(
        Console.ReadLine(),
        int.Parse(Console.ReadLine()),
        double.Parse(Console.ReadLine())
      );
      if (v.PesoPotencia() < m.PesoPotencia()) m = v;
    }
    Console.WriteLine(m);
  }
}
*/
// Questão da avaliação usando IComparable: O(n.log(n))
class Program {
  public static void Main() {
    Veiculo[] vetor = new Veiculo[3];
    for (int i = 1; i <= 10; i++) {
      Console.WriteLine($"Informe nome, potencia e peso do {i}º veículo");
      Veiculo v = new Veiculo(
        Console.ReadLine(),
        int.Parse(Console.ReadLine()),
        double.Parse(Console.ReadLine())
      );
      vetor[i-1] = v;
    }
    Array.Sort(vetor);
    Console.WriteLine(vetor[0]);
  }
}
