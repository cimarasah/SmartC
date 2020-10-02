using System;
using System.Collections.Generic;
using System.Text;

namespace SmartC.ApplicationCore.Entities
{
    public class VoucherServico
    {
        public int Id { get; set; }
        public int IdVoucher { get; set; }
        public Voucher Voucher { get; set; }
        public int IdServico { get; set; }
        public Servico Servico { get; set; }
        public int QtdSessao { get; set; }
        public bool Status { get; set; }
        public DateTime DataVencimento { get; set; }
    }
}
