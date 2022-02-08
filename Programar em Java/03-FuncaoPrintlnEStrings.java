// YouTube: https://youtu.be/GZblJ-SqU_s
// Publicação: https://caffeinealgorithm.com/blog/20220208/funcao-println-e-strings-em-java/

package com.caffeinealgorithm.programaremjava;

public class Main {
  public static void main(String[] args) {
    var video = new FuncaoPrintlnEStrings();
    video.Run();
  }
}

/* --- */

package com.caffeinealgorithm.programaremjava;

public class FuncaoPrintlnEStrings {
  public void Run() {
    System.out.print("Estamos a usar a função print() e eu sou uma string.");
    System.out.println("Estamos a usar a função println() e eu continuo a ser uma string.");
    System.out.println("Estamos a usar novamente a função println() e eu continuo a ser uma string.");
  }
}
