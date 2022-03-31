// YouTube: https://youtu.be/iohYifid7pM
// Publicação: https://caffeinealgorithm.com/blog/20220330/classe-filewriter-em-java/

package com.caffeinealgorithm.programaremjava;

import java.io.File;
import java.io.FileWriter;
import java.io.IOException;
import java.util.ArrayList;
import java.util.List;

public class ClasseFileWriter {
  private File ficheiro = new File("Ficheiro.txt");
  private List<String> paises = new ArrayList<>();
  private FileWriter escreverFicheiro;

  public void Run() {
    paises.add("Portugal");
    paises.add("Brasil");
    paises.add("Espanha");
    paises.add("França");
    paises.add("Itália");
    paises.add("Austrália");
    paises.add("Índia");

    if (!ficheiro.exists()) {
      try {
        ficheiro.createNewFile();
        escreverFicheiro = new FileWriter(ficheiro);

        for (String pais : paises)
          escreverFicheiro.write(pais + '\n');

        escreverFicheiro.close();
      }
      catch (IOException excecao) {
        System.out.println(excecao);
      }
    }
  }
}
