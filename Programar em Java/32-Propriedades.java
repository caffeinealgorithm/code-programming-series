// YouTube: https://youtu.be/M9PXEZdgm48
// Publicação: https://caffeinealgorithm.com/blog/20220321/propriedades-em-java/

package com.caffeinealgorithm.programaremjava;

public class Main {
  public static void main(String[] args) {
    var pessoa = new Propriedades();

    pessoa.setPrimeiroNome("Nelson");
    pessoa.setUltimoNome("Silva");
    pessoa.informacao();
    System.out.printf("Idade: %d", pessoa.getIdade());

    /*
      Nome: Nelson Silva
      Idade: 25
    */
  }
}

/* --- */

package com.caffeinealgorithm.programaremjava;

public class Propriedades {
  private String primeiroNome = "", ultimoNome = "";
  private int idade = 25;

  public void setPrimeiroNome(String primeiroNome) {
    if (primeiroNome != "")
      this.primeiroNome = primeiroNome;
    else
      System.out.println("A string referente ao primeiro nome não pode estar vazia.");
  }

  public void setUltimoNome(String ultimoNome) {
    if (ultimoNome != "")
      this.ultimoNome = ultimoNome;
    else
      System.out.println("A string referente ao último nome não pode estar vazia.");
  }

  public int getIdade() {
    return idade;
  }

  public void informacao() {
    System.out.printf("Nome: %s %s\n", primeiroNome, ultimoNome);
  }
}
