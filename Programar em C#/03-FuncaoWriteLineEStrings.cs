// YouTube: https://youtu.be/2-dIbl35A_w
// Publicação: https://caffeinealgorithm.com/blog/20211105/funcao-writeline-e-strings-em-csharp/

using System;

namespace Base {
  class Program {
    static void Main(string[] args) {
      var video = new FuncaoWriteLineEStrings();
      video.Run();
      Console.ReadKey();
    }
  }
}

/* --- */

using System;

namespace Base {
  class FuncaoWriteLineEStrings {
    public void Run() {
      Console.Write("Estamos a usar a função Write() e eu sou uma string.");
      Console.WriteLine("Estamos a usar a função WriteLine() e eu continuo a ser uma string.");
      Console.WriteLine("Estamos a usar novamente a função WriteLine() e eu continuo a ser uma string.");
    }
  }
}
