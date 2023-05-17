using System;
using System.Globalization;
using System.Threading;

class Program {
  private static Agenda agenda = new Agenda();
  public static void Main() {
    Thread.CurrentThread.CurrentCulture = new CultureInfo("pt-BR");
    int op = Menu();
    while (op != 0) {
      switch (op) {
        case 1 : Inserir(); break;
        case 2 : Excluir(); break;
        case 3 : Listar(); break;
        case 4 : Pesquisar(); break;
      }
      op = Menu();
    }
  }
  public static int Menu() {
    Console.Write("0-Fim, 1-Inserir, 2-Excluir, 3-Listar, 4-Pesquisar: ");
    return int.Parse(Console.ReadLine());
  }
  public static void Inserir() {
    Console.WriteLine("Inserir novo compromisso");
    Console.Write("Informe o assunto: ");
    string assunto = Console.ReadLine();
    Console.Write("Informe o local: ");
    string local = Console.ReadLine();
    Console.Write("Informe a data: ");
    DateTime data = DateTime.Parse(Console.ReadLine());
    Compromisso c = new Compromisso { Assunto = assunto, Local = local, Data = data};
    agenda.Inserir(c);
    Console.WriteLine("Compromisso inserido com sucesso");
  }
  public static void Excluir() {
    Console.WriteLine("Excluir um compromisso");
  }
  public static void Listar() {
    Console.WriteLine("Listar os compromissos");
    foreach (Compromisso c in agenda.Listar())
      Console.WriteLine(c);
  }
  public static void Pesquisar() {
    Console.WriteLine("Pesquisar compromissos");
  }
}
class Compromisso {
  public string Assunto { get; set; }
  public string Local { get; set; }
  public DateTime Data { get; set; }
  public override string ToString() {
    return $"{Assunto} - {Local} - {Data:dd/MM/yyyy hh:mm}";
  }
}
class Agenda {
  private Compromisso[] comps = new Compromisso[2];
  private int k; // número de compromissos inseridos
  public int Qtd { get { return k; } }
  public void Inserir(Compromisso c) {
    // Duplica o tamanho do vetor qdo tiver todo preenchido
    if (k == comps.Length) 
      Array.Resize(ref comps, 2 * comps.Length);
    comps[k] = c;
    k++;
  }
  public Compromisso[] Listar() {
    Compromisso[] aux = new Compromisso[k];
    Array.Copy(comps, aux, k);
    return aux;
  }
}