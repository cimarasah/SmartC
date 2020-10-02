using SmartC.ApplicationCore.Enuns;
using System;
using System.Collections.Generic;
using System.Text;

namespace SmartC.ApplicationCore.Entities
{
    public class Movimentacao
    {
        public int Id { get; set; }
        public int IdCaixa { get; set; }
        public Caixa Caixa { get; set; }
        public DateTime DataMovimentacao { get; set; }
        public double Valor { get; set; }
        public TipoMovimentacaoEnum TipoMovimentacao { get; set; }
    }
}
