using System;
using System.Collections.Generic;
using System.Text;

namespace SmartC.ApplicationCore.Entities
{
    public class Estoque
    {
        public int Id { get; set; }
        public int IdProduto { get; set; }
        public Produto Produto { get; set; }
        public int QuantidadeProduto { get; set; }
    }
}
