using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AntambaJExamenFinalProgramacionTres.Models
{
    public class Suscripcion
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        [NotNull]
        public string Servicio { get; set; }
        [NotNull]
        public string CorreoAsociado { get; set; }
        [NotNull]
        public decimal CostoMensual { get; set; }
        public bool RenovacionAutomatica { get; set; }
        public DateTime FechaRegistro { get; set; }
    }
}

