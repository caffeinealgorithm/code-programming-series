// YouTube: https://youtu.be/Vg8cCo5bIic
// Publicação: https://caffeinealgorithm.com/blog/20211119/operadores-de-comparacao-em-csharp/

using System;

namespace Base {
  class OperadoresDeComparacao {
    public void Run() {
      int x = 10;
      int y = 20;

      if (x <= y || x == y) {
        Console.WriteLine("Esta condição é verdadeira.");
      }
      else {
        Console.WriteLine("Esta condição é falsa.");
      }
    }
  }
}

// Esta condição é verdadeira.
