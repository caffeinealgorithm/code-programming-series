// YouTube: https://youtu.be/IOUI--CFDFs
// Publicação: https://caffeinealgorithm.com/blog/ref-e-out-em-csharp/

using System;

namespace Base {
  class RefEOut {
    public void Run() {
      int numero = 0;

      Console.WriteLine($"Número antes da função: {numero}");
      Out(out numero);
      Console.WriteLine($"Número depois da função: {numero}");
    }

    public void Normal(int numero) {
      numero = 1;
    }

    public void Ref(ref int numero) {
      numero = 2;
    }

    public void Out(out int numero) {
      numero = 3;
    }
  }
}

/*
  Número antes da função: 0
  Número depois da função: 3
*/
