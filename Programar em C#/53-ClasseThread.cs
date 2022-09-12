// YouTube: https://youtu.be/N1ZSoxB80B0
// Publicação: https://caffeinealgorithm.com/blog/classe-thread-em-csharp/

using System;
using System.Threading;

namespace Base {
  class ClasseThread {
    private Thread tarefa;

    public void Run() {
      tarefa = new Thread(ExecutarTarefa);
      tarefa.Start();

      for (int indice = 1; indice <= 5; indice++) {
        Console.WriteLine($"Run() #{indice}");
        Thread.Sleep(1000);
      }

      Console.WriteLine("A tarefa Run() finalizou.");

      tarefa.Join();

      Console.WriteLine("A tarefa ExecutarTarefa() finalizou.");
    }

    private void ExecutarTarefa() {
      for (int indice = 1; indice <= 10; indice++) {
        Console.WriteLine($"ExecutarTarefa() #{indice}");
        Thread.Sleep(1000);
      }
    }
  }
}

/*
  Run() #1
  ExecutarTarefa() #1
  Run() #2
  ExecutarTarefa() #2
  Run() #3
  ExecutarTarefa() #3
  Run() #4
  ExecutarTarefa() #4
  Run() #5
  ExecutarTarefa() #5
  A tarefa Run() finalizou.
  ExecutarTarefa() #6
  ExecutarTarefa() #7
  ExecutarTarefa() #8
  ExecutarTarefa() #9
  ExecutarTarefa() #10
  A tarefa ExecutarTarefa() finalizou.
*/
