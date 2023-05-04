using System;

struct Aluno {
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
    Aluno b = new Aluno();
    b.nome = "Eduardo";
    b.matricula = "4321";
    Console.WriteLine(a);
    Console.WriteLine(b);
    a = b;
    a.nome = "Jorgiano";
    Console.WriteLine(a);
    Console.WriteLine(b);
  }
}
    