# YouTube: https://youtu.be/Ux328aoXQYM
# Publicação: https://caffeinealgorithm.com/blog/dicionarios-em-python/

idades = {'Nelson Silva': 25, 'Larissa Fernandes': 37, 'Pedro Henrique': 52, 'Raquel Soares': 68}

idades['Pedro Henrique'] = 100
del idades['Larissa Fernandes']
# idades.clear()

print(idades) # {'Nelson Silva': 25, 'Pedro Henrique': 100, 'Raquel Soares': 68}
print(idades.items()) # dict_items([('Nelson Silva', 25), ('Pedro Henrique', 100), ('Raquel Soares', 68)])
print(idades.keys()) # dict_keys(['Nelson Silva', 'Pedro Henrique', 'Raquel Soares'])
print(idades.values()) # dict_values([25, 100, 68])
