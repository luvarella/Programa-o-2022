using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Equacao2grau
{
    class Class1
    {
        public static void Main(String[] args)
        {
            double a, b, c;
            double delta;

            Console.WriteLine("Digite os coeficientes a, b, e c de uma equação do II grau");
            a = double.Parse(Console.ReadLine());
            b = double.Parse(Console.ReadLine());
            c = double.Parse(Console.ReadLine());

                delta = Math.Pow(b, 2) - (4 * a * c); 
                 if (delta < 0)
                  {
                    Console.WriteLine("Impossível calcular");
                  }
                 else
                 {
                  double baskara1 = -b + Math.Sqrt(delta) / (2 * a);
                  double baskara2 = -b - Math.Sqrt(delta) / (2 * a);
                   Console.WriteLine($"As raízes são: {baskara1} e {baskara2}.");
                }
            }

                        
           
        }
}