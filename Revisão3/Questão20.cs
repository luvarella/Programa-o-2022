using System;
class Program {
  public static void Main(){
    
  int x = 1;
  int y = 1;
    while(x <= 10){
      Console.WriteLine(x + " ");
    while(y <= x){
      if(y % 2 == 0) Console.WriteLine(y + " ");
      y++;}
      
      Console.WriteLine();
      y = 1;
      x++;
    }
}
}