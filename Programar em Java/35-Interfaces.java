// YouTube: https://youtu.be/0I7MyvAkBK0
// Publicação: https://caffeinealgorithm.com/blog/interfaces-em-java/

package com.caffeinealgorithm.programaremjava;

public class Interfaces {
  public void Run() {
    var carro = new Carro("Nissan", "Juke", "Dianteira", "Manual", "Gasóleo", 1461, 175, 110, 25070);
    carro.informacao();

    /*
      Marca: Nissan
      Modelo: Juke
      Localização do motor: Dianteira
      Transmissão: Manual
      Combustível: Gasóleo
      Cilindrada: 1461 cc
      Velocidade máxima: 175 km/h
      Potência máxima: 110 cv
      Preço: 25070.00 euros
    */
  }
}

class Carro implements ICarro {
  private String marca, modelo, localizacaoDoMotor, transmissao, combustivel;
  private int cilindrada, velocidadeMaxima, potenciaMaxima;
  private double preco;

  public Carro(String marca, String modelo, String localizacaoDoMotor, String transmissao,
               String combustivel, int cilindrada, int velocidadeMaxima, int potenciaMaxima, double preco) {
    this.marca = marca;
    this.modelo = modelo;
    this.localizacaoDoMotor = localizacaoDoMotor;
    this.transmissao = transmissao;
    this.combustivel = combustivel;
    this.cilindrada = cilindrada;
    this.velocidadeMaxima = velocidadeMaxima;
    this.potenciaMaxima = potenciaMaxima;
    this.preco = preco;
  }

  public void informacao() {
    System.out.printf("Marca: %s\n", marca);
    System.out.printf("Modelo: %s\n", modelo);
    System.out.printf("Localização do motor: %s\n", localizacaoDoMotor);
    System.out.printf("Transmissão: %s\n", transmissao);
    System.out.printf("Combustível: %s\n",combustivel);
    System.out.printf("Cilindrada: %d cc\n", cilindrada);
    System.out.printf("Velocidade máxima: %d km/h\n", velocidadeMaxima);
    System.out.printf("Potência máxima: %d cv\n", potenciaMaxima);
    System.out.printf("Preço: %.2f euros", preco);
  }
}

interface ICarro {
  void informacao();
}
