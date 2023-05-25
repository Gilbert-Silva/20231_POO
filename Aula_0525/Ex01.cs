using System;
using System.Collections;

class Jogador : IComparable {
  private string nome = "sem nome";
  private int camisa = 1, numGols = 0;
  public Jogador(string nome, int camisa, int numGols) {
    Nome = nome;
    Camisa = camisa;
    NumGols = numGols;
    //if (nome != "") this.nome = nome;
    //if (camisa > 0 && camisa < 1000) this.camisa = camisa;
    //if (numGols >= 0) this.numGols = numGols;
  }
  public string Nome {
    set { if (value != "") this.nome = value; }
    get { return nome; }
  }
  public int Camisa {
    set { if (value > 0 && value < 1000) this.camisa = value; }
    get { return camisa; }
  }
  public int NumGols {
    set { if (value >= 0) this.numGols = value; }
    get { return numGols; }
  }  
  public override string ToString() {
    return $"{nome} - {camisa} - {numGols}";
  }
  public int CompareTo(object obj) {
    Jogador x = obj as Jogador;
    return nome.CompareTo(x.nome);
  }
} 
class CamisaComparer : IComparer {
  public int Compare(object obj1, object obj2) {
    Jogador x = obj1 as Jogador;
    Jogador y = obj2 as Jogador;
    return x.Camisa.CompareTo(y.Camisa);
  }  
}
class GolComparer : IComparer {
  public int Compare(object obj1, object obj2) {
    Jogador x = obj1 as Jogador;
    Jogador y = obj2 as Jogador;
    return -x.NumGols.CompareTo(y.NumGols);
  }  
}
class Program {
  public static void Main() {
    Jogador a = new Jogador("Z", 10, 509);
    Jogador b = new Jogador("S", 8, 172);
    Jogador c = new Jogador("E", 11, 122);
    Jogador[] v = {a, b, c};
    Array.Sort(v, new GolComparer());
    foreach (Jogador j in v)
      Console.WriteLine(j);
  }
}