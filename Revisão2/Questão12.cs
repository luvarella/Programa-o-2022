using System;

class MainClass {
	public static void Main (string[] args)
		{
    
			Console.WriteLine ("Digite dois valores inteiros separados por um operador +, -, * ou /");
			String calc = Console.ReadLine ();
			char opr;
			if (calc.Contains ("+")) {
				opr = '+';
			} else if (calc.Contains ("-")) {
				opr = '-';
			} else if (calc.Contains ("*")) {
				opr = '*';
			} else if (calc.Contains ("/")) {
				opr = '/';
			} else {
				Console.WriteLine ("Expressão incorreta.");
				return;
			}
			int p1, p2;
			String[] partes = calc.Split (opr);
			p1 = int.Parse (partes [0]);
			p2 = int.Parse (partes [1]);
			int resultado;
			switch (opr) {
				case '+': 
					resultado = p1 + p2;
					break;
				case '-': 
					resultado = p1 - p2;
					break;
				case '*': 
					resultado = p1 * p2;
					break;
				case '/': 
					resultado = p1 / p2;
					break;
				default:
					resultado = 0;
					break;
			}
			Console.WriteLine ("O resultado da operação é " + resultado);
    
		}
	}