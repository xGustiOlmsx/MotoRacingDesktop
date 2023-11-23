﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotoRacingDesktop.Models
{
    public class Actividad
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public decimal Costo { get; set; }
        public string Horarios { get; set; }
        public int? CorredorId { get; set; }
        public Corredor Corredores { get; set; }
        public int? PistaId { get; set; }
        public Pista Pista { get; set; }

        public override string ToString()
        {
            return Nombre;
        }

    }
}
