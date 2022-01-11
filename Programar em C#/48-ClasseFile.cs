// YouTube: https://youtu.be/jW8uXGlFwZo
// Publicação: https://caffeinealgorithm.com/blog/20220111/classe-file-em-csharp/

using System;
using System.IO;

namespace Base {
  class ClasseFile {
    public void Run() {
      // File.Create("Ficheiro-Create.txt");
      // File.Copy("Ficheiro-Create.txt", "Ficheiro-Copy.txt", true);
      // File.Delete("Ficheiro-Copy.txt");
      // File.Move("Ficheiro-Create.txt", "Ficheiro-Move.txt");

      File.Delete("Ficheiro-Move.txt");

      if (File.Exists("Ficheiro-Move.txt"))
        Console.WriteLine("O ficheiro \"Ficheiro-Move.txt\" existe.");
      else
        Console.WriteLine("O ficheiro \"Ficheiro-Move.txt\" não existe.");
    }
  }
}

// O ficheiro "Ficheiro-Move.txt" não existe.
