// YouTube: https://youtu.be/pKGz-CCpye8
// Publicação: https://caffeinealgorithm.com/blog/20211111/mais-sobre-as-strings-em-csharp/

using System;

namespace Base {
  class MaisSobreAsStrings {
    public void Run() {
      string primeiroNome = "Nelson";
      string ultimoNome = "Silva";
      int idade = 25;

      Console.WriteLine($"Nome: {primeiroNome} {ultimoNome}\nIdade: {idade}");

      /*
        Nome: Nelson Silva
        Idade: 25
      */
    }
  }
}
