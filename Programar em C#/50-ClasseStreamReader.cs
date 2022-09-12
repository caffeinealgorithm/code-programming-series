// YouTube: https://youtu.be/NpjrizaL77w
// Publicação: https://caffeinealgorithm.com/blog/classe-streamreader-em-csharp/

using System;
using System.IO;

namespace Base {
  class ClasseStreamReader {
    private StreamReader lerFicheiro;

    public void Run() {
      using (lerFicheiro = new StreamReader("Ficheiro.txt")) {
        var linha = string.Empty;

        /*
          while ((linha = lerFicheiro.ReadLine()) != null)
            Console.WriteLine(linha);
        */

        Console.WriteLine(lerFicheiro.ReadToEnd());
      }
    }
  }
}

/*
  Portugal
  Brasil
  Espanha
  França
  Itália
  Austrália
  Índia
*/
