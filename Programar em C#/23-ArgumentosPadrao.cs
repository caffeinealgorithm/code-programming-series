// YouTube: https://youtu.be/9Dv8IR1Hy5U
// Publicação: https://caffeinealgorithm.com/blog/20211206/argumentos-padrao-em-csharp/

using System;

namespace Base {
  class ArgumentosPadrao {
    public void Run() {
      EstadoDaPorta(false);
    }

    public void EstadoDaPorta(bool estado = true) {
      if (estado)
        Console.WriteLine("A porta está aberta.");
      else {
        Console.WriteLine("A porta está fechada.");
      }
    }
  }
}

// A porta está fechada.
