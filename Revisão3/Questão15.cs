using System;
class Program {
  public static void Main(){
    
  Console.WriteLine("Digite uma frase:");
    
  string[] texto = Console.ReadLine().Split();
  string a = "";
    
  foreach (string b in texto){
    int x = b.Length;
    string y = x.ToString();
    a += y;
    }
    Console.WriteLine(a);
}
}