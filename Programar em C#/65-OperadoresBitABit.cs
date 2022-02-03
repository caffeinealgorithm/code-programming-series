// YouTube: https://youtu.be/JMpv0Yt32AA
// Publicação: https://caffeinealgorithm.com/blog/20220203/operadores-bit-e-bit-em-csharp/

using System;

namespace Base {
  class OperadoresBitABit {
    private int x = 60; // 00111100 < 01111000 < 11110000 | 00111100 > 00011110 > 00001111
    private int y = 13; // 00001101

    public void Run() {
      Console.WriteLine($"Resultado do operador &: {x & y}"); // 12 -> 00001100
      Console.WriteLine($"Resultado do operador |: {x | y}"); // 61 -> 00111101
      Console.WriteLine($"Resultado do operador <<: { x << 2 }"); // 240 -> 11110000
      Console.WriteLine($"Resultado do operador >>: { x >> 2 }"); // 15 -> 00001111
    }
  }
}

/*
  Resultado do operador &: 12
  Resultado do operador |: 61
  Resultado do operador <<: 240
  Resultado do operador >>: 15
*/
