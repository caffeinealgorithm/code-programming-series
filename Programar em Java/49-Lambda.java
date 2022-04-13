// YouTube: https://youtu.be/Xh95YJxeAnI
// Publicação: https://caffeinealgorithm.com/blog/20220413/lambda-em-java/

package com.caffeinealgorithm.programaremjava;

import java.util.ArrayList;
import java.util.List;

public class Lambda {
  private List<String> pessoas = new ArrayList<>();

  public void Run() {
    pessoas.add("Nelson Silva");
    pessoas.add("Larissa Fernandes");
    pessoas.add("Pedro Henrique");
    pessoas.add("Raquel Soares");

    // listarPessoas();

    pessoas.forEach((pessoa) -> System.out.printf("Nome: %s\n", pessoa));
  }

  private void listarPessoas() {
    for (String pessoa : pessoas)
      System.out.printf("Nome: %s\n", pessoa);
  }
}

/*
  Nome: Nelson Silva
  Nome: Larissa Fernandes
  Nome: Pedro Henrique
  Nome: Raquel Soares
*/
