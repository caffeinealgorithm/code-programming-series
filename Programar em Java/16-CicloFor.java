// YouTube: https://youtu.be/aKgPE8bar_Y
// Publicação: https://caffeinealgorithm.com/blog/ciclo-for-em-java/

package com.caffeinealgorithm.programaremjava;

public class CicloFor {
  public void Run() {
    String[] materialEscolar = new String[] {
        "Mochila",
        "Estojo",
        "Lápis",
        "Borracha",
        "Afia",
        "Tesoura"
    };

    /*
      System.out.println(materialEscolar[0]);
      System.out.println(materialEscolar[1]);
    */

    for (int indice = 0; indice < materialEscolar.length; indice++)
      System.out.printf("materialEscolar[%d]: %s\n", indice, materialEscolar[indice]);
  }
}

/*
  materialEscolar[0]: Mochila
  materialEscolar[1]: Estojo
  materialEscolar[2]: Lápis
  materialEscolar[3]: Borracha
  materialEscolar[4]: Afia
  materialEscolar[5]: Tesoura
*/
