using System;
class Program {
  public static void Main(){
    
  int x = 1;
  int y = 1;
    while(x <= 10){
      Console.WriteLine($"Tabuada de {x}");
    while(y <=10){
      Console.WriteLine($"{x} x {y} = {x * y}");
      y++;}
      Console.WriteLine();
      y = 1;
      x++;
  }
}
}