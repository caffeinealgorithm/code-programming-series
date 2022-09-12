// YouTube: https://youtu.be/qEVCtofREBM
// Publicação: https://caffeinealgorithm.com/blog/metodos-ii-em-java/

package com.caffeinealgorithm.programaremjava;

import java.util.Scanner;

public class MetodosII {
  private String loremIpsum = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vestibulum consectetur.";
  private Scanner inputDoUtilizador = new Scanner(System.in);

  public void Run() {
    // indexOf()
    var indice = 0;

    while ((indice = loremIpsum.indexOf('i', indice)) != -1) {
      System.out.println(loremIpsum.substring(indice));
      indice++;
    }

    // trim()
    System.out.print("\nInsere o teu primeiro nome: ");
    var primeiroNome = inputDoUtilizador.nextLine();

    System.out.print("Insere o teu último nome: ");
    var ultimoNome = inputDoUtilizador.nextLine();

    System.out.printf("\nNome (sem o uso do método trim()): %s %s\n", primeiroNome, ultimoNome);
    System.out.printf("\nNome (com o uso do método trim()): %s %s\n", primeiroNome.trim(), ultimoNome.trim());
  }
}

/*
  ipsum dolor sit amet, consectetur adipiscing elit. Vestibulum consectetur.
  it amet, consectetur adipiscing elit. Vestibulum consectetur.
  ipiscing elit. Vestibulum consectetur.
  iscing elit. Vestibulum consectetur.
  ing elit. Vestibulum consectetur.
  it. Vestibulum consectetur.
  ibulum consectetur.
  Insere o teu primeiro nome:          Nelson
  Insere o teu último nome:    Silva
  Nome (sem o uso do método trim()):          Nelson          Silva
  Nome (com o uso do método trim()): Nelson Silva
*/
