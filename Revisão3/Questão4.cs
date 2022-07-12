using System;
class Program{
  public static void Main() {

  int i = 1;
    while(i <= 30){
      if(i % 3 == 0)Console.WriteLine($"-{i}");
      else Console.WriteLine(i + " ");
      i++;
    }
}
}