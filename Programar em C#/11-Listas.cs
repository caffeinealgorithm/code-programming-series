// YouTube: https://youtu.be/Eov-gcwg9zc
// Publicação: https://caffeinealgorithm.com/blog/listas-em-csharp/

using System;
using System.Collections.Generic;
using System.Linq;

namespace Base {
  class Listas {
    public void Run() {
      List<string> cores = new List<string>();

      cores.Add("Azul");
      cores.Add("Verde");
      cores.Add("Amarelo");
      cores.Add("Vermelho");
      cores.Add("Laranja");

      cores.Remove("Laranja");
      cores.Reverse();
      cores.Sort();
      // cores.Clear();

      Console.WriteLine($"Número de cores: {cores.Count}"); // Número de cores: 4
      Console.WriteLine($"Primeira cor: {cores.First()}"); // Primeira cor: Amarelo
      Console.WriteLine($"Última cor: {cores.Last()}"); // Última cor: Vermelho
    }
  }
}
