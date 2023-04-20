class ContaBancaria:
  def __init__(self, titular, numConta):
    self.__titular = "sem nome"
    self.__numConta = "sem número"
    self.__saldo = 0
    if titular != "": self.__titular = titular
    if numConta != "": self.__numConta = numConta  
  def SetTitular(self, titular): 
    if titular != "": self.__titular = titular
  def SetNumConta(self, numConta): 
    if numConta != "": self.__numConta = numConta
  def Depositar(self, v): 
    if v < 0: raise ValueError() 
    if v > 0: self.__saldo += v
  def Sacar(self, v):
    if v < 0: raise ValueError() 
    if v > 0 and v <= self.__saldo:
      self.__saldo -= v
      return True
    return False
  def GetTitular(self):
    return self.__titular
  def GetNumConta(self):
    return self.__numConta
  def GetSaldo(self):
    return self.__saldo
  def __str__(self):
    return f"{self.__titular} {self.__numConta} {self.__saldo:.2f}"

x = ContaBancaria("Gilbert", "1234")
print(x.GetTitular())
print(x.GetNumConta())
print(x.GetSaldo())
x.Depositar(1000)
print(x.GetSaldo())
if (x.Sacar(1400)): print(x.GetSaldo())
else: print("Saldo insuficiente")
print(x);