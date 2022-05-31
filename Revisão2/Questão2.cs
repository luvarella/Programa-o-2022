using System;

class Program{
  public static void Main() {

  Console.WriteLine("Digite quatro valores inteiros:");
  int v1 = int.Parse(Console.ReadLine());
  int v2 = int.Parse(Console.ReadLine());
  int v3 = int.Parse(Console.ReadLine());
  int v4 = int.Parse(Console.ReadLine());
  int m = (v1+v2+v3+v4) / 4;
  Console.WriteLine($"Média = {m}.");

  Console.WriteLine("Números menores que a média:");
    
  if (v1 < m)
  {
    Console.WriteLine(v1);
  }
    
  if (v2 < m)
  {
    Console.WriteLine(v2);
  }
    
  if (v3 < m)
  {
    Console.WriteLine(v3);
  }
    
    if (v4 < m)
  {
    Console.WriteLine(v4);
  }

  Console.WriteLine("Números maiores ou iguais à média:");
    
  if (v1 >= m)
  {
    Console.WriteLine(v1);
  }
  
  if (v2 >= m)
  {
    Console.WriteLine(v2);
  }
  
  if (v3 >= m)
  {
    Console.WriteLine(v3);
  }
    
  if (v4 >= m)
  {
    Console.WriteLine(v4);
  }
    
  }
}