// YouTube: https://youtu.be/DU1TJ_QGS_s
// Publicação: https://caffeinealgorithm.com/blog/classe-debug-em-csharp/

using System.Diagnostics;

namespace Base {
  class ClasseDebug {
    private string[] cores = new string[] {
      "Azul",
      "Verde",
      "Amarelo",
      "Vermelho",
      "Laranja"
    };

    public void Run() {
      for (int indice = 0; indice < cores.Length; indice++)
        Debug.WriteLine($"cores[{indice}]: {cores[indice]}");
    }
  }
}
