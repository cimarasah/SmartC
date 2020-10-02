using SmartC.ApplicationCore.Enuns;
using System;

namespace SmartC.ApplicationCore.Entities
{
    public class Sessao
    {
        public int Id { get; set; }

        public int IdProfissional { get; set; }
        public int IdItemVenda { get; set; }
        public virtual ItemVenda ItemVenda { get; set; }
        public virtual Profissional Profissional { get; set; }
        public SituacaoSessaoEnum Situacao { get; set; }
        public DateTime DataHoraSessao { get; set; }
        public int NumeroSessao { get; set; }
    }
}