// YouTube: https://youtu.be/rCUwMA4JHHk
// Publicação: https://caffeinealgorithm.com/blog/20220223/operador-ternario-em-java/

package com.caffeinealgorithm.programaremjava;

public class OperadorTernario {
  // (condição) ? condição for verdadeira : condição for falsa

  public void Run() {
    int idade = 25;
    boolean eMaiorDeIdade;

    /*
      if (idade >= 18)
        eMaiorDeIdade = true;
      else
        eMaiorDeIdade = false;
    */

    eMaiorDeIdade = (idade >= 18) ? true : false;

    System.out.printf("É maior de idade: %b", eMaiorDeIdade);
  }
}

// É maior de idade: true
