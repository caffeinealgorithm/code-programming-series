// YouTube: https://youtu.be/aD7U69fw9hQ
// Publicação: https://caffeinealgorithm.com/blog/arrays-em-java/

package com.caffeinealgorithm.programaremjava;

public class Arrays {
  public void Run() {
    /*
      String[] cores = new String[5];

      cores[0] = "Azul";
      cores[1] = "Verde";
      cores[2] = "Amarelo";
      cores[3] = "Vermelho";
      cores[4] = "Laranja";
    */

    String[] cores = new String[] {
      "Azul",
      "Verde",
      "Amarelo",
      "Vermelho",
      "Laranja"
    };

    System.out.printf("Número de cores: %d\n", cores.length); // Número de cores: 5
    System.out.printf("Primeira cor: %s\n", cores[0]); // Primeira cor: Azul
    System.out.printf("Última cor: %s", cores[cores.length - 1]); // Última cor: Laranja
  }
}
