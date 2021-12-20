// YouTube: https://youtu.be/9FNQUgfBUz8
// Publicação: https://caffeinealgorithm.com/blog/20211220/classes-e-objetos-em-csharp/

using System;

namespace Base {
  class Program {
    static void Main(string[] args) {
      var inimigo1 = new ClassesEObjetos();
      var inimigo2 = new ClassesEObjetos();

      inimigo1.Ataque(); // Eu fui atacado e perdi uma vida.
      inimigo1.Ataque(); // Eu fui atacado e perdi uma vida.
      inimigo1.Ataque(); // Eu fui atacado e perdi uma vida.
      inimigo1.VerificarVida(); // Eu ainda estou em combate e tenho 2 vidas.
      inimigo2.VerificarVida(); // Eu ainda estou em combate e tenho 5 vidas.

      Console.ReadKey();
    }
  }
}

/* --- */

using System;

namespace Base {
  class ClassesEObjetos {
    int vidas = 5;

    public void Ataque() {
      Console.WriteLine("Eu fui atacado e perdi uma vida.");
      vidas -= 1;
    }

    public void VerificarVida() {
      if (vidas <= 0)
        Console.WriteLine("Eu estou morto porque não tenho mais vidas.");
      else
        Console.WriteLine($"Eu ainda estou em combate e tenho {vidas} vidas.");
    }
  }
}
