// YouTube: https://youtu.be/QjvCyY5a2BM
// Publicação: https://caffeinealgorithm.com/blog/20211224/propriedades-em-csharp/

using System;

namespace Base {
  class Program {
    static void Main(string[] args) {
      var pessoa = new Propriedades();

      pessoa.PrimeiroNome = "Nelson";
      pessoa.UltimoNome = "Silva";
      pessoa.Informacao();
      Console.WriteLine($"Idade: {pessoa.idade}");

      /*
        Nome: Nelson Silva
        Idade: 25
      */

      Console.ReadKey();
    }
  }
}

/* --- */

using System;

namespace Base {
  class Propriedades {
    private string primeiroNome = string.Empty, ultimoNome = string.Empty;
    private int idade = 25;
    // public int variavel { get; set; }

    public string PrimeiroNome {
      set {
        if (value != string.Empty)
          primeiroNome = value;
        else
          Console.WriteLine("A string referente ao primeiro nome não pode estar vazia.");
      }
    }

    public string UltimoNome {
      set {
        if (value != string.Empty)
          ultimoNome = value;
        else
          Console.WriteLine("A string referente ao último nome não pode estar vazia.");
      }
    }

    public int Idade { get => idade; }

    public void Informacao() {
      Console.WriteLine($"Nome: {primeiroNome} {ultimoNome}");
    }
  }
}
