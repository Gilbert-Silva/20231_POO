using System;

enum Pagamento { EmAberto, PagoParcial, Pago }

class Boleto {
  private string codBarras;
  private DateTime dataEmissao, dataVenc, dataPagto;
  private double valorBoleto, valorPago;
  private Pagamento situacaoPagto;
  public Boleto(string codBarras, DateTime dataEmissao, 
    DateTime dataVenc, double valor) {
    this.codBarras = codBarras;
    this.dataEmissao = dataEmissao;
    this.dataVenc = dataVenc;
    this.valorBoleto = valor;
    this.valorPago = 0;
    this.situacaoPagto = Pagamento.EmAberto;    
  }
  public void Pagar(double valorPago) {
    this.valorPago = valorPago;
    this.dataPagto = DateTime.Now;
    if (valorPago < valorBoleto) this.situacaoPagto = Pagamento.PagoParcial;
    else this.situacaoPagto = Pagamento.Pago;
  }
  public Pagamento Situacao() {
    return situacaoPagto;
  }
  public override string ToString() {
    return $"{codBarras} - {dataEmissao:dd/MM/yyyy} - {dataVenc:dd/MM/yyyy} - " +
      $"{dataPagto:dd/MM/yyyy} - {valorBoleto:0.00} - {valorPago:0.00}";
  }
}

class Program {
  public static void Main() {
    Boleto b = new Boleto("1234", DateTime.Parse("2023-05-01"), 
      DateTime.Parse("2023-05-15"), 248.43);
    Console.WriteLine(b);
    Console.WriteLine(b.Situacao());
    b.Pagar(100);
    Console.WriteLine(b);
    Console.WriteLine(b.Situacao());
  }
}