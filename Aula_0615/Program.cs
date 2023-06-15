using System;

class Program {
  public static void Main() {
    Console.WriteLine("Bem-vindo(a) ao IF Shop!");
    int op = MenuAdmin();
    while (op != 0) {
      switch(op) {
      case 1 : CategoriaListar(); break;
      case 2 : CategoriaInserir(); break;
      case 3 : CategoriaAtualizar(); break;
      case 4 : CategoriaExcluir(); break;
      }
      op = MenuAdmin();
    }
    Console.WriteLine("Bye!");
  }
  public static int MenuAdmin() {
    Console.WriteLine("Admin logado");
    Console.WriteLine("Cadastro de Categorias");
    Console.WriteLine("1 - Listar");
    Console.WriteLine("2 - Inserir");
    Console.WriteLine("3 - Atualizar");
    Console.WriteLine("4 - Excluir");
    Console.WriteLine("0 - Fim");
    Console.Write("Opção: ");
    return int.Parse(Console.ReadLine());
  }
  public static void CategoriaListar() {
    Console.WriteLine("Listagem de categorias");
    foreach (Categoria c in NCategoria.Listar())
      Console.WriteLine(c);
    Console.WriteLine();
  }
  public static void CategoriaInserir() {
    Console.WriteLine("Inserção de categoria");
    Console.Write("Informe a descrição: ");
    string s = Console.ReadLine();
    Categoria c = new Categoria { Descricao = s };
    NCategoria.Inserir(c);
    Console.WriteLine("Categoria inserida com sucesso");
  }
  public static void CategoriaAtualizar() {
    
  }
  public static void CategoriaExcluir() {
    
  }
}