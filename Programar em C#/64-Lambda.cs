// YouTube: https://youtu.be/BrpYkREnwfM
// Publicação: https://caffeinealgorithm.com/blog/lambda-em-csharp/

using System;
using System.Linq;

namespace Base {
  class Lambda {
    private int[] numeros = new int[] {
      1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11
    };

    public void Run() {
      /*
        Console.WriteLine($"Total de números pares: {ContarNumerosPares()}");
        Console.WriteLine($"Total de números ímpares: {ContarNumerosImpares()}");
      */

      Console.WriteLine($"Total de números pares: {numeros.Count(numero => numero % 2 == 0)}");
      Console.WriteLine($"Total de números ímpares: {numeros.Count(numero => numero % 2 != 0)}");
    }

    private int ContarNumerosPares() {
      var contador = 0;

      foreach (var numero in numeros) {
        if (numero % 2 == 0)
          contador++;
      }

      return contador;
    }

    private int ContarNumerosImpares() {
      var contador = 0;

      foreach (var numero in numeros) {
        if (numero % 2 != 0)
          contador++;
      }

      return contador;
    }
  }
}

/*
  Total de números pares: 5
  Total de números ímpares: 6
*/
