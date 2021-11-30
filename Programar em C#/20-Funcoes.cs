// YouTube: https://youtu.be/61T_m11jCWs
// Publicação: https://caffeinealgorithm.com/blog/20211130/funcoes-em-csharp/

using System;

namespace Base {
  class Funcoes {
    public void Run() {
      DadosPessoais();
      DadosPessoais();
      DadosPessoais();
    }

    public void DadosPessoais() {
      Console.WriteLine("Nome: Nelson Silva");
      Console.WriteLine("Idade: 25");
      Console.WriteLine("Nacionalidade: Portuguesa");
    }
  }
}

/*
  Nome: Nelson Silva
  Idade: 25
  Nacionalidade: Portuguesa
  Nome: Nelson Silva
  Idade: 25
  Nacionalidade: Portuguesa
  Nome: Nelson Silva
  Idade: 25
  Nacionalidade: Portuguesa
*/
