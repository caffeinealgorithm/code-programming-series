// YouTube: https://youtu.be/R-ueRH4ySug
// Publicação: https://caffeinealgorithm.com/blog/dicionarios-map-em-java/

package com.caffeinealgorithm.programaremjava;

import java.util.HashMap;
import java.util.Map;

public class DicionariosMap {
  public void Run() {
    Map<String, Integer> pessoas = new HashMap<>();
    // Map pessoas = new HashMap();

    pessoas.put("Nelson Silva", 25);
    pessoas.put("Larissa Fernandes", 37);
    pessoas.put("Pedro Henrique", 52);
    pessoas.put("Raquel Soares", 68);

    pessoas.replace("Pedro Henrique", 100);
    pessoas.remove("Larissa Fernandes");
    // pessoas.clear();

    System.out.printf("Nome das pessoas: %s\n", pessoas.keySet());
    System.out.printf("Idade das pessoas: %s", pessoas.values());
  }
}

/*
  Nome das pessoas: [Pedro Henrique, Nelson Silva, Raquel Soares]
  Idade das pessoas: [100, 25, 68]
*/
