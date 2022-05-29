using System;

namespace jogo_RPG_DIO {
  class Program {
    static void Main(string[] args) {
      Knight bub = new Knight("bub", 54, "Knight");
      Ranger gab = new Ninja("gab", 69, "Ranger");
      Wizard kassandra = new Wizard("kassandra", 117, "Wizard");
     

      Console.WriteLine(bub.Attack());
      Console.WriteLine(gab.Attack());
      Console.WriteLine(kassandra.Attack());
      
    }
  }
}
