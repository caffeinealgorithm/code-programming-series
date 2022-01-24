// YouTube: https://youtu.be/AIxTT2P-5Dc
// Publicação: https://caffeinealgorithm.com/blog/20220124/classe-stack-em-csharp/

using System;
using System.Collections.Generic;

namespace Base {
  class ClasseStack {
    private Stack<int> pilha = new Stack<int>();
    private const int Multiplicador = 10;
    private int numero = 1;

    public void Run() {
      for (int indice = 1; indice <= 5; indice++) {
        pilha.Push(numero);
        numero *= Multiplicador;
      }

      ImprimirPilha();

      Console.WriteLine($"\nA remover o número {pilha.Pop()} da pilha com o método Pop().\n");

      ImprimirPilha();

      Console.WriteLine($"\nO número que se encontra na parte superior da pilha é o {pilha.Peek()}.");
    }

    private void ImprimirPilha() {
      foreach (var numero in pilha)
        Console.WriteLine(numero);
    }
  }
}

/*
  10000
  1000
  100
  10
  1

  A remover o número 10000 da pilha com o método Pop().

  1000
  100
  10
  1

  O número que se encontra na parte superior da pilha é o 1000.
*/
