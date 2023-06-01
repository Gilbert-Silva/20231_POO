v = [ 2, 6, 3, 4, 8 ]
print(v)
v.sort()
print(v)
print(2 < 5)

class Aluno:
  def __init__(self, nome, mat):
    self.Nome = nome
    self.Mat = mat;
  def __str__(self):
    return f"{self.Nome} - {self.Mat}"
  def __gt__(self, outro):
    return self.Nome > outro.Nome

a = Aluno("José Vinicius", "1234")
b = Aluno("Isis", "8888")
c = Aluno("Gilbert", "4444")
w = [ a, b, c ]
print(a < b)
w.sort()
for a in w:
  print(a)
