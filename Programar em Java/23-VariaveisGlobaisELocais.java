// YouTube: https://youtu.be/hgVFRjqnSPM
// Publicação: https://caffeinealgorithm.com/blog/variaveis-globais-e-locais-em-java/

package com.caffeinealgorithm.programaremjava;

public class VariaveisGlobaisELocais {
  String acesso = "Global";

  public void Run() {
    mudarAcesso();
    System.out.printf("Acesso no exterior da função: %s", acesso);
  }

  public void mudarAcesso() {
    String acesso = "Local";
    System.out.printf("Acesso no interior da função: %s\n", acesso);
  }
}

/*
  Acesso no interior da função: Local
  Acesso no exterior da função: Global
*/
