// YouTube: https://youtu.be/f_RICgMykc8
// Publicação: https://caffeinealgorithm.com/blog/operadores-bit-a-bit-em-java/

package com.caffeinealgorithm.programaremjava;

public class OperadoresBitABit {
  private int x = 60; // 00111100 < 01111000 < 11110000 | 00111100 > 00011110 > 00001111
  private int y = 13; // 00001101

  public void Run() {
    System.out.printf("Resultado do operador &: %d\n", x & y); // 12 -> 00001100
    System.out.printf("Resultado do operador |: %d\n", x | y); // 61 -> 00111101
    System.out.printf("Resultado do operador <<: %d\n", x << 2); // 240 -> 11110000
    System.out.printf("Resultado do operador >>: %d", x >> 2); // 15 -> 00001111
  }
}

/*
  Resultado do operador &: 12
  Resultado do operador |: 61
  Resultado do operador <<: 240
  Resultado do operador >>: 15
*/
