// YouTube: https://youtu.be/b40p72IG4-8
// Publicação: https://caffeinealgorithm.com/blog/20220318/mais-sobre-as-excecoes-em-java/

package com.caffeinealgorithm.programaremjava;

public class MaisSobreAsExcecoes {
  private Exception stringVazia = new Exception("Não se pode verificar uma string que esteja vazia.");

  public void Run() {
    try {
      verificarString("Eu sou uma string.");
    } catch (Exception excecao) {
      System.out.println(excecao);
    }
  }

  private void verificarString(String string) throws Exception {
    if (string == "")
      throw stringVazia;
    else
      System.out.printf("String: %s", string);
  }
}
