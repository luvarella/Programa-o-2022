using System;
class Program{
  public static void Main() {

  Console.WriteLine("Digite uma frase:");
  string[] frase = Console.ReadLine().Split();
    
  int x = frase.Length;
  int y = 0;
    while (y < x) {
    string z = frase[y];
      int last = z.Length - 1;
      Console.Write(z[last]);
      y++;
    }
    Console.WriteLine();
}
}