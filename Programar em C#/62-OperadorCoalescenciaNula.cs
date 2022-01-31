// YouTube: https://youtu.be/s-X26LwvxC0
// Publicação: https://caffeinealgorithm.com/blog/20220131/operador-de-coalescencia-nula-em-csharp/

using System;

namespace Base {
  class OperadorCoalescenciaNula {
    private string nome;

    public string Nome {
      get {
        return nome ?? "O conteúdo é simplesmente nulo.";
      }

      set {
        nome = value;
      }
    }

    public void Run() {
      Console.WriteLine(Nome);

      Nome = "Nelson Silva";
      Console.WriteLine($"Nome: {Nome}");

      Nome = null;
      Console.WriteLine(Nome);

      VerificarTamanho(null);
      VerificarTamanho("Coalescência Nula");
    }

    private void VerificarTamanho(string palavra) {
      if (palavra?.Length > 5)
        Console.WriteLine($"\"{palavra}\": Esta palavra tem mais de 5 carateres.");
    }
  }
}

/*
  O conteúdo é simplesmente nulo.
  Nome: Nelson Silva
  O conteúdo é simplesmente nulo.
  "Coalescência Nula": Esta palavra tem mais de 5 carateres.
*/
