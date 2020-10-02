using SmartC.ApplicationCore.Enuns;
using System;
using System.Collections.Generic;
using System.Text;

namespace SmartC.ApplicationCore.Entities
{
    public class PagamentoVenda
    {
        public int Id { get; set; }
        public int IdVenda { get; set; }
        public Venda Venda { get; set; }
        public DateTime DataPagamento { get; set; }
        public double Valor { get; set; }
        public bool Status { get; set; }
        public FormaPagamentoEnum FormaPagamento { get; set; }
    }
}
