// YouTube: https://youtu.be/-ka_3iD3V4Q
// Publicação: https://caffeinealgorithm.com/blog/classe-random-em-java/

package com.caffeinealgorithm.programaremjava;

import java.util.Random;

public class ClasseRandom {
  private Random aleatorio = new Random();

  public void Run() {
    System.out.printf("Número aleatório até 20: %d\n", aleatorio.nextInt(21));
    System.out.printf("Número aleatório (double): %.2f\n", aleatorio.nextDouble());

    for (int indice = 1; indice <= 10; indice++)
      System.out.printf("Número aleatório #%d: %d\n", indice, aleatorio.nextInt());
  }
}

/*
  Número aleatório até 20: 16
  Número aleatório (double): 1.00
  Número aleatório #1: -1738953879
  Número aleatório #2: 52710053
  Número aleatório #3: 1938113879
  Número aleatório #4: 1805001211
  Número aleatório #5: -129242103
  Número aleatório #6: 1301444521
  Número aleatório #7: 65079567
  Número aleatório #8: 110790254
  Número aleatório #9: -701484339
  Número aleatório #10: -1921592597
*/
