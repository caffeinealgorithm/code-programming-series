// YouTube: https://youtu.be/b4bLQ0qf5gY
// Publicação: https://caffeinealgorithm.com/blog/break-e-continue-em-csharp/

using System;
using System.Collections.Generic;

namespace Base {
  class BreakEContinue {
    public void Run() {
      int contador = 0;
      List<string> animais = new List<string>() {
        "Cão",
        "Gato",
        "Galinha",
        "Coelho",
        "Leão"
      };

      foreach (string animal in animais) {
        Console.WriteLine($"Animal: {animal}");

        if (animal == "Galinha")
          break;
      }

      while (contador < 10) {
        contador++;

        if (contador == 5)
          continue;

        Console.WriteLine($"Contador: {contador}");
      }
    }
  }
}

/*
  Animal: Cão
  Animal: Gato
  Animal: Galinha
  Contador: 1
  Contador: 2
  Contador: 3
  Contador: 4
  Contador: 6
  Contador: 7
  Contador: 8
  Contador: 9
  Contador: 10
*/
