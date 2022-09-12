// YouTube: https://youtu.be/QnhCVLqYcJM
// Publicação: https://caffeinealgorithm.com/blog/classe-hashtable-em-csharp/

using System;
using System.Collections;

namespace Base {
  class ClasseHashtable {
    private Hashtable pessoas = new Hashtable() {
      { "Nelson Silva", 25 },
      { "Larissa Fernandes", 37 }
    };

    public void Run() {
      pessoas.Add("Pedro Henrique", 52);
      pessoas.Add("Raquel Soares", 68);

      pessoas["Pedro Henrique"] = 100;
      pessoas.Remove("Larissa Fernandes");
      pessoas.Clear();

      Console.WriteLine($"Número de pessoas: {pessoas.Count}");

      foreach (DictionaryEntry pessoa in pessoas) {
        Console.WriteLine($"Nome: {pessoa.Key}");
        Console.WriteLine($"Idade: {pessoa.Value}");
      }
    }
  }
}

/*
  Número de pessoas: 3
  Nome: Raquel Soares
  Idade: 68
  Nome: Nelson Silva
  Idade: 25
  Nome: Pedro Henrique
  Idade: 100
*/
