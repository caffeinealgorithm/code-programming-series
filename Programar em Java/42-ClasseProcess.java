// YouTube: https://youtu.be/rd4_ShKKqAo
// Publicação: https://caffeinealgorithm.com/blog/classe-process-em-java/

package com.caffeinealgorithm.programaremjava;

public class ClasseProcess {
  private Process processo;

  public void Run() {
    try {
      processo = new ProcessBuilder("notepad.exe").start();
    }
    catch (Exception excecao) {
      System.out.println(excecao);
    }

    try {
      if (processo.isAlive()) {
        System.out.println("O processo \"notepad.exe\" está a ser executado e tal execução irá terminar em cerca de três segundos.");
        Thread.sleep(3000);
        processo.destroy();
      }
    }
    catch (InterruptedException excecao) {
      System.out.println(excecao);
    }
  }
}

// O processo "notepad.exe" está a ser executado e tal execução irá terminar em cerca de três segundos.
