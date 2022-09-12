// YouTube: https://youtu.be/ktbsyAHPBv0
// Publicação: https://caffeinealgorithm.com/blog/classes-e-objetos-em-java/

package com.caffeinealgorithm.programaremjava;

public class Main {
  public static void main(String[] args) {
    var inimigo1 = new ClassesEObjetos();
    var inimigo2 = new ClassesEObjetos();

    inimigo1.ataque(); // Eu fui atacado e perdi uma vida.
    inimigo1.ataque(); // Eu fui atacado e perdi uma vida.
    inimigo1.ataque(); // Eu fui atacado e perdi uma vida.
    inimigo1.verificarVida(); // Eu ainda estou em combate e tenho 2 vidas.
    inimigo2.verificarVida(); // Eu ainda estou em combate e tenho 5 vidas.
  }
}

/* --- */

package com.caffeinealgorithm.programaremjava;

public class ClassesEObjetos {
  int vidas = 5;

  public void ataque() {
    System.out.println("Eu fui atacado e perdi uma vida.");
    vidas -= 1;
  }

  public void verificarVida() {
    if (vidas <= 0)
      System.out.println("Eu estou morto porque não tenho mais vidas.");
    else
      System.out.printf("Eu ainda estou em combate e tenho %d vidas.\n", vidas);
  }
}
