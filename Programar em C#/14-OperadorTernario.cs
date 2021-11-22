// YouTube: https://youtu.be/KMHQmYq6Kms
// Publicação: https://caffeinealgorithm.com/blog/20211122/operador-ternario-em-csharp/

using System;

namespace Base {
  class OperadorTernario {
    // (condição) ? condição for verdadeira : condição for falsa

    public void Run() {
      int idade = 25;
      bool eMaiorDeIdade;

      /*
        if (idade >= 18) {
          eMaiorDeIdade = true;
        }
        else {
          eMaiorDeIdade = false;
        }
      */

      eMaiorDeIdade = (idade >= 18) ? true : false;

      Console.WriteLine($"É maior de idade: {eMaiorDeIdade}");
    }
  }
}

// É maior de idade: True
