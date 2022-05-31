using System;

class Program {
  public static void Main() {

  int a = int.Parse(Console.ReadLine());
  int b = int.Parse(Console.ReadLine());
  
  if (a > b)
  {
    Console.WriteLine($"Maior = {a}");
  }

  else if (a < b)
  {
    Console.WriteLine($"Maior = {b}");
  }

  else
  {
   Console.WriteLine("Números iguais");
  }
    
  }
}