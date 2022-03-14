// YouTube: https://youtu.be/RqbnpHEBZgc
// Publicação: https://caffeinealgorithm.com/blog/20220314/excecoes-em-java/

package com.caffeinealgorithm.programaremjava;

public class Excecoes {
  public void Run() {
    int[] numeros = new int[] {
        1, 2, 3, 4, 5
    };

    try {
      System.out.printf("Conteúdo do elemento: %d\n", numeros[4]);
    } catch (Exception excecao) {
      // System.out.println("O código presente no try não está a funcionar corretamente.");
      System.out.println(excecao);
    }
    finally {
      System.out.println("Eu faço parte do finally e sou executado caso haja ou não alguma exceção.");
    }
  }
}
