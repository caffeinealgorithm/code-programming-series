// YouTube: https://youtu.be/GQVf0VwJh9c
// Publicação: https://caffeinealgorithm.com/blog/20220211/operadores-de-atribuicao-em-java/

package com.caffeinealgorithm.programaremjava;

public class OperadoresDeAtribuicao {
  public void Run() {
    int x = 2;

    x += 3;
    System.out.println("x = x + 3: " + x); // x = x + 3: 5

    x -= 2;
    System.out.println("x = x - 2: " + x); // x = x - 2: 3

    x *= 2;
    System.out.println("x = x * 2: " + x); // x = x * 2: 6

    x /= 2;
    System.out.println("x = x / 2: " + x); // x = x / 2: 3

    x %= 3;
    System.out.println("x = x % 3: " + x); // x = x % 3: 0
  }
}
