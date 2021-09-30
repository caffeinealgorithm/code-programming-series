animais = ['Cão', 'Gato', 'Galinha', 'Coelho', 'Leão']
contador = 0

for animal in animais:
  print('Animal:', animal)

  if animal == 'Coelho':
    break

'''
  Animal: Cão
  Animal: Gato
  Animal: Galinha
  Animal: Coelho
'''

while contador < 10:
  contador += 1

  if contador == 5:
    continue

  print('Número da volta:', contador)

'''
  Número da volta: 1
  Número da volta: 2
  Número da volta: 3
  Número da volta: 4
  Número da volta: 6
  Número da volta: 7
  Número da volta: 8
  Número da volta: 9
  Número da volta: 10
'''
