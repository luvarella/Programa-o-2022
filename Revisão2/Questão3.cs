using System;

class MainClass {
	public static void Main (string[] args) {
      
		double par1 = 0, par2 = 0, par3 = 0, par4 = 0, impar1 = 0, impar2 = 0, impar3 = 0, impar4 = 0, resultado_par  = 0, resultado_impar = 0;

      
		Console.WriteLine ("Digite quatro valores inteiros");

      
		string N1 = Console.ReadLine();
    double n1 = double.Parse(N1);
		string N2 = Console.ReadLine();
    double n2 = double.Parse(N2);
		string N3 = Console.ReadLine();
    double n3 = double.Parse(N3);
		string N4 = Console.ReadLine();
    double n4 = double.Parse(N4);

		if (n1 % 2 ==0)
    {
    par1 += n1;
    } 
    else 
    {
    impar1 += n1;
    }
		if (n2 % 2 ==0)
    {
    par2 += n2;
    } 
    else 
    {
    impar2 += n2;
    }
		if (n3 % 2 ==0)
    {
    par3 += n3;
    } 
    else 
    {
    impar3 += n3;
    }
		if (n4 % 2 ==0)
    {
    par4 += n4;
    } 
    else
    {
    impar4 += n4;
    }
      
		resultado_par += par1 + par2 + par3 + par4;
    resultado_impar += impar1 + impar2 + impar3 + impar4;

    Console.WriteLine ("Soma dos pares = " + resultado_par);
    Console.WriteLine ("Soma dos ímpares = " + resultado_impar);
    
		}
	}