class Jogador:
  def __init__(self):
    self.__nome = "sem nome"
    self.__camisa = 0
    self.__num_gols = 0

  @property      #get
  def nome(self):
    return self.__nome

  @nome.setter   #set
  def nome(self, n):
    if n != "": self.__nome = n
    else: raise ValueError()

  def __str__(self):
    return f"{self.__nome} - camisa:{self.__camisa} - gols:{self.__num_gols}"
    
j = Jogador()
j.nome = "jogador" # set
print(j.nome)      # get
