// YouTube: https://youtu.be/H1D_3_XgI9E
// Publicação: https://caffeinealgorithm.com/blog/variaveis-em-csharp/

using System;

namespace Base {
  class Variaveis {
    public void Run() {
      int inteiro = 10;
      double _double = 10.5;
      string _string = "Eu sou uma string.";
      char carater = 'c';
      bool booleano = true;

      Console.WriteLine("inteiro: " + inteiro); // inteiro: 10
      Console.WriteLine("double: " + _double); // double: 10,5
      Console.WriteLine("string: " + _string); // string: Eu sou uma string.
      Console.WriteLine("carater: " + carater); // carater: c
      Console.WriteLine("booleano: " + booleano); // booleano: True
    }
  }
}
