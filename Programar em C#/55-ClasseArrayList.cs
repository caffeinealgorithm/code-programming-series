// YouTube: https://youtu.be/BKogMn09eBo
// Publicação: https://caffeinealgorithm.com/blog/20220120/classe-arraylist-em-csharp/

using System;
using System.Collections;

namespace Base {
  class ClasseArrayList {
    private ArrayList materiaisEscolares = new ArrayList() {
      "Mochila",
      "Estojo",
      "Lápis",
      "Borracha"
    };

    public void Run() {
      materiaisEscolares.Add("Afia");
      materiaisEscolares.Add("Tesoura");

      materiaisEscolares.Remove("Mochila");
      materiaisEscolares.Reverse();
      // materiaisEscolares.Clear();

      Console.WriteLine($"Número de materiais escolares: {materiaisEscolares.Count}");

      foreach (var materialEscolar in materiaisEscolares)
        Console.WriteLine($"Material escolar: {materialEscolar}");
    }
  }
}

/*
  Número de materiais escolares: 5
  Material escolar: Tesoura
  Material escolar: Afia
  Material escolar: Borracha
  Material escolar: Lápis
  Material escolar: Estojo
*/
