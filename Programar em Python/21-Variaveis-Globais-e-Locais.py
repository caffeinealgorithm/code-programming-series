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
