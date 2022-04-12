// YouTube: https://youtu.be/hqICEMabCZQ
// Publicação: https://caffeinealgorithm.com/blog/20220412/metodos-iii-em-java/

package com.caffeinealgorithm.programaremjava;

public class MetodosIII {
  private String a = "Nelson", b = "Nelson", c = "Silva";
  private String lingProgPreferida = "A minha linguagem preferida já foi o Java.";

  public void Run() {
    // equals()
    System.out.printf("a == b : %b\n", a.equals(b));
    System.out.printf("b == c : %b\n", b.equals(c));

    // replace()
    System.out.println(lingProgPreferida);
    System.out.println(lingProgPreferida.replace("já foi", "é"));
  }
}

/*
  a == b : true
  b == c : false
  A minha linguagem preferida já foi o Java.
  A minha linguagem preferida é o Java.
*/
