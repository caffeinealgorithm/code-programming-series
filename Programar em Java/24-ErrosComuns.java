// YouTube: https://youtu.be/HCclW4TLSyY
// Publicação: https://caffeinealgorithm.com/blog/20220309/erros-comuns-em-java/

package com.caffeinealgorithm.programaremjava;

import java.util.Scanner;

public class ErrosComuns {
  public void Run() {
    // Erro de compilação
    System.out.println("Eu sou uma string.");

    // Erro de tempo de execução
    int x = 10, y = 0;
    // System.out.printf("Resultado da divisão: %d", x / y);

    // Erro de lógica
    Scanner inputDoUtilizador = new Scanner(System.in);
    String primeiroNome = null, ultimoNome = null;

    System.out.print("Insere o teu último nome: ");
    ultimoNome = inputDoUtilizador.nextLine();

    System.out.printf("Nome: %s %s", primeiroNome, ultimoNome);
  }
}
