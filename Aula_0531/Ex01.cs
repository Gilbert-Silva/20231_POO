using System;
class Program {
  public static void Main() {
    Pilha<string> x = new Pilha<string>();
    //x.Pop();
    x.Push("C#");
    Console.WriteLine(x.Peek());
    x.Push("Python");
    x.Push("Assembly");
    while (x.Count > 0)
      Console.WriteLine(x.Pop());
  }
}
class Pilha<T> {
  private T[] objs = new T[1];
  private int k;
  public int Count { get { return k; } }
  public void Clear() {
    k = 0;
  }
  public T Peek() {
    if (k == 0)
      throw new InvalidOperationException();
    return objs[k-1]; 
  }  
  public T Pop() {
    if (k == 0)
      throw new InvalidOperationException();
    k--;
    return objs[k]; 
  }
  public void Push(T obj) {
    if (k == objs.Length)
      Array.Resize(ref objs, 2 * objs.Length);
    objs[k] = obj;
    k++;
  }
}