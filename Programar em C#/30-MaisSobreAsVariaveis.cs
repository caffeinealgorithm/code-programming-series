// YouTube: https://youtu.be/uMbksPhe4m0
// Publicação: https://caffeinealgorithm.com/blog/mais-sobre-as-variaveis-em-csharp/

using System;

namespace Base {
  class MaisSobreAsVariaveis {
    public void Run() {
      /*
        byte _byte = 255;
        sbyte _sbyte = 127;
        decimal _decimal = 10.0M;
        float _float = 10.0F;
        uint _uint = 4000000000;
        long _long = 9000000000000000000;
        ulong _ulong = 18000000000000000000;
        short _short = 32000;
        ushort _ushort = 65000;
      */

      var variavel = "Eu sou uma string.";
      Console.WriteLine($"Conteúdo inicial: {variavel}");
      Console.WriteLine($"Conteúdo final: {variavel}");
    }
  }
}

/*
  Conteúdo inicial: Eu sou uma string.
  Conteúdo final: Eu sou uma string.
*/
