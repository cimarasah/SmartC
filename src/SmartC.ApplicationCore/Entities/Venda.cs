using SmartC.ApplicationCore.Enuns;
using System;
using System.Collections.Generic;
using System.Text;

namespace SmartC.ApplicationCore.Entities
{
    public class Venda
    {
        public int Id { get; set; }
        public int IdPaciente { get; set; }
        public int IdProfissional { get; set; }
        public Paciente Paciente { get; set; }
        public Profissional Profissional { get; set; }
        public double ValorTotal { get; set; }
        public double Desconto { get; set; }
        public DateTime DataHora { get; set; }
        public int QuantidadeItens { get; set; }
        public List<ItemVenda> ItensVenda { get; set; }
    }
}
