using System;
class Program{
  public static void Main() {

  int i = 1;
    while(i <= 10){
      if(i % 2 == 0)Console.WriteLine($"-{i}");
      else Console.WriteLine(i + " ");
      i++;
    }
}
}