using System;
using System.Collections.Generic;
using System.Text;

namespace SmartC.ApplicationCore.Entities
{
    public class ItemClinica
    {
        public int Id { get; set; }
        public int IdClinica { get; set; }
        public Clinica Clinica { get; set; }
        public string Descricao { get; set; }
        public double Valor { get; set; }
        public bool Status { get; set; }

    }
}
