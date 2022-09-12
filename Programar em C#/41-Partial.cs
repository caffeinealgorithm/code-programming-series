// YouTube: https://youtu.be/xwk4Xx5-zO0
// Publicação: https://caffeinealgorithm.com/blog/partial-em-csharp/

using System;

namespace Base {
  class Partial {
    public void Run() {
      var pessoa = new Pessoa();
      pessoa.Informacao();

      /*
        Nome: Nelson Silva
        Idade: 25
      */
    }
  }

  partial class Pessoa {
    private string primeiroNome = "Nelson";
    partial void _Informacao();

    public void Informacao() {
      _Informacao();
    }
  }

  partial class Pessoa {
    private string ultimoNome = "Silva";
    private int idade = 25;

    partial void _Informacao() {
      Console.WriteLine($"Nome: {primeiroNome} {ultimoNome}");
      Console.WriteLine($"Idade: {idade}");
    }
  }
}
