namespace Fruteria.API
{
    public class Bloque
    {
        public int Id { get; set; } // Clave primaria de la BBDD
        public int Indice { get; set; }
        public DateTime MarcaDeTiempo { get; set; }
        public string Datos { get; set; } // Aquí guardaremos el EventoCosecha como JSON
        public string HashAnterior { get; set; }
        public string Hash { get; set; }
    }
}
