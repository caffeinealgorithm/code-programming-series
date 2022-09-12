// YouTube: https://youtu.be/k76K3UraNhU
// Publicação: https://caffeinealgorithm.com/blog/argumentos-em-java/

package com.caffeinealgorithm.programaremjava;

public class Argumentos {
  public void Run() {
    dadosPessoais("Nelson Silva", 25, "Portuguesa");
    dadosPessoais("Larissa Fernandes", 37, "Brasileira");
  }

  public void dadosPessoais(String nome, int idade, String nacionalidade) {
    System.out.printf("Nome: %s\n", nome);
    System.out.printf("Idade: %d\n", idade);
    System.out.printf("Nacionalidade: %s", nacionalidade);
  }
}

/*
  Nome: Nelson Silva
  Idade: 25
  Nacionalidade: Portuguesa
  Nome: Larissa Fernandes
  Idade: 37
  Nacionalidade: Brasileira
*/
