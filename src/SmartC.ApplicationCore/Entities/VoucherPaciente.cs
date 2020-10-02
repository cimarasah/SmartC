using System;
using System.Collections.Generic;
using System.Text;

namespace SmartC.ApplicationCore.Entities
{
    public class VoucherPaciente
    {
        public int Id { get; set; }
        public int IdVoucherServico { get; set; }
        public VoucherServico VoucherServico { get; set; }
        public int IdPaciente { get; set; }
        public Paciente Paciente { get; set; }
        public DateTime DataVencimento { get; set; }
        public bool Status { get; set; }
    }
}
