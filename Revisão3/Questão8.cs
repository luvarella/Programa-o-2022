using System;
class Program{
  public static void Main() {

  Console.WriteLine("Digite uma frase:");
  string[] a = Console.ReadLine().Split();
    
  int x = a.Length;
  int y = 0;
    while (y < x) {
    string z = a[y];
      int last = z.Length - 1;
      Console.WriteLine(z[last]);
      y++;
    }
    Console.WriteLine();
}
}