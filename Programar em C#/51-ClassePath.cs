// YouTube: https://youtu.be/8wAijtTtazs
// Publicação: https://caffeinealgorithm.com/blog/classe-path-em-csharp/

using System;
using System.IO;

namespace Base {
  class ClassePath {
    private const string Ficheiro = "Ficheiro.txt";

    public void Run() {
      Console.WriteLine($"Nome do ficheiro com a extensão: {Path.GetFileName(Ficheiro)}");
      Console.WriteLine($"Nome do ficheiro sem a extensão: {Path.GetFileNameWithoutExtension(Ficheiro)}");
      Console.WriteLine($"Extensão do ficheiro: {Path.GetExtension(Ficheiro)}");
      Console.WriteLine($"Caminho absoluto até ao ficheiro: {Path.GetFullPath(Ficheiro)}");
    }
  }
}

/*
  Nome do ficheiro com a extensao: Ficheiro.txt
  Nome do ficheiro sem a extensao: Ficheiro
  Extensao do ficheiro: .txt
  Caminho absoluto até ao ficheiro: ...\Ficheiro.txt
*/
