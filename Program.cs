using Microsoft.EntityFrameworkCore;
using Fruteria.API; // O el namespace donde vivan tus clases

namespace Fruteria.API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllers();
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            builder.Services.AddDbContext<BlockchainDbContext>(
                options => options.UseSqlite("Data Source=blockchain.db")
            );

            var app = builder.Build();

            using (var scope = app.Services.CreateScope())
            {
                var services = scope.ServiceProvider;
                var context = services.GetRequiredService<BlockchainDbContext>();
                // Esta línea crea la BBDD y las tablas si no existen
                context.Database.EnsureCreated();
            }
            
            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.MapControllers();

            // Esta línea arranca el servidor y debe ser la ÚLTIMA
            app.Run();

        }
    }
}