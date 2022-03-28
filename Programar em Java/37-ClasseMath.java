// YouTube: https://youtu.be/cpzjF8rXdI0
// Publicação: https://caffeinealgorithm.com/blog/20220328/classe-math-em-java/

package com.caffeinealgorithm.programaremjava;

public class ClasseMath {
  public void Run() {
    System.out.printf("Resultado do método sin(): %.2f\n", Math.sin(10.5));
    System.out.printf("Resultado do método cos(): %.2f\n", Math.cos(10.5));
    System.out.printf("Resultado do método tan(): %.2f\n", Math.tan(10.5));
    System.out.printf("Resultado do método floor(): %.2f\n", Math.floor(10.5));
    System.out.printf("Resultado do método ceil(): %.2f\n", Math.ceil(10.5));
    System.out.printf("Resultado do método abs(): %.2f\n", Math.abs(-10.5));
    System.out.printf("Resultado do método sqrt(): %.2f\n", Math.sqrt(9));
    System.out.printf("Resultado do método pow(): %.2f", Math.pow(2, 5));
  }
}

/*
  Resultado do método sin(): -0.88
  Resultado do método cos(): -0.48
  Resultado do método tan(): 1.85
  Resultado do método floor(): 10.00
  Resultado do método ceil(): 11.00
  Resultado do método abs(): 10.50
  Resultado do método sqrt(): 3.00
  Resultado do método pow(): 32.00
*/
