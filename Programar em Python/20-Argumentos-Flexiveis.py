# YouTube: https://youtu.be/LhcLdqNjvpc
# Publicação: https://caffeinealgorithm.com/blog/argumentos-flexiveis-em-python/

def imprimirArgumentos(*argumentos):
  for argumento in argumentos:
    print('Argumento:', argumento)

imprimirArgumentos('Eu sou uma string.', 1, 1.5, True, ['ABC', 'DEF', 'GHI'])

'''
  Argumento: Eu sou uma string.
  Argumento: 1
  Argumento: 1.5
  Argumento: True
  Argumento: ['ABC', 'DEF', 'GHI']
'''
