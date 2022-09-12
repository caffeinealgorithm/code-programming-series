// YouTube: https://youtu.be/mPUUj1xwe7U
// Publicação: https://caffeinealgorithm.com/blog/interfaces-em-csharp/

using System;

namespace Base {
  class Interfaces {
    public void Run() {
      var carro = new Carro("Nissan", "Juke", "Dianteira", "Manual", "Gasóleo", 1461, 175, 110, 25070);
      carro.Informacao();

      /*
        Marca: Nissan
        Modelo: Juke
        Localização do motor: Dianteira
        Transmissão: Manual
        Combustível: Gasóleo
        Cilindrada: 1461 cc
        Velocidade máxima: 175 km/h
        Potência máxima: 110 cv
        Preço: 25070 euros
      */
    }
  }

  class Carro : ICarro {
    private string marca, modelo, localizacaoDoMotor, transmissao, combustivel;
    private int cilindrada, velocidadeMaxima, potenciaMaxima;
    private double preco;

    public Carro(string marca, string modelo, string localizacaoDoMotor, string transmissao, string combustivel,
                  int cilindrada, int velocidadeMaxima, int potenciaMaxima, double preco) {
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

    public void Informacao() {
      Console.WriteLine($"Marca: {marca}");
      Console.WriteLine($"Modelo: {modelo}");
      Console.WriteLine($"Localização do motor: {localizacaoDoMotor}");
      Console.WriteLine($"Transmissão: {transmissao}");
      Console.WriteLine($"Combustível: {combustivel}");
      Console.WriteLine($"Cilindrada: {cilindrada} cc");
      Console.WriteLine($"Velocidade máxima: {velocidadeMaxima} km/h");
      Console.WriteLine($"Potência máxima: {potenciaMaxima} cv");
      Console.WriteLine($"Preço: {preco} euros");
    }
  }

  interface ICarro {
    void Informacao();
  }
}
