# YouTube: https://youtu.be/YPjiLWtky60
# Publicação: https://caffeinealgorithm.com/blog/listas-em-python/

lista = ['Eu sou uma string.', 10, 10.5, True, ['A', 'B', 'C']]

lista[0] = 'Eu continuo a ser uma string na mesma.'

print('Fatiamento:', lista[2:3]) # Fatiamento: [10.5]
print('Conteúdo da lista:', lista)
print('Número de elementos da lista:', len(lista[4])) # Número de elementos da lista: 3
