using System;
class Program {
  public static void Main(){
    
  Console.WriteLine("Digite uma frase:");
    
  string a = Console.ReadLine();
  string[] b = a.Split();
    foreach (string c in b){
      int x = 0;
        foreach (char y in c){
        if(y == 'a' || y == 'e'|| y == 'i'|| y == 'o'|| y == 'u') x += 1;}
      
      int z = 0;
        while (z < x){
        Console.WriteLine(c + " ");
        z++;}
  }
  Console.WriteLine();
}
}