// YouTube: https://youtu.be/Vk0V-iw_LWo
// Publicação: https://caffeinealgorithm.com/blog/20220214/mais-sobre-as-strings-em-java/

package com.caffeinealgorithm.programaremjava;

public class MaisSobreAsStrings {
  public void Run() {
    String primeiroNome = "Nelson";
    String ultimoNome = "Silva";
    int idade = 25;

    System.out.println("Nome: " + primeiroNome + ' ' + ultimoNome + "\nIdade: " + idade);
    System.out.println(new StringBuilder().append("Nome: ").append(primeiroNome).append(' ').append(ultimoNome).append("\nIdade: ").append(idade));
    System.out.printf("Nome: %s %s\nIdade: %d", primeiroNome, ultimoNome, idade);
  }
}

/*
  Nome: Nelson Silva
  Idade: 25
  Nome: Nelson Silva
  Idade: 25
  Nome: Nelson Silva
  Idade: 25
*/
