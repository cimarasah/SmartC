using System.Collections.Generic;

namespace SmartC.ApplicationCore.Entities
{
    public class Servico
    {
        public int Id { get; set; }
        public int IdItemClinica { get; set; }
        public ItemClinica ItemClinica { get; set; }
        public int QtdMinimaSessoes { get; set; }
        public int TempoMinimoSessao { get; set; }
        public double ValorSessao { get; set; }

        public virtual IEnumerable<ItemPacote> ItensPacote { get; set; }
    }
}