// YouTube: https://youtu.be/KxWKMHwKJVc
// Publicação: https://caffeinealgorithm.com/blog/20220301/ciclo-while-e-do-while-em-java/

package com.caffeinealgorithm.programaremjava;

public class CicloWhileEDoWhile {
  public void Run() {
    int contador = 1;

    while (contador <= 10) {
      System.out.printf("[while] Contador: %d\n", contador);
      contador++;
    }

    contador = 1;

    do {
      System.out.printf("[do while] Contador: %d\n", contador);
      contador++;
    } while (contador <= 10);
  }
}

/*
  [while] Contador: 1
  [while] Contador: 2
  [while] Contador: 3
  [while] Contador: 4
  [while] Contador: 5
  [while] Contador: 6
  [while] Contador: 7
  [while] Contador: 8
  [while] Contador: 9
  [while] Contador: 10
  [do while] Contador: 1
  [do while] Contador: 2
  [do while] Contador: 3
  [do while] Contador: 4
  [do while] Contador: 5
  [do while] Contador: 6
  [do while] Contador: 7
  [do while] Contador: 8
  [do while] Contador: 9
  [do while] Contador: 10
*/
