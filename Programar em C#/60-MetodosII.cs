// YouTube: https://youtu.be/r9h6UzvoRCE
// Publicação: https://caffeinealgorithm.com/blog/20220127/metodos-ii-em-csharp/

using System;

namespace Base {
  class MetodosII {
    private string loremIpsum = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vestibulum consectetur.";

    public void Run() {
      // IndexOf()
      var indice = 0;

      while ((indice = loremIpsum.IndexOf('i', indice)) != -1) {
        Console.WriteLine(loremIpsum.Substring(indice));
        indice++;
      }

      // Trim()
      Console.Write("Insere o teu primeiro nome: ");
      var primeiroNome = Console.ReadLine();

      Console.Write("Insere o teu último nome: ");
      var ultimoNome = Console.ReadLine();

      Console.WriteLine($"Nome (sem o uso do método Trim()): {primeiroNome} {ultimoNome}");
      Console.WriteLine($"Nome (com o uso do método Trim()): {primeiroNome.Trim()} {ultimoNome.Trim()}");
    }
  }
}

/*
  ipsum dolor sit amet, consectetur adipiscing elit. Vestibulum consectetur.
  it amet, consectetur adipiscing elit. Vestibulum consectetur.
  ipiscing elit. Vestibulum consectetur.
  iscing elit. Vestibulum consectetur.
  ing elit. Vestibulum consectetur.
  it. Vestibulum consectetur.
  ibulum consectetur.
  Insere o teu primeiro nome:          Nelson
  Insere o teu último nome:    Silva
  Nome (sem o uso do método Trim()):          Nelson          Silva
  Nome (com o uso do método Trim()): Nelson Silva
*/
