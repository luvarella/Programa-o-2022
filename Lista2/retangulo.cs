using System;
class Program {
  public static void Main(){
    
    Console.WriteLine("Digite a base e a altura do retângulo:");
    double a = Double.Parse(Console.ReadLine());
    double b = Double.Parse(Console.ReadLine());
    double area = a*b;
    double p = a*2 + b*2;
    Console.WriteLine(a, b, area, p);3
      

  }
}