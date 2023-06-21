using System;

class Program {
  public static void Main() {
    Console.WriteLine("Informe um valor inteiro");
    Console.WriteLine(1.0/0);
    int[] v = { 1, 2, 3 };
    Console.WriteLine(v[0]);
    //Console.WriteLine(v[4]);


    
    
    
    
    int n = 0;
    try {
      object x = new Aluno();
      Professor y = x as Professor;
      // Console.WriteLine(y.ToString());
      Professor z = (Professor) x;
      n = int.Parse(Console.ReadLine());
      Console.WriteLine(n + 1);
      Console.WriteLine(1/n);
    }
    catch (FormatException) {
      Console.WriteLine("Valor informado não é um número");
    }
    catch (OverflowException) {
      Console.WriteLine("Valor informado é muito grande ou muito pequeno");
    }
    catch (Exception erro) {
      Console.WriteLine("Erro = " + erro.Message);
      Console.WriteLine(erro.GetType());
    }
  }
}

class Aluno {}

class Professor {}