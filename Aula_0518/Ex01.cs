using System;
using System.Collections;

class Program {
  public static void Main() {
    int[] v = { 10, 2, 6, 3, 5, 12 };
    Array.Sort(v);
    foreach(int i in v) Console.WriteLine(i);

    Produto[] w = {
      new Produto { Descricao = "Feijão", Preco = 5.5 },
      new Produto { Descricao = "Sorvete", Preco = 15.5 },
      new Produto { Descricao = "Arroz", Preco = 6.5 },
      new Produto { Descricao = "Café", Preco = 7.5 },
      new Produto { Descricao = "Refri", Preco = 2.5 }
    };
    Array.Sort(w);
    foreach(Produto p in w) Console.WriteLine(p);
    foreach(char c in "Teste")
      Console.WriteLine(c);

    Console.WriteLine(1.CompareTo(2));
    Console.WriteLine(1.CompareTo(1));
    Console.WriteLine(2.CompareTo(1));
    Console.WriteLine("Java".CompareTo("C#"));
    Console.WriteLine("C#".CompareTo("C#"));
    Console.WriteLine("C#".CompareTo("Java"));

    Produto a = new Produto { Descricao = "Feijão", Preco = 5.5 };
    Produto b = new Produto { Descricao = "Sorvete", Preco = 15.5 };
    Console.WriteLine(a.CompareTo(b));

    Produto p1 = new Produto { Descricao = "Mouse", Preco = 50.5 };
    Produto p2 = new Produto { Descricao = "Teclado", Preco = 150.5 };
    IComparable p3 = new Produto { Descricao = "Monitor", Preco = 750.5 };
    
    Console.WriteLine(p1);
    Console.WriteLine(p1.Preco);
    Console.WriteLine(p2);
    //Console.WriteLine(p2.Preco);
    Console.WriteLine(p3);
    Console.WriteLine(p3.CompareTo(p1));  

    ComparaPrecoProduto comparador = new ComparaPrecoProduto();
    Console.WriteLine(comparador.Compare(p1, p2));
    
    //Array.Sort(w, comparador);
    Array.Sort(w, new ComparaPrecoProduto());
    foreach(Produto p in w) Console.WriteLine(p);
    
  }
}
class ComparaPrecoProduto : IComparer {
  public int Compare(object obj1, object obj2) {
    Produto x = (Produto) obj1;  
    Produto y = (Produto) obj2;
    return x.Preco.CompareTo(y.Preco);
  }
}

class Produto : IComparable {
  public string Descricao {get;set;}
  public double Preco {get;set;}
  public int CompareTo (object obj) {
    //this.Preco // Preço de a   
    //obj.Preco  // Preço de b
    Produto x = (Produto) obj;  // Type-cast - pode dar erro de execução
    //Produto x = obj as Produto; // Type-cast - pode retornar um null
    //if (this.preco < x.preco) return -1;
    //if (this.preco == x.preco) return 0;
    //if (this.preco > x.preco) return 1;    
    return this.Descricao.CompareTo(x.Descricao);
  }
  public override string ToString() {
    return $"{Descricao} - {Preco:0.00}";
  }
}