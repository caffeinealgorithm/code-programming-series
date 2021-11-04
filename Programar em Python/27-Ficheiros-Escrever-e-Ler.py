# YouTube: https://youtu.be/Hh8eV7n5ieg
# Publicação: https://caffeinealgorithm.com/blog/20211020/ficheiros-escrever-e-ler-em-python/

escreverFicheiro = open('Ficheiros-Escrever-e-Ler.txt', 'w')
escreverFicheiro.write('Eu estou a escrever na primeira linha deste ficheiro.\n')
escreverFicheiro.write('Agora estou a escrever na segunda linha.')
escreverFicheiro.close()

lerFicheiro = open('Ficheiros-Escrever-e-Ler.txt', 'r')
print(lerFicheiro.read())

'''
  Eu estou a escrever na primeira linha deste ficheiro.
  Agora estou a escrever na segunda linha.
'''

lerFicheiro.close()
