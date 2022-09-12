// YouTube: https://youtu.be/Us3VJyBFbbY
// Publicação: https://caffeinealgorithm.com/blog/arrays-em-csharp/

using System;

namespace Base {
  class Arrays {
    public void Run() {
      /*
        string[] cores = new string[5];

        cores[0] = "Azul";
        cores[1] = "Verde";
        cores[2] = "Amarelo";
        cores[3] = "Vermelho";
        cores[4] = "Laranja";
      */

      string[] cores = new string[] {
        "Azul",
        "Verde",
        "Amarelo",
        "Vermelho",
        "Laranja"
      };

      Console.WriteLine($"Número de cores: {cores.Length}"); // Número de cores: 5
      Console.WriteLine($"Primeira cor: {cores[0]}"); // Primeira cor: Azul
      Console.WriteLine($"Última cor: {cores[cores.Length - 1]}"); // Última cor: Laranja
    }
  }
}
