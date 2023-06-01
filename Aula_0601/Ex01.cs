using System;
using System.Collections; 
using System.Collections.Generic;
using System.Linq;

class Program {
  public static void Main() {
    int[] v = { 5, 3, 8, 9, 1, 4 };
    IEnumerator it = v.GetEnumerator(); // IEnumerable
    it.MoveNext();
    Console.WriteLine(it.Current);
    it.MoveNext();
    Console.WriteLine(it.Current);
    //it.Reset();
    it.MoveNext();
    Console.WriteLine(it.Current);
    Stack pilha = new Stack();
    pilha.Push(5);
    pilha.Push(3);
    pilha.Push(8);
    pilha.Push(9);
    pilha.Push(1);
    pilha.Push(4);
    it = pilha.GetEnumerator();
    it.MoveNext();
    Console.WriteLine(it.Current);
    it.MoveNext();
    Console.WriteLine(it.Current);
    it.MoveNext();    
    Console.WriteLine(it.Current);
    Hashtable h = new Hashtable();
    h["amarelo"] = "yellow";
    h["vermelho"] = "red";
    h["azul"] = "blue";
    h["cinza"] = "gray";
    it = h.GetEnumerator();
    while (it.MoveNext()) {
      DictionaryEntry elem = (DictionaryEntry) it.Current;
      Console.WriteLine(elem.Key + " " + elem.Value);
    } 
    Turma t = new Turma { Disciplina = "POO"};
    t.Inserir(new Aluno { Nome = "José Vinicius", Mat = "1234"});
    t.Inserir(new Aluno { Nome = "Luana", Mat = "4321"});
    t.Inserir(new Aluno { Nome = "Maria Giovanna", Mat = "8888"});
    t.Inserir(new Aluno { Nome = "Ramon", Mat = "4488"});
    t.Inserir(new Aluno { Nome = "Ray", Mat = "8844"});
    // Retornar um iterador para a turma?
    it = t.GetEnumerator();
    while (it.MoveNext())
      Console.WriteLine(it.Current);
    foreach (Aluno a in t)
      Console.WriteLine(a);
      Console.WriteLine("Alunos que iniciam com 'Ra'");
    foreach (Aluno a in t.Where(aluno => aluno.Nome.StartsWith("Ra")))
      Console.WriteLine(a);
  }
}

class Turma : IEnumerable<Aluno> {
  public string Disciplina { get; set; }
  private List<Aluno> alunos = new List<Aluno>();
  public void Inserir(Aluno a) {
    alunos.Add(a);
  }
  public List<Aluno> Listar() {
    return alunos;
  }
  public IEnumerator<Aluno> GetEnumerator()
  {
    return alunos.GetEnumerator();
  }
  IEnumerator IEnumerable.GetEnumerator()
  {
    return alunos.GetEnumerator();
  }
}
class Aluno {
  public string Nome { get; set; }
  public string Mat { get; set; }
  public override string ToString() {
    return $"{Nome} - {Mat}";
  }
}