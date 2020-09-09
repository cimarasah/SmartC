using System.Collections.Generic;

namespace SmartC.ApplicationCore.Entities
{
    public class ItemVenda
    {
        public int IdItemVenda { get; set; }
        public int IdVenda { get; set; }
        public int IdItemClinica { get; set; }
        public ItemClinica ItemClinica { get; set; }
        public Venda Venda { get; set; }
        public double Valor { get; set; }
        public int QuantidadeItem { get; set; }
        public List<Sessao> Sessoes { get; set; }
    }
}