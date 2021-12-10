// YouTube: https://youtu.be/nRnTx4JWWm4
// Publicação: https://caffeinealgorithm.com/blog/20211210/variaveis-globais-e-locais-em-csharp/

using System;

namespace Base {
  class VariaveisGlobaisELocais {
    string acesso = "Global";

    public void Run() {
      MudarAcesso();
      Console.WriteLine($"Acesso no exterior da função: {acesso}");
    }

    public void MudarAcesso() {
      string acesso = "Local";
      Console.WriteLine($"Acesso no interior da função: {acesso}");
    }
  }
}

/*
  Acesso no interior da função: Local
  Acesso no exterior da função: Global
*/
