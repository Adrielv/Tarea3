﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea3.Capitulo10.Entidades
{
    public class InventarioT
    {
        public string ProductoId { get; set; }
        public string Nombre { get; set; }
        public string Precio { get; set; }
        public string Cantidad { get; set; }
        public DateTime FechaVencimiento { get; set; }
    }
}
