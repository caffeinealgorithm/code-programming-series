// YouTube: https://youtu.be/-C6_spcZYAs
// Publicação: https://caffeinealgorithm.com/blog/20211115/funcao-readline-em-csharp/

using System;

namespace Base {
  class FuncaoReadLine {
    public void Run() {
      string primeiroNome, ultimoNome;
      int idade;

      Console.Write("Insere o teu primeiro nome: ");
      primeiroNome = Console.ReadLine();

      Console.Write("Insere o teu último nome: ");
      ultimoNome = Console.ReadLine();

      Console.Write("Insere a tua idade: ");
      idade = int.Parse(Console.ReadLine());

      Console.WriteLine($"Nome: {primeiroNome} {ultimoNome}\nIdade: {idade}");
    }
  }
}
