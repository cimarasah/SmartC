using System;
using System.Collections.Generic;
using System.Text;

namespace SmartC.ApplicationCore.Entities
{
    public class Caixa
    {
        public int Id { get; set; }
        public int IdClinica { get; set; }
        public Clinica Clinica { get; set; }
        public double ValorAtual { get; set; }
    }
}
