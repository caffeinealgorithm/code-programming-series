// YouTube: https://youtu.be/8NxhJZz7UmU
// Publicação: https://caffeinealgorithm.com/blog/classe-random-em-csharp/

using System;

namespace Base {
  class ClasseRandom {
    private Random aleatorio = new Random();

    public void Run() {
      Console.WriteLine($"Número aleatório até 20: {aleatorio.Next(21)}");
      Console.WriteLine($"Número aleatório entre 20 e 40: {aleatorio.Next(20, 41)}");

      for (int indice = 1; indice <= 10; indice++)
        Console.WriteLine($"Número aleatório #{indice}: {aleatorio.Next()}");
    }
  }
}

/*
  Número aleatório até 20: 8
  Número aleatório entre 20 e 40: 39
  Número aleatório #1: 1992885730
  Número aleatório #2: 1283322657
  Número aleatório #3: 226863787
  Número aleatório #4: 710252620
  Número aleatório #5: 1546596848
  Número aleatório #6: 1967725250
  Número aleatório #7: 1848910215
  Número aleatório #8: 1504322913
  Número aleatório #9: 1207920689
  Número aleatório #10: 571352235
*/
