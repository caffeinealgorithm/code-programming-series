// YouTube: https://youtu.be/kfCzIPNX2CA
// Publicação: https://caffeinealgorithm.com/blog/classe-stack-em-java/

package com.caffeinealgorithm.programaremjava;

import java.util.Stack;

public class ClasseStack {
  private Stack<Integer> pilha = new Stack<>();
  private int multiplicador = 10, numero = 1;

  public void Run() {
    for (int indice = 1; indice <= 5; indice++) {
      pilha.push(numero);
      numero *= multiplicador;
    }

    imprimirPilha();

    System.out.printf("\nA remover o número %d da pilha com o método pop().\n\n", pilha.pop());

    imprimirPilha();

    System.out.printf("\nO número que se encontra a seguir para ser removido da pilha é o %d.", pilha.peek());
  }

  private void imprimirPilha() {
    for (int numero : pilha)
      System.out.println(numero);
  }
}

/*
  1
  10
  100
  1000
  10000

  A remover o número 10000 da pilha com o método pop().

  1
  10
  100
  1000

  O número que se encontra a seguir para ser removido da pilha é o 1000.
*/
