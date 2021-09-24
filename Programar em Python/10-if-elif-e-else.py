'''
  (if - se) condição for verdadeira:
    o código dentro do if é executado
  (elif - senão se) condição for verdadeira (só ocorre o elif caso a condição de if seja falsa):
    o código dentro do elif é executado
  (else - senão) sem condição (só ocorre caso a condição de if e de elif sejam falsas):
    o código dentro do else é executado
'''

x = 30

if x == 10:
  print('O valor de x é igual a 10.')
elif x == 20:
  print('O valor de x é igual a 20.')
else:
  print('O valor de x é diferente de 10 e de 20.')

# O valor de x é diferente de 10 e de 20.
