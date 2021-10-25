class Pessoa:
  def __init__(self, primeiroNome, ultimoNome, idade):
    self.primeiroNome = primeiroNome
    self.ultimoNome = ultimoNome
    self.idade = idade

  def informacao(self):
    print('Nome:', self.primeiroNome, self.ultimoNome)
    print('Idade:', self.idade)

  def verificarEntrada(self):
    if self.idade >= 18:
      print('Esta pessoa pode entrar no local porque é maior de idade.')
    else:
      print('Esta pessoa não pode entrar no local porque é menor de idade.')

pessoa1 = Pessoa('Nelson', 'Silva', 25)
pessoa2 = Pessoa('Larissa', 'Fernandes', 17)

pessoa1.informacao()
pessoa1.verificarEntrada()

'''
  Nome: Nelson Silva
  Idade: 25
  Esta pessoa pode entrar no local porque é maior de idade.
'''

pessoa2.informacao()
pessoa2.verificarEntrada()

'''
  Nome: Larissa Fernandes
  Idade: 17
  Esta pessoa não pode entrar no local porque é menor de idade.
'''
