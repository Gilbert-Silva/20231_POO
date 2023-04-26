using System;

class Program {
  public static void Main() {
    /*
    No a = new No("Esta");
    No b = new No("é");
    No c = new No("uma");
    No d = new No("lista");
    Console.WriteLine(a);
    Console.WriteLine(b);
    Console.WriteLine(c);
    Console.WriteLine(d);
    */
    Lista x = new Lista();
    x.Append("Esta");
    x.Append("é");
    x.Append("uma");
    x.Append("lista");
    Console.WriteLine(x);  
  }
}

class Lista {
  private No inicio, fim;
  public Lista() {
    inicio = null;
    fim = null;
  }
  public void Append(string texto) {
    No novo = new No(texto);
    if (inicio == null) {
      // inserindo o primeiro elemento
      inicio = novo;
      fim = novo;
    }
    else 
    {
      // inserindo a partir do segundo elemento
      fim.SetProx(novo);
      fim = novo;
    }
  }
  public override string ToString() {
    string r = "[";
    No aux = inicio;
    while (aux != null) {
      r += aux.ToString() + ", ";
      aux = aux.GetProx();
    }
    // Remove , e espaço após último elemento
    if (r.Length > 1) r = r.Remove(r.Length-2, 2);
    r += "]";
    return r;
  }
}

class No {
  private string texto;
  private No prox;
  public No(string texto) {
    this.texto = texto;
    this.prox = null;
  }
  public void SetTexto(string texto) {
    this.texto = texto;
  }
  public void SetProx(No prox) {
    this.prox = prox;
  }
  public string GetTexto() {
    return texto;
  }
  public No GetProx() {
    return prox;
  }
  public override string ToString() {
    return $"'{texto}'";
  }
  
}