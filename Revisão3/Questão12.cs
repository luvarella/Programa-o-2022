using System;
class Program{
  public static void Main() {

  Console.WriteLine("Digite uma frase:");
    
  string texto = Console.ReadLine();
  string[] x = texto.Split();
  int y = x.Length;
  Console.WriteLine(y);
}
}