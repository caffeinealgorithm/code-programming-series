// YouTube: https://youtu.be/lbgVj7NBFAg
// Publicação: https://caffeinealgorithm.com/blog/goto-e-region-endregion-em-csharp/

#region Bibliotecas
using System;
#endregion

namespace Base {
  class GotoERegionEndregion {
    #region Método Run()
    public void Run() {
      Console.WriteLine($"Resultado do método TestarGoto(): {TestarGoto()}");
    }
    #endregion

    #region Método TestarGoto()
    private int TestarGoto() {
      var numero = 0;

      for (int i = 1; i <= 10; i++) {
        for (int j = i; j <= 10; j++) {
          for (int k = 0; k <= 10; k++) {
            if (j == 5 && k == 5)
              goto PrimeiroCiclo;
          }

          numero++;
        }

        PrimeiroCiclo:
          continue;
      }

      return numero;
    }
    #endregion
  }
}

// Resultado do método TestarGoto(): 25
