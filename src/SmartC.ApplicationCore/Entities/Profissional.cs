using System;
using System.Collections.Generic;
using System.Text;

namespace SmartC.ApplicationCore.Entities
{
    public class Profissional
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public int IdClinica { get; set; }
        public Clinica Clinica { get; set; }
        public int IdUsuario { get; set; }
        public Usuario Usuario { get; set; }


        public IEnumerable<Sessao> Sessoes { get; set; }
        public IEnumerable<Venda> Vendas { get; set; }
        public IEnumerable<HorarioProfissional> Horarios { get; set; }

    }
}
