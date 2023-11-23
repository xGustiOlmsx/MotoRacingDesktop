using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotoRacingDesktop.Models
{
    public class Corredor
    {
        public int Id { get; set; }
        public string ApellidoNombre { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public int? VehiculoId { get; set; }
        public Vehiculo Vehiculo { get; set; }
        public int? PistaId { get; set; }
        public Pista Pista { get; set; }
        public int? ActividadId { get; set; }
        public Actividad Actividad { get; set; }
        public override string ToString()
        {
            return ApellidoNombre;
        }
    }
}
