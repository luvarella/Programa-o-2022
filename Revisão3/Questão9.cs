using System;
class Program{
  public static void Main() {

  Console.WriteLine("Digite uma frase:");
    
  string x = Console.ReadLine();
  int y = 0;
  foreach (char c in x){
    y++;
  }
  int z = 0;
  while (z < y){
    Console.WriteLine($"{z+1} - {x}");
      z++;
  }
}
}