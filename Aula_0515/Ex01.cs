using System;

class Paciente {
  private string nome, fone;
  private DateTime nascimento;
  public string Nome {
    get => nome;
    set => nome = value;
  }
  public string Fone {
    get { return fone; }
    set { fone = value; }
  }
  public DateTime Nascimento {
    get { return nascimento; }
    set { 
      if (value < DateTime.Now) nascimento = value;
      else throw new ArgumentOutOfRangeException();  
    }
  }
  public string Idade {
    get { 
      int anos = DateTime.Now.Year - Nascimento.Year;
      int meses = DateTime.Now.Month - Nascimento.Month;
      if (meses < 0) { meses += 12; anos--; }
      return $"{anos} ano(s) e {meses} mes(es)";
    }
  }      
}

class Program {
  public static void Main() {
    Paciente a = new Paciente { Nome = "Joao", Fone = "1234",
      Nascimento = DateTime.Parse("2000-04-18") };
    Paciente b = new Paciente { Nome = "Maria", Fone = "4321",
      Nascimento = DateTime.Parse("2000-06-18") };
    Console.WriteLine(a.Nome + " " + a.Idade);
    Console.WriteLine(b.Nome + " " + b.Idade);
  }
}
