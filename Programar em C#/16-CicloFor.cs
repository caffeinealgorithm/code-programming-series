// YouTube: https://youtu.be/9h8vh0r3fwk
// Publicação: https://caffeinealgorithm.com/blog/20211124/ciclo-for-em-csharp/

using System;

namespace Base {
  class CicloFor {
    public void Run() {
      string[] materialEscolar = new string[6] {
        "Mochila", // 0
        "Estojo", // 1
        "Lápis", // 2
        "Borracha", // 3
        "Afia", // 4
        "Tesoura" // 5
      };

      /*
        Console.WriteLine(materialEscolar[0]);
        Console.WriteLine(materialEscolar[1]);
      */

      for (int indice = 0; indice < materialEscolar.Length; indice++) {
        Console.WriteLine($"materialEscolar[{indice}]: {materialEscolar[indice]}");
      }
    }
  }
}

/*
  materialEscolar[0]: Mochila
  materialEscolar[1]: Estojo
  materialEscolar[2]: Lápis
  materialEscolar[3]: Borracha
  materialEscolar[4]: Afia
  materialEscolar[5]: Tesoura
*/
