# YouTube: https://youtu.be/e4N5AHTSKG0
# Publicação: https://caffeinealgorithm.com/blog/20211027/multipla-heranca-em-python/

class Pai:
  altura = 'Entre 180 e 190 centímetros'
  corDosOlhos = 'Castanhos'

class Mae:
  def corPreferida(self):
    print('A minha cor preferida é o branco.')

class Filho(Pai, Mae):
  def informacao(self):
    print('Nome: Nelson Silva')
    print('Idade: 25')
    print('Altura:', self.altura)
    print('Cor dos olhos:', self.corDosOlhos)

pessoa = Filho()
pessoa.informacao()
pessoa.corPreferida()

'''
  Nome: Nelson Silva
  Idade: 25
  Altura: Entre 180 e 190 centímetros
  Cor dos olhos: Castanhos
  A minha cor preferida é o branco.
'''
