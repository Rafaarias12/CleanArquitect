﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Entidades.Usuarios
{
    public class Organizacion
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public ICollection<Usuarios> Usuario { get; set; }
    }
}
