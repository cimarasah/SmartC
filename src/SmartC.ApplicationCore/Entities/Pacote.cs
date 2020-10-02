using System;
using System.Collections.Generic;
using System.Text;

namespace SmartC.ApplicationCore.Entities
{
    public class Pacote
    {
        public int Id { get; set; }
        public int IdItemClinica { get; set; }
        public ItemClinica ItemClinica { get; set; }

        public virtual IEnumerable<ItemPacote> ItensPacote { get; set; }
    }
}
