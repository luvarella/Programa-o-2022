using System;
class Program{
  public static void Main() {

  Console.WriteLine("Digite uma frase:");
  string texto = Console.ReadLine();
    
  int x = texto.Length;
  int y = 0;
  int s = 0;
  while(y < x){
    if(texto[y] == '1') 
    s += 1;
    if(texto[y] == '2') 
    s += 2;
    if(texto[y] == '3') 
    s += 3;
    if(texto[y] == '4') 
    s += 4;
    if(texto[y] == '5') 
    s += 5;
    if(texto[y] == '6') 
    s += 6;
    if(texto[y] == '7') 
    s += 7;
    if(texto[y] == '8') 
    s += 8;
    if(texto[y] == '9') 
    s += 9;
    y++;
    }
    Console.WriteLine(s);
}
}