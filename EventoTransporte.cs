using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// En Fruteria.Modelos/EventoTransporte.cs
namespace Fruteria.Modelos
{
    public class EventoTransporte
    {
        // El ID del lote que se está transportando (Ej: TOMA-0)
        public string? LoteID { get; set; }

        // La matrícula del camión
        public string? Matricula { get; set; }

        // El "recorrido" lo simulamos con un punto de control
        public string? UbicacionActual { get; set; } // Ej: "En ruta por Albacete"

        // La temperatura solicitada
        public double Temperatura { get; set; }

        public double Humedad { get; set; } // Porcentaje (0-100)
        public bool GolpeDetectado { get; set; } // True si hubo un impacto fuerte
    }
}