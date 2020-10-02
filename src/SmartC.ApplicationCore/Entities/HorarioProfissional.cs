using SmartC.ApplicationCore.Enuns;
using System;
using System.Collections.Generic;
using System.Text;

namespace SmartC.ApplicationCore.Entities
{
    public class HorarioProfissional
    {
        public int Id { get; set; }
        public int IdProfissional { get; set; }
        public Profissional Profissional { get; set; }

        public SemanaEnum DiaSemana { get; set; }
        public DateTime HoraInicial { get; set; }
        public DateTime HoraFinal { get; set; }
    }
}
