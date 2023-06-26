using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.IO;

class NUsuario {
  private static List<Usuario> usuarios = new List<Usuario>();
  public static Usuario EntrarSistema(string nome, string senha) {
    foreach(Usuario obj in usuarios)
      if (obj.Nome == nome && obj.Senha == senha) return obj;
    return null;
  }
  public static List<Usuario> Listar() {
    return usuarios;
  }
  public static Usuario Listar(int id) {
    foreach(Usuario obj in usuarios)
      if (obj.Id == id) return obj;
    return null;
  }
  public static void Inserir(Usuario c) {
    int id = 0;
    foreach(Usuario obj in usuarios)
      if (obj.Id > id) id = obj.Id;
    id++;
    c.Id = id;
    usuarios.Add(c);    
  }
  public static void Atualizar(Usuario c) {
    Usuario obj = Listar(c.Id);
    if (obj != null) {
      obj.Nome = c.Nome;
      obj.Senha = c.Senha;
      obj.Admin = c.Admin;
    }
  }
  public static void Excluir(Usuario c) {
    Usuario obj = Listar(c.Id);
    if (obj != null) usuarios.Remove(obj);
  }
  public static void Salvar() {
    XmlSerializer xml = new XmlSerializer(typeof(List<Usuario>)); 
    using (StreamWriter f = new StreamWriter("usuarios.xml")) {
      xml.Serialize(f, usuarios);
    }
  }
  public static void Abrir() {
    XmlSerializer xml = new XmlSerializer(typeof(List<Usuario>)); 
    StreamReader f = null;
    try {
      f = new StreamReader("usuarios.xml");
      usuarios = (List<Usuario>) xml.Deserialize(f);
    }
    catch {
      usuarios = new List<Usuario>();
    }
    finally {
      if (f != null) f.Close();
    }
  }
}