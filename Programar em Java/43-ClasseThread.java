// YouTube: https://youtu.be/Crk467wQmQg
// Publicação: https://caffeinealgorithm.com/blog/classe-thread-em-java/

package com.caffeinealgorithm.programaremjava;

public class ClasseThread {
  private Thread tarefa;

  public void Run() {
    tarefa = new Thread(this::executarTarefa);
    tarefa.start();

    for (int indice = 1; indice <= 5; indice++) {
      System.out.printf("Run(): #%d\n", indice);

      try {
        Thread.sleep(1000);
      }
      catch (InterruptedException excecao) {
        System.out.println(excecao);
      }
    }

    System.out.println("A tarefa Run() finalizou.");

    try {
      tarefa.join();
    }
    catch (InterruptedException excecao) {
      System.out.println(excecao);
    }

    System.out.println("A tarefa executarTarefa() finalizou.");
  }

  private void executarTarefa() {
    for (int indice = 1; indice <= 10; indice++) {
      System.out.printf("executarTarefa(): #%d\n", indice);

      try {
        Thread.sleep(1000);
      }
      catch (InterruptedException excecao) {
        System.out.println(excecao);
      }
    }
  }
}

/*
  Run(): #1
  executarTarefa(): #1
  Run(): #2
  executarTarefa(): #2
  Run(): #3
  executarTarefa(): #3
  Run(): #4
  executarTarefa(): #4
  Run(): #5
  executarTarefa(): #5
  A tarefa Run() finalizou.
  executarTarefa(): #6
  executarTarefa(): #7
  executarTarefa(): #8
  executarTarefa(): #9
  executarTarefa(): #10
  A tarefa executarTarefa() finalizou.
*/
