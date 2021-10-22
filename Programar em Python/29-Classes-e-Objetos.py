class Inimigo:
  vidas = 5

  def ataque(self):
    print('Eu fui atacado e perdi uma vida.')
    self.vidas -= 1

  def verificarVida(self):
    if self.vidas <= 0:
      print('Eu estou morto porque não tenho mais vidas.')
    else:
      print('Eu ainda estou em combate e tenho', self.vidas, 'vidas.')

inimigo1 = Inimigo()
inimigo2 = Inimigo()

inimigo1.ataque() # Eu fui atacado e perdi uma vida.
inimigo1.ataque() # Eu fui atacado e perdi uma vida.
inimigo1.ataque() # Eu fui atacado e perdi uma vida.
inimigo1.verificarVida() # Eu ainda estou em combate e tenho 2 vidas.
inimigo2.verificarVida() # Eu ainda estou em combate e tenho 5 vidas.
