# YouTube: https://youtu.be/hCaynUtCvEw
# Publicação: https://caffeinealgorithm.com/blog/20211029/map-em-python/

'''
  print(pow(2, 12))
  print(pow(3, 13))
  print(pow(4, 14))
'''

x = [2, 3, 4]
y = [12, 13, 14]

print(list(map(pow, x, y))) # [4096, 1594323, 268435456]
