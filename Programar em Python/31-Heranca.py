# YouTube: https://youtu.be/7cVfMDDAk64
# Publicação: https://caffeinealgorithm.com/blog/heranca-em-python/

class Pai:
  ultimoNome = 'Silva'

  def comidaPreferida(self):
    print('A minha comida preferida é arroz de marisco.')

class Filho(Pai):
  primeiroNome = 'Nelson'
  idade = 25

  def informacao(self):
    print('Nome:', self.primeiroNome, self.ultimoNome)
    print('Idade:', self.idade)

pessoa = Filho()
pessoa.informacao()
pessoa.comidaPreferida()

'''
  Nome: Nelson Silva
  Idade: 25
  A minha comida preferida é arroz de marisco.
'''
