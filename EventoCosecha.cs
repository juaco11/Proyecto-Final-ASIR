using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// En EventoCosecha.cs
namespace Fruteria.Modelos
{
    public class EventoCosecha
    {
        // Datos del formulario del agricultor
        public string? AgricultorID { get; set; } 
        public string? Variedad { get; set; }
        public double Kilos { get; set; }
        public string? Origen { get; set; } // Ej: "Finca El Sol, Alicante"

        // Datos que añadiremos nosotros
        public string? LoteID { get; set; } // Un ID único (Ej: "MANZ-001")
        public string? ImagenUrl { get; set; } // La URL de la imagen
        public DateTime FechaCosecha { get; set; }
    }
}
