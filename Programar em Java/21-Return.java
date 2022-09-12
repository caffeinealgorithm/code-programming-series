// YouTube: https://youtu.be/hnoGygkv9fw
// Publicação: https://caffeinealgorithm.com/blog/return-em-java/

package com.caffeinealgorithm.programaremjava;

public class Return {
  public void Run() {
    System.out.printf("Resultado da adição: %d", adicao());
  }

  public int adicao() {
    int resultado = 0;

    for (int valor = 1; valor <= 10; valor++)
      resultado += valor;

    return resultado;
  }
}

// Resultado da adição: 55
