// YouTube: https://youtu.be/d1Fp1_jjPsE
// Publicação: https://caffeinealgorithm.com/blog/classe-scanner-em-java/

package com.caffeinealgorithm.programaremjava;

import java.util.Scanner;

public class ClasseScanner {
  public void Run() {
    Scanner inputDoUtilizador = new Scanner(System.in);
    String primeiroNome, ultimoNome;
    int idade;

    System.out.print("Insere o teu primeiro nome: ");
    primeiroNome = inputDoUtilizador.nextLine();

    System.out.print("Insere o teu último nome: ");
    ultimoNome = inputDoUtilizador.nextLine();

    System.out.print("Insere a tua idade: ");
    idade = inputDoUtilizador.nextInt();

    System.out.printf("Nome: %s %s\nIdade: %d", primeiroNome, ultimoNome, idade);
  }
}
