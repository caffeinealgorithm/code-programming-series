// YouTube: https://youtu.be/seMBMqxe8KA
// Publicação: https://caffeinealgorithm.com/blog/ciclo-foreach-em-csharp/

using System;
using System.Collections.Generic;

namespace Base {
  class CicloForeach {
    public void Run() {
      string organizacao = "Caffeine Algorithm";
      List<string> paises = new List<string>() {
        "Portugal",
        "Brasil",
        "Espanha",
        "França",
        "Itália",
        "Austrália",
        "Índia"
      };

      /*
        foreach (char carater in organizacao) {
          Console.WriteLine($"Carater: {carater}");
        }
      */

      foreach (string pais in paises) {
        Console.WriteLine($"País: {pais}");
      }
    }
  }
}

/*
  País: Portugal
  País: Brasil
  País: Espanha
  País: França
  País: Itália
  País: Austrália
  País: Índia
*/
