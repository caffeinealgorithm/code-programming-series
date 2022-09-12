// YouTube: https://youtu.be/2kgNJVpXB40
// Publicação: https://caffeinealgorithm.com/blog/is-e-as-em-csharp/

using System;

namespace Base {
  class IsEAs {
    private string organizacao = "Caffeine Algorithm", nome = string.Empty;
    private object _nome = "Nelson Silva";

    public void Run() {
      if (organizacao is string)
        Console.WriteLine("O atributo \"organizacao\" é do tipo string.");
      else
        Console.WriteLine("O atributo \"organizacao\" não é do tipo string.");

      nome = _nome as string;

      if (nome is string)
        Console.WriteLine($"Nome: {nome}");
    }
  }
}

/*
  O atributo "organizacao" é do tipo string.
  Nome: Nelson Silva
*/
