// YouTube: https://youtu.be/ZCr9-qfctoU
// Publicação: https://caffeinealgorithm.com/blog/classe-math-em-csharp/

using System;

namespace Base {
  class ClasseMath {
    public void Run() {
      Console.WriteLine($"Resultado do método Sin(): {Math.Sin(10.5)}");
      Console.WriteLine($"Resultado do método Cos(): {Math.Cos(10.5)}");
      Console.WriteLine($"Resultado do método Tan(): {Math.Tan(10.5)}");
      Console.WriteLine($"Resultado do método Floor(): {Math.Floor(10.5)}");
      Console.WriteLine($"Resultado do método Ceiling(): {Math.Ceiling(10.5)}");
      Console.WriteLine($"Resultado do método Abs(): {Math.Abs(-10.5)}");
      Console.WriteLine($"Resultado do método Sqrt(): {Math.Sqrt(9)}");
      Console.WriteLine($"Resultado do método Pow(): {Math.Pow(2, 5)}");
    }
  }
}

/*
  Resultado do método Sin(): -0,87969575997167
  Resultado do método Cos(): -0,4755369279959925
  Resultado do método Tan(): 1,8498999934219273
  Resultado do método Floor(): 10
  Resultado do método Ceiling(): 11
  Resultado do método Abs(): 10,5
  Resultado do método Sqrt(): 3
  Resultado do método Pow(): 32
*/
