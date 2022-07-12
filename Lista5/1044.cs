using System;
class Program{
  public static void Main() {

    string[] valores = Console.ReadLine().Split(); // string que irá converter a entrada com mais de um valor (split)
    int a = int.Parse(valores[0]); // valor a
    int b = int.Parse(valores[1]); // valor b
      
    int multiploa = a % b;
    int multiplob = b % a;

      if (multiploa == 0 || multiplob == 0)
        {
            Console.WriteLine("Sao Multiplos");
        }
        else
        {
            Console.WriteLine("Nao sao Multiplos");
        }
	} 
}