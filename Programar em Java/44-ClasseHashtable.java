// YouTube: https://youtu.be/ZqsM5Ay_PgA
// Publicação: https://caffeinealgorithm.com/blog/20220406/classe-hashtable-em-java/

package com.caffeinealgorithm.programaremjava;

import java.util.Hashtable;

public class ClasseHashtable {
  private Hashtable<String, Integer> pessoas = new Hashtable<>();

  public void Run() {
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
  Nome das pessoas: [Nelson Silva, Raquel Soares, Pedro Henrique]
  Idade das pessoas: [25, 68, 100]
*/
