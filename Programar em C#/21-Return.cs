// YouTube: https://youtu.be/-WPMAO60yQ8
// Publicação: https://caffeinealgorithm.com/blog/20211202/return-em-csharp/

using System;

namespace Base {
  class Return {
    public void Run() {
      Console.WriteLine($"Resultado da adição: {Adicao()}");
    }

    public int Adicao() {
      int resultado = 0;

      for (int valor = 1; valor <= 10; valor++)
        resultado += valor;

      return resultado;
    }
  }
}

// Resultado da adição: 55
