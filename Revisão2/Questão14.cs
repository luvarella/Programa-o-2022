using System;
using System.Collections.Generic;
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine("digite três valores");
      string A = Console.ReadLine();
      double a = double.Parse(A);
      string B = Console.ReadLine();
      double b = double.Parse(B);
      string C = Console.ReadLine();
      double c = double.Parse(C);
			if (a + b > c || a + c > b || b + c > a){
        if(a == b || c){
          Console.WriteLine("equilatero");
        } else if(a == b || a == c || b == c){
          Console.WriteLine("isosceles");
        } else {
          Console.WriteLine("escaleno");
          }
        }
      else{
        Console.WriteLine("Esses valores não formam um triangulo");
    }
		}
	}