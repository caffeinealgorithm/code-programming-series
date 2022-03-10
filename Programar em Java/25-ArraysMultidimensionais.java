// YouTube: https://youtu.be/tF6U5grcYCE
// Publicação: https://caffeinealgorithm.com/blog/20220310/arrays-multidimensionais-em-java/

package com.caffeinealgorithm.programaremjava;

public class ArraysMultidimensionais {
  public void Run() {
    // [número de linhas][número de colunas]
    int[][] arrayMultidimensional = new int[][] {
        { 1, 2, 3, 4 },
        { 1, 1, 1, 1 },
        { 2, 2, 2, 2 },
        { 3, 3, 3, 3 },
        { 4, 4, 4, 4 }
    };

    for (int linha = 0; linha < 5; linha++) {
      for (int coluna = 0; coluna < 4; coluna++) {
        System.out.printf("%d\t", arrayMultidimensional[linha][coluna]);
      }

      System.out.println();
    }
  }
}

/*
  1  2  3  4
  1  1  1  1
  2  2  2  2
  3  3  3  3
  4  4  4  4
*/
