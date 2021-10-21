try:
  lerFicheiro = open('Ficheiros-Escrever-e-Ler.txt', 'r')
  print(lerFicheiro.read())
except IOError:
  print('O ficheiro não existe e/ou não é possível ler o seu conteúdo.')
else:
  print('O ficheiro foi lido com sucesso.')
  lerFicheiro.close()

print('Eu sei que ocorreu um erro, no entanto, o meu conteúdo ainda é apresentado na linha de comandos.')
