// YouTube: https://youtu.be/7Hjm23B-quw
// Publicação: https://caffeinealgorithm.com/blog/classe-streamwriter-em-csharp/

using System.Collections.Generic;
using System.IO;

namespace Base {
  class ClasseStreamWriter {
    private StreamWriter escreverFicheiro;
    private List<string> paises = new List<string>() {
      "Portugal",
      "Brasil",
      "Espanha",
      "França",
      "Itália",
      "Austrália",
      "Índia"
    };

    public void Run() {
      /*
        escreverFicheiro = new StreamWriter("Ficheiro.txt");

        foreach (var pais in paises)
          escreverFicheiro.WriteLine(pais);

        escreverFicheiro.Close();
      */

      using (escreverFicheiro = new StreamWriter("Ficheiro.txt")) {
        foreach (var pais in paises)
          escreverFicheiro.WriteLine(pais);
      }
    }
  }
}
