// YouTube: https://youtu.be/yXu3nkuCn1I
// Publicação: https://caffeinealgorithm.com/blog/argumentos-chave-em-csharp/

using System;

namespace Base {
  class ArgumentosChave {
    public void Run() {
      ImprimirABC(c: 1, a: 2, b: 3);
    }

    public void ImprimirABC(int a, int b, int c) {
      Console.WriteLine($"Valor de a: {a}");
      Console.WriteLine($"Valor de b: {b}");
      Console.WriteLine($"Valor de c: {c}");
    }
  }
}

/*
  Valor de a: 2
  Valor de b: 3
  Valor de c: 1
*/
