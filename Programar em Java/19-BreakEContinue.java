// YouTube: https://youtu.be/Wbe6-a8go0o
// Publicação: https://caffeinealgorithm.com/blog/break-e-continue-em-java/

package com.caffeinealgorithm.programaremjava;

import java.util.ArrayList;
import java.util.List;

public class BreakEContinue {
  public void Run() {
    List<String> animais = new ArrayList<>();
    int contador = 0;

    animais.add("Cão");
    animais.add("Gato");
    animais.add("Galinha");
    animais.add("Coelho");
    animais.add("Leão");

    for (String animal : animais) {
      System.out.printf("Animal: %s\n", animal);

      if (animal == "Galinha")
        break;
    }

    while (contador < 10) {
      contador++;

      if (contador == 5)
        continue;

      System.out.printf("Contador: %d\n", contador);
    }
  }
}

/*
  Animal: Cão
  Animal: Gato
  Animal: Galinha
  Contador: 1
  Contador: 2
  Contador: 3
  Contador: 4
  Contador: 6
  Contador: 7
  Contador: 8
  Contador: 9
  Contador: 10
*/
