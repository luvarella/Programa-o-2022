using System;
class Program {
  public static void Main(){
    
  Console.WriteLine("Digite uma frase:");
    
  string texto = Console.ReadLine();
  int x = texto.Length;
  int y = 1;
    
  string z = "";
    while(x >= y){
      z += texto.Substring(x - 1);
      texto = texto.Remove(x - 1);
      x--;
    }
    string[] a = z.Split();
    x = a.Length;
    y = 1;
    while(x >= y){
      Console.WriteLine(a[x - 1]);
      x--;
    }
}
}