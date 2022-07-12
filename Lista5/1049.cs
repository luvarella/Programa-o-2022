using System;
class Program{
  public static void Main() {

  string vertebra = Console.ReadLine();
  string classe = Console.ReadLine();
  string alimentacao = Console.ReadLine();

      if (vertebra == "vertebrado" && classe == "ave" && alimentacao == "carnivoro")
      Console.WriteLine("aguia");
    
      if (vertebra == "vertebrado" && classe == "ave" && alimentacao == "onivoro")
      Console.WriteLine("pomba");
    
      if (vertebra == "vertebrado" && classe == "mamifero" && alimentacao == "onivoro")
      Console.WriteLine("homem");
    
      if (vertebra == "vertebrado" && classe == "mamifero" && alimentacao == "herbivoro")
      Console.WriteLine("vaca");
    
      if (vertebra == "invertebrado" && classe == "inseto" && alimentacao == "hematofago")
      Console.WriteLine("pulga");
    
      if (vertebra == "invertebrado" && classe == "inseto" && alimentacao == "herbivoro")
      Console.WriteLine("lagarta");
    
      if (vertebra == "invertebrado" && classe == "anelideo" && alimentacao == "hematofago")
      Console.WriteLine("sanguessuga");
    
      if (vertebra == "invertebrado" && classe == "anelideo" && alimentacao == "onivoro")
      Console.WriteLine("minhoca");
  }
}