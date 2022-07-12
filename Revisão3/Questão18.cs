using System;
class Program {
  public static void Main(){
    
  Console.WriteLine("Digite uma sequência de números separados por vírgula:");
    
  string a = Console.ReadLine();
  string[] b = a.Split(',');
    
  int x = b.Length;
  int y = 0;
  int z = 0;
    while(y < x){
      z += int.Parse(b[y]);
      y++;
    }
    Console.WriteLine(z);
}
}