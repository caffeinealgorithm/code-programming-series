// YouTube: https://youtu.be/wFJN_36mi9M
// Publicação: https://caffeinealgorithm.com/blog/heranca-em-java/

package com.caffeinealgorithm.programaremjava;

public class Heranca {
  public void Run() {
    var pessoa = new Filho();
    pessoa.informacao();
    pessoa.comidaPreferida();

    /*
      Nome: Nelson Silva
      Idade: 25
      A minha comida preferida é arroz de marisco.
    */
  }
}

class Pai {
  protected String ultimoNome = "Silva";

  public void comidaPreferida() {
    System.out.println("A minha comida preferida é arroz de marisco.");
  }
}

class Filho extends Pai {
  private String primeiroNome = "Nelson";
  private int idade = 25;

  public void informacao() {
    System.out.printf("Nome: %s %s\n", primeiroNome, ultimoNome);
    System.out.printf("Idade: %d\n", idade);
  }
}
