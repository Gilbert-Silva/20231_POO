#include <iostream>

using namespace std;

class Aluno {
  private:
    string nome, matricula;
  public:
    void SetNome(string nome) {
      this->nome = nome;
    }
    void SetMatricula(string matricula) {
      this->matricula = matricula;
    }
    string ToString() { 
      return nome + " " + matricula ;}
};

int main() {
  Aluno a;
  a.SetNome("Gilbert");
  a.SetMatricula("1234");
  cout << a.ToString() << endl;
  Aluno b = a;
  cout << b.ToString() << endl;
  b.SetNome("Eduardo");
  cout << a.ToString() << endl;
  cout << b.ToString() << endl;

  Aluno *c = new Aluno();
  c->SetNome("Jorgiano");
  c->SetMatricula("4321");
  cout << c->ToString() << endl;
  delete c;
  c = &a;
  cout << c->ToString() << endl;

  cout << &a << endl;
  cout << &b << endl;
  cout << &c << endl;
  cout << c << endl;
}