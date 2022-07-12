using System;
public class Program{
  public static void Main {
    int x = 1;
    while(x <= 30){
      if(x % 3 == 0) Console.WriteLine($"{x} {x * 3 - 3} ");
      else Console.WriteLine(x + " ");
      x++;
    }
}
}