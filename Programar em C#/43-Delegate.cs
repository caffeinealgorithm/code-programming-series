// YouTube: https://youtu.be/bbXsVSa952Y
// Publicação: https://caffeinealgorithm.com/blog/delegate-em-csharp/

using System;

namespace Base {
  class Delegate {
    private delegate void ConjuntoDeMetodos(string nome);

    public void Run() {
      Console.Write("Insere o teu primeiro e último nome: ");
      var nome = Console.ReadLine();

      var conjuntoDeMetodos = new ConjuntoDeMetodos(ImprimirNome);
      conjuntoDeMetodos += ImprimirNomeEmMaiusculas;
      conjuntoDeMetodos += ImprimirNomeEmMinusculas;
      conjuntoDeMetodos(nome);
    }

    public void ImprimirNome(string nome) {
      Console.WriteLine($"Nome: {nome}");
    }

    public void ImprimirNomeEmMaiusculas(string nome) {
      Console.WriteLine($"Nome em maiúsculas: {nome.ToUpper()}");
    }

    public void ImprimirNomeEmMinusculas(string nome) {
      Console.WriteLine($"Nome em minúsculas: {nome.ToLower()}");
    }
  }
}

/*
  Nome: Nelson Silva
  Nome em maiúsculas: NELSON SILVA
  Nome em minúsculas: nelson silva
*/
