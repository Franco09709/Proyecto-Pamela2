﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_de_Entidad
{
   public class EServicio
   {
        public int Id { get; set; }

        public string NombreServicio { get; set; }

        public string NombreAnterior { get; set; }

        public decimal Precio { get; set; }

        public bool Estado { get; set; }

        public string Imagen { get; set; }
    }
}
