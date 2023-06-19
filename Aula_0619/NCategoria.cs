using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.IO;

class NCategoria {
  private static List<Categoria> categorias = new List<Categoria>();
  public static List<Categoria> Listar() {
    return categorias;
  }
  public static Categoria Listar(int id) {
    foreach(Categoria obj in categorias)
      if (obj.Id == id) return obj;
    return null;
  }
  public static void Inserir(Categoria c) {
    int id = 0;
    foreach(Categoria obj in categorias)
      if (obj.Id > id) id = obj.Id;
    id++;
    c.Id = id;
    categorias.Add(c);    
  }
  public static void Atualizar(Categoria c) {
    Categoria obj = Listar(c.Id);
    if (obj != null) obj.Descricao = c.Descricao;
  }
  public static void Excluir(Categoria c) {
    Categoria obj = Listar(c.Id);
    if (obj != null) categorias.Remove(obj);
  }
  public static void Salvar() {
    XmlSerializer xml = new XmlSerializer(typeof(List<Categoria>)); 
    StreamWriter f = new StreamWriter("categorias.xml");
    xml.Serialize(f, categorias);
    f.Close();
  }
}