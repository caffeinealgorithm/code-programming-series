// YouTube: https://youtu.be/22Np9fJQv-E
// Publicação: https://caffeinealgorithm.com/blog/20220401/classe-filereader-em-java/

package com.caffeinealgorithm.programaremjava;

import java.io.File;
import java.io.FileReader;
import java.io.IOException;

public class ClasseFileReader {
  private File ficheiro = new File("Ficheiro.txt");
  private char[] carateres = new char[100];
  private FileReader lerFicheiro;

  public void Run() {
    if (ficheiro.exists()) {
      try {
        lerFicheiro = new FileReader(ficheiro);
        lerFicheiro.read(carateres);

        for (char carater : carateres)
          System.out.print(carater);

        lerFicheiro.close();
      }
      catch (IOException excecao) {
        System.out.println(excecao);
      }
    }
  }
}

/*
  Portugal
  Brasil
  Espanha
  França
  Itália
  Austrália
  Índia
*/
