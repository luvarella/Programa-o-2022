using System;
class Program {
  public static void Main(){
    
  Console.WriteLine("Digite uma frase:");
    
  string x = Console.ReadLine().ToLower();
  int a = 0; 
  int b = 0;
  int c = 0;
  int d = 0;
  int e = 0;
    
  foreach (char y in x){
    if(y == 'a'){
    a += 1;}
    if(y == 'e'){
    b += 1;}
    if(y == 'i'){
    c += 1;}
    if(y == 'o'){
    d += 1;}
    if(y == 'u'){
    e += 1;}
  }
    
  Console.WriteLine($"A - {a}");
  Console.WriteLine($"E - {b}");
  Console.WriteLine($"I - {c}");
  Console.WriteLine($"O - {d}");
  Console.WriteLine($"U - {e}");
}
}