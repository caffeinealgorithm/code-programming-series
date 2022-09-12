// YouTube: https://youtu.be/TAKYXCKl4VE
// Publicação: https://caffeinealgorithm.com/blog/metodos-i-em-java/

package com.caffeinealgorithm.programaremjava;

public class MetodosI {
  private String umDoisTres = "UmDoisTrês", nome = "Nelson Gomes da Silva";

  public void Run() {
    // substring()
    System.out.printf("1: %s\n", umDoisTres.substring(0, 2));
    System.out.printf("2: %s\n", umDoisTres.substring(2, 6));
    System.out.printf("3: %s\n", umDoisTres.substring(6));

    // split()
    var palavras = nome.split(" ");

    for (String palavra : palavras)
      System.out.printf("Palavra: %s\n", palavra);

    var _palavras = nome.split(" Gomes da ");
    System.out.printf("Nome: %s %s", _palavras[0], _palavras[1]);
  }
}

/*
  1: Um
  2: Dois
  3: Três
  Palavra: Nelson
  Palavra: Gomes
  Palavra: da
  Palavra: Silva
  Nome: Nelson Silva
*/
