using System;

class Aluno {
  public string nome, matricula;
  public override string ToString() {
    return $"{nome} - {matricula}";
  }
}

class Program {
  public static void Main() {
    
    Aluno a = new Aluno();
    a.nome = "Gilbert";
    a.matricula = "1234";
    int b = 10;
    Console.WriteLine(a);
    Console.WriteLine(b);
    object x = b;  // boxing
    Console.WriteLine(x);
    x = a;
    Console.WriteLine(x);
    object[] v = { 1, 2.5, "Teste", a};
    //v = [ 1, 2.5, Teste, Aluno()]
    Console.WriteLine(v[3]);
    foreach (object obj in v)
      Console.WriteLine(obj);
  }
}
