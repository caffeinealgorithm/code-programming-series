// YouTube: https://youtu.be/vZjw1DbKVsY
// Publicação: https://caffeinealgorithm.com/blog/20220316/construtores-em-java/

package com.caffeinealgorithm.programaremjava;

public class Main {
  public static void main(String[] args) {
    var pessoa1 = new Construtores("Nelson", "Silva", 25);
    var pessoa2 = new Construtores("Larissa", "Fernandes", 17);

    pessoa1.informacao();
    pessoa1.verificarEntrada();

    /*
      Nome: Nelson Silva
      Idade: 25
      Esta pessoa pode entrar no local porque tem mais de 18 anos.
    */

    pessoa2.informacao();
    pessoa2.verificarEntrada();

    /*
      Nome: Larissa Fernandes
      Idade: 17
      Esta pessoa não pode entrar no local porque tem menos de 18 anos.
    */
  }
}

/* --- */

package com.caffeinealgorithm.programaremjava;

public class Construtores {
  String primeiroNome = null, ultimoNome = null;
  int idade = 0;

  public Construtores(String primeiroNome, String ultimoNome, int idade) {
    this.primeiroNome = primeiroNome;
    this.ultimoNome = ultimoNome;
    this.idade = idade;
  }

  public void informacao() {
    System.out.printf("Nome: %s %s\n", primeiroNome, ultimoNome);
    System.out.printf("Idade: %d\n", idade);
  }

  public void verificarEntrada() {
    if (idade >= 18)
      System.out.println("Esta pessoa pode entrar no local porque tem mais de 18 anos.");
    else
      System.out.println("Esta pessoa não pode entrar no local porque tem menos de 18 anos.");
  }
}
