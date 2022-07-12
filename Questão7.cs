using System;
public class Program{
  public static void Main {
    Console.WriteLine("Digite Uma Frase: ");
    string texto = Console.ReadLine();
    string[] t = texto.Split();
    int x = t.Length;
    int y = 0;
    int z = 0;
    while(y < x){
      while(z < x){
        Console.WriteLine(t[z] + " ");
        z++;
      }
      Console.WriteLine();
      y++;
      z = y;
    }
}
}