// YouTube: https://youtu.be/mrbE0tQqbtQ
// Publicação: https://caffeinealgorithm.com/blog/argumentos-em-csharp/

using System;

namespace Base {
  class Argumentos {
    public void Run() {
      DadosPessoais("Nelson Silva", 25, "Portuguesa");
      DadosPessoais("Larissa Fernandes", 37, "Brasileira");
    }

    public void DadosPessoais(string nome, int idade, string nacionalidade) {
      Console.WriteLine($"Nome: {nome}");
      Console.WriteLine($"Idade: {idade}");
      Console.WriteLine($"Nacionalidade: {nacionalidade}");
    }
  }
}

/*
  Nome: Nelson Silva
  Idade: 25
  Nacionalidade: Portuguesa
  Nome: Larissa Fernandes
  Idade: 37
  Nacionalidade: Brasileira
*/
