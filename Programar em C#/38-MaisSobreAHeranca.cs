// YouTube: https://youtu.be/bGmyHB0Acvw
// Publicação: https://caffeinealgorithm.com/blog/mais-sobre-a-heranca-em-csharp/

using System;

namespace Base {
  class MaisSobreAHeranca {
    public void Run() {
      var pessoa = new Filho();
      pessoa.Informacao();
      pessoa.ComidaPreferida();

      /*
        Nome: Nelson Silva
        Idade: 25
        A minha comida preferida é lasanha.
      */
    }
  }

  class Pai {
    protected string ultimoNome = "Silva";

    public virtual void ComidaPreferida() {
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

    public override void ComidaPreferida() {
      Console.WriteLine("A minha comida preferida é lasanha.");
    }
  }
}
