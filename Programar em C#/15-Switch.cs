// YouTube: https://youtu.be/vqC8km6r22k
// Publicação: https://caffeinealgorithm.com/blog/switch-em-csharp/

using System;

namespace Base {
  class Switch {
    public void Run() {
      char caso = 'D';

      switch (caso) {
        case 'A':
          Console.WriteLine("O caso A existe.");
          break;
        case 'B':
          Console.WriteLine("O caso B existe.");
          break;
        case 'C':
          Console.WriteLine("O caso C existe.");
          break;
        default:
          Console.WriteLine($"O caso {caso} não existe.");
          break;
      }
    }
  }
}

// O caso D não existe.
