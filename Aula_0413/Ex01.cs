using System;
class Program {
  public static void Main() {
    string s = Console.ReadLine();
    while (s != "*") {
      s = s.ToLower();    // passa para minúsculo
      char x = s[0];      // primeira letra
      bool bugou = false; // bugou é true qdo encontra letra diferente
      for (int i = 0; i < s.Length; i++) // for i in range(len(s))
        if (s[i] == ' ' && s[i+1] != x)  // letra após espaço é diferente
        { 
          bugou = true;
          break;
        }
      if (bugou == true) Console.WriteLine("N");
      else Console.WriteLine("Y");
      s = Console.ReadLine();
    }
  }
}
//0123456789012345678901234567
//Flowers Flourish from France // Length=28  0..27