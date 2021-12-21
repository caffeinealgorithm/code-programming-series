// YouTube: https://youtu.be/b65giOzFRYU
// Publicação: https://caffeinealgorithm.com/blog/20211221/construtores-em-csharp/

using System;

namespace Base {
  class Program {
    static void Main(string[] args) {
      var pessoa1 = new Construtores("Nelson", "Silva", 25);
      var pessoa2 = new Construtores("Larissa", "Fernandes", 17);

      pessoa1.Informacao();
      pessoa1.VerificarEntrada();

      /*
        Nome: Nelson Silva
        Idade: 25
        Esta pessoa pode entrar no local porque tem mais de 18 anos.
      */

      pessoa2.Informacao();
      pessoa2.VerificarEntrada();

      /*
        Nome: Larissa Fernandes
        Idade: 17
        Esta pessoa não pode entrar no local porque tem menos de 18 anos.
      */

      Console.ReadKey();
    }
  }
}

/* --- */

using System;

namespace Base {
  class Construtores {
    string primeiroNome = string.Empty, ultimoNome = string.Empty;
    int idade = 0;

    public Construtores(string primeiroNome, string ultimoNome, int idade) {
      this.primeiroNome = primeiroNome;
      this.ultimoNome = ultimoNome;
      this.idade = idade;
    }

    public void Informacao() {
      Console.WriteLine($"Nome: {primeiroNome} {ultimoNome}");
      Console.WriteLine($"Idade: {idade}");
    }

    public void VerificarEntrada() {
      if (idade >= 18)
        Console.WriteLine("Esta pessoa pode entrar no local porque tem mais de 18 anos.");
      else
        Console.WriteLine("Esta pessoa não pode entrar no local porque tem menos de 18 anos.");
    }
  }
}
