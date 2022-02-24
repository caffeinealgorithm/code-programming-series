// YouTube: https://youtu.be/445d_X4N6OI
// Publicação: https://caffeinealgorithm.com/blog/20220224/switch-em-java/

package com.caffeinealgorithm.programaremjava;

public class Switch {
  public void Run() {
    char caso = 'D';

    switch (caso) {
      case 'A':
        System.out.println("O caso A existe.");
        break;
      case 'B':
        System.out.println("O caso B existe.");
        break;
      case 'C':
        System.out.println("O caso C existe.");
        break;
      default:
        System.out.printf("O caso %c não existe.", caso);
        break;
    }
  }
}

// O caso D não existe.
