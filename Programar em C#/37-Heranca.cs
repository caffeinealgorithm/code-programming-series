// YouTube: https://youtu.be/kDKbnI-opqE
// Publicação: https://caffeinealgorithm.com/blog/20211227/heranca-em-csharp/

using System;

namespace Base {
  class Heranca {
    public void Run() {
      var pessoa = new Filho();
      pessoa.Informacao();
      pessoa.ComidaPreferida();

      /*
        Nome: Nelson Silva
        Idade: 25
        A minha comida preferida é arroz de marisco.
      */
    }
  }

  class Pai {
    protected string ultimoNome = "Silva";

    public void ComidaPreferida() {
      Console.WriteLine("A minha comida preferida é arroz de marisco.");
    }
  }

  class Filho : Pai {
    private string primeiroNome = "Nelson";
    private int idade = 25;

    public void Informacao() {
      Console.WriteLine($"Nome: {primeiroNome} {ultimoNome}");
      Console.WriteLine($"Idade: {idade}");
    }
  }
}
