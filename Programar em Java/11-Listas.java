// YouTube: https://youtu.be/VFwjISUooB4
// Publicação: https://caffeinealgorithm.com/blog/20220218/listas-em-java/

package com.caffeinealgorithm.programaremjava;

import java.util.ArrayList;
import java.util.List;

public class Listas {
  public void Run() {
    List<String> cores = new ArrayList<>();

    cores.add("Azul");
    cores.add("Verde");
    cores.add("Amarelo");
    cores.add("Vermelho");
    cores.add("Laranja");

    cores.remove("Laranja");
    // cores.clear();

    System.out.printf("Número de cores: %d\n", cores.size()); // Número de cores: 4
    System.out.printf("Primeira cor: %s\n", cores.get(0)); // Primeira cor: Azul
    System.out.printf("Última cor: %s", cores.get(cores.size() - 1)); // Última cor: Vermelho
  }
}
