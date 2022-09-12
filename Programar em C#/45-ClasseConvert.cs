// YouTube: https://youtu.be/7nJbm-CN2XY
// Publicação: https://caffeinealgorithm.com/blog/classe-convert-em-csharp/

using System;

namespace Base {
  class ClasseConvert {
    private string letra = "N", anoAtual = "2021";
    private char _letra = ' ';
    private int _anoAtual = 0;

    public void Run() {
      try {
        _letra = Convert.ToChar(letra);
        _anoAtual = Convert.ToInt32(anoAtual);
      }
      catch (Exception excecao) {
        Console.WriteLine(excecao);
      }
      finally {
        if (_letra != ' ')
          Console.WriteLine($"Letra: {_letra}");

        if (_anoAtual != 0)
          Console.WriteLine($"Ano atual: {_anoAtual}");
      }
    }
  }
}

/*
  Letra: N
  Ano atual: 2021
*/
