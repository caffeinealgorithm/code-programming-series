// YouTube: https://youtu.be/8q8-qNsEZGs
// Publicação: https://caffeinealgorithm.com/blog/dicionarios-em-csharp/

using System;
using System.Collections.Generic;

namespace Base {
  class Dicionarios {
    public void Run() {
      Dictionary<string, int> pessoas = new Dictionary<string, int>() {
        { "Nelson Silva", 25 },
        { "Larissa Fernandes", 37 }
      };

      pessoas.Add("Pedro Henrique", 52);
      pessoas.Add("Raquel Soares", 68);
      pessoas["Pedro Henrique"] = 100;
      pessoas.Remove("Larissa Fernandes");
      // pessoas.Clear();

      Console.WriteLine($"Número de pessoas: {pessoas.Count}\n");

      foreach (KeyValuePair<string, int> pessoa in pessoas) {
        Console.WriteLine($"Nome: {pessoa.Key}");
        Console.WriteLine($"Idade: {pessoa.Value}");
      }
    }
  }
}

/*
  Número de pessoas: 3

  Nome: Nelson Silva
  Idade: 25
  Nome: Pedro Henrique
  Idade: 100
  Nome: Raquel Soares
  Idade: 68
*/
