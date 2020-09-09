using System.Collections.Generic;

namespace SmartC.ApplicationCore.Entities
{
    public class ItemClinica
    {
        public int Id { get; set; }
        public int IdClinica { get; set; }
        public Clinica Clinica { get; set; }
        public bool Status { get; set; }


        public List<ItemVenda> ItensVenda { get; set; }
    }
}