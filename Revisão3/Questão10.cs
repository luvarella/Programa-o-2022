using System;
class Program{
  public static void Main() {

  Console.WriteLine("Digite uma frase:");
  string texto = Console.ReadLine();
    
  int x = texto.Length;
  int y = 1;
  string z;
    while(y <= x){
    z = texto.Substring(1) + texto.Substring(0, 1);
    texto = z;
    Console.WriteLine(texto);
    y++;
    }
}
}