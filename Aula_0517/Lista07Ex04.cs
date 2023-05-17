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
    int n = 0;
    foreach (Compromisso c in agenda.Listar())
      Console.WriteLine($"{n++} - {c}");
    Console.Write("Informe o número do compromisso para remover: ");
    n = int.Parse(Console.ReadLine()); 
    Compromisso x = agenda.Listar()[n];
    agenda.Excluir(x);
    Console.WriteLine("Compromisso excluído com sucesso");    
  }
  public static void Listar() {
    Console.WriteLine("Listar os compromissos");
    foreach (Compromisso c in agenda.Listar())
      Console.WriteLine(c);
  }
  public static void Pesquisar() {
    Console.WriteLine("Pesquisar compromissos");
    Console.Write("Informe o mês: ");
    int mes = int.Parse(Console.ReadLine());
    Console.Write("Informe o ano: ");
    int ano = int.Parse(Console.ReadLine());
    foreach (Compromisso c in agenda.Pesquisar(mes, ano))
      Console.WriteLine(c);    
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
  public void Excluir(Compromisso c) {
    k--;
    Compromisso[] novo = new Compromisso[k];
    int n = 0;
    foreach(Compromisso x in Listar())
      if (x != c) novo[n++] = x;
    comps = novo;
  }
  public Compromisso[] Listar() {
    Compromisso[] aux = new Compromisso[k];
    Array.Copy(comps, aux, k);
    return aux;
  }
  public Compromisso[] Pesquisar(int mes, int ano) {
    int n = 0;
    foreach(Compromisso c in Listar()) 
      if (c.Data.Year == ano && c.Data.Month == mes) n++;
    Compromisso[] aux = new Compromisso[n];
    n = 0;
    foreach(Compromisso c in Listar()) 
      if (c.Data.Year == ano && c.Data.Month == mes) aux[n++] = c;
    return aux;
  }
}