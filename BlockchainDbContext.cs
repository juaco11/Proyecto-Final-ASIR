// ¡Esta línea es muy importante! Importa la librería de Entity Framework
using Microsoft.EntityFrameworkCore;

// Asegúrate de que el namespace es el de tu proyecto API
namespace Fruteria.API
{
    // Esta clase es el "puente" con la BBDD
    // Hereda (:) de DbContext
    public class BlockchainDbContext : DbContext
    {
        // Este constructor es necesario para que funcione la inyección
        // de dependencias en Program.cs
        public BlockchainDbContext(DbContextOptions<BlockchainDbContext> options) : base(options)
        {

        }

        // Esta línea le dice a Entity Framework:
        // "Quiero crear una tabla en la BBDD que se llame 'Bloques'
        // y que guardará objetos de tipo 'Bloque'"
        public DbSet<Bloque> Bloques { get; set; }
    }
}