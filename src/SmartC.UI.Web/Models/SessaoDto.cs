using SmartC.ApplicationCore.Enuns;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartC.UI.Web.Models
{
    public class SessaoDto
    {
        public int Id { get; set; }
        public ItemVendaDto ItemVenda { get; set; }
        public ProfissionalDto Profissional { get; set; }
        public SituacaoSessaoEnum Situacao { get; set; }
        public DateTime DataHoraSessao { get; set; }
        public int NumeroSessao { get; set; }
    }
}
