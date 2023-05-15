using System;
class Program {
  public static void Main() {
    int[,] v = {{ 1, 2, 3, 4 }, { 5, 6, 7, 8 }, { 9, 0, 1, 2 }};
    Console.WriteLine(v.Length);
    Console.WriteLine(v.Rank);
    Console.WriteLine(v.GetLength(0));
    Console.WriteLine(v.GetLength(1));
    foreach (int k in v)
      Console.WriteLine(k);
    for(int i = 0; i < v.GetLength(0); i++) {
      for(int j = 0; j < v.GetLength(1); j++)
        Console.Write(v[i,j] + "  ");
      Console.WriteLine();
    }
  }
}