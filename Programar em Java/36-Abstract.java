// YouTube: https://youtu.be/ZsiTd23CfUs
// Publicação: https://caffeinealgorithm.com/blog/abstract-em-java/

package com.caffeinealgorithm.programaremjava;

import java.util.ArrayList;
import java.util.List;

public class Abstract {
  public void Run() {
    // ClasseX.informacaoX();
    var classe = new ClasseY();
    classe.informacaoY();

    /*
      País: Portugal
      País: Brasil
      País: Espanha
      País: França
      País: Itália
      País: Austrália
      País: Índia
    */
  }
}

abstract class ClasseX {
  public static String organizacao = "Caffeine Algorithm";
  public static List<String> paises = new ArrayList<>();

  public static void informacaoX() {
    for (char carater : organizacao.toCharArray())
      System.out.printf("Carater: %c\n", carater);
  }

  public abstract void informacaoY();
}

class ClasseY extends ClasseX {
  public void informacaoY() {
    paises.add("Portugal");
    paises.add("Brasil");
    paises.add("Espanha");
    paises.add("França");
    paises.add("Itália");
    paises.add("Austrália");
    paises.add("Índia");

    for (String pais : paises)
      System.out.printf("País: %s\n", pais);
  }
}
