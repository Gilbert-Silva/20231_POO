using System;
class Program {
  public static void Main() {
    Aluno a = new Aluno();  // objeto da classe Aluno
    a.nome = "Gilbert";
    a.matricula = "1234";
    Aluno b = new Aluno();
    b.nome = "Eduardo";
    b.matricula = "4321";
    a = b;
    a.nome = "Minora";
    Console.WriteLine(a.nome);
    Console.WriteLine(b.nome);
  }
}
class Aluno {
  public string nome;      // atributo
  public string matricula; // atributo
}
