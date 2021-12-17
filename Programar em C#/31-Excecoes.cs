// YouTube: https://youtu.be/Gw6RYAu0yOo
// Publicação: https://caffeinealgorithm.com/blog/20211217/excecoes-em-csharp/

using System;

namespace Base {
  class Excecoes {
    public void Run() {
      int[] numeros = new int[5] {
        1, 2, 3, 4, 5
      };

      try {
        Console.WriteLine($"Conteúdo do elemento: {numeros[4]}");
      }
      catch (Exception excecao) {
        // Console.WriteLine("O código presente no try não está a funcionar corretamente.");
        Console.WriteLine(excecao);
      }
      finally {
        Console.WriteLine("Eu faço parte do finally e sou executado caso haja alguma exceção ou não.");
      }
    }
  }
}
