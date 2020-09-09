﻿using System.Collections.Generic;

namespace SmartC.ApplicationCore.Entities
{
    public class Perfil
    {
        public int Id { get; set; }
        public string Descricao { get; set; }

        public List<Usuario> Usuarios { get; set; }
    }
}