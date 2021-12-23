// YouTube: https://youtu.be/06RgzwoqPDU
// Publicação: https://caffeinealgorithm.com/blog/20211223/mais-sobre-as-excecoes-em-csharp/

using System;

namespace Base {
  class MaisSobreAsExcecoes {
    private Exception stringVazia = new Exception("Não se pode verificar uma string que esteja vazia.");

    public void Run() {
      try {
        VerificarString("Nelson Silva");
      }
      catch (Exception excecao) {
        Console.WriteLine(excecao);
      }
    }

    private void VerificarString(string _string) {
      if (_string == string.Empty)
        throw stringVazia;
    }
  }
}
