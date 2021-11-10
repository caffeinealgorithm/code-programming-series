// YouTube: https://youtu.be/mKXawyHLewc
// Publicação: https://caffeinealgorithm.com/blog/20211110/operadores-de-atribuicao-em-csharp/

using System;

namespace Base {
  class OperadoresDeAtribuicao {
    public void Run() {
      int x = 2;

      x += 3;
      Console.WriteLine("x = x + 3: " + x); // x = x + 3: 5

      x -= 2;
      Console.WriteLine("x = x - 2: " + x); // x = x - 2: 3

      x *= 2;
      Console.WriteLine("x = x * 2: " + x); // x = x * 2: 6

      x /= 2;
      Console.WriteLine("x = x / 2: " + x); // x = x / 2: 3

      x %= 3;
      Console.WriteLine("x = x % 3: " + x); // x = x % 3: 0
    }
  }
}
