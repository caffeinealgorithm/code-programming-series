# YouTube: https://youtu.be/K6-_AwbMk34
# Publicação: https://caffeinealgorithm.com/blog/variaveis-globais-e-locais-em-python/

acesso = 'Global'

def mudarAcesso():
  acesso = 'Local'
  print('Acesso no interior da função:', acesso)

mudarAcesso()
print('Acesso no exterior da função:', acesso)

'''
  Acesso no interior da função: Local
  Acesso no exterior da função: Global
'''
