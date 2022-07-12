using System;
class Program{
  public static void Main() {

  int a1 = int.Parse(Console.ReadLine());
  int a2 = int.Parse(Console.ReadLine());
  int a3 = int.Parse(Console.ReadLine());

    int t1 = ((a1 * 0) + (a2 * 2) + (a3 * 4));
    int t2 = ((a1 * 2) + (a2 * 0) + (a3 * 2));
    int t3 = ((a1 * 4) + (a2 * 2) + (a3 * 0));

  if(t1<=t2 && t1<=t3)Console.WriteLine($"{t1}");
  if(t2<=t1 && t2<=t3)Console.WriteLine($"{t2}");
  if(t3<=t1 && t3<=t2)Console.WriteLine($"{t3}");

  }
}