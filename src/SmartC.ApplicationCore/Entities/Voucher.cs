using System;
using System.Collections.Generic;
using System.Text;

namespace SmartC.ApplicationCore.Entities
{
    public class Voucher
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public string Codigo { get; set; }
        public bool Status { get; set; }
        public string Comentario { get; set; }
    }
}
