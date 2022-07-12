using System;
class Program{
  public static void Main() {

    string[] valores = Console.ReadLine().Split(); // string que irá converter a entrada com mais de um valor (split)
    double a = double.Parse(valores[0]); // valor a
    double b = double.Parse(valores[1]); // valor b
    double c = double.Parse(valores[2]); // valor c

    double delta = ((b*b) - 4 * a * c); // fórmula de delta

    if ((delta) >= 0 && (2 * a) != 0){
	  double x1 = (-b + Math.Sqrt(delta)) / (2 * a); // fórmula de bhaskara
    double x2 = (-b - Math.Sqrt(delta)) / (2 * a); // fórmula de bhaskara
	   
    Console.WriteLine($"R1 = {x1:0.00000}");
    Console.WriteLine($"R2 = {x2:0.00000}");}

    else{
         Console.WriteLine("Impossivel calcular");
      }
	} 
}