// YouTube: https://youtu.be/X8hVHwqEiKI
// Publicação: https://caffeinealgorithm.com/blog/20220228/ciclo-foreach-em-java/

package com.caffeinealgorithm.programaremjava;

import java.util.ArrayList;
import java.util.List;

public class CicloForeach {
  public void Run() {
    List<String> paises = new ArrayList<>();

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

/*
  País: Portugal
  País: Brasil
  País: Espanha
  País: França
  País: Itália
  País: Austrália
  País: Índia
*/
