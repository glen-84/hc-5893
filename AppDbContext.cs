using System.Text.Json;
using Microsoft.EntityFrameworkCore;

namespace hc_5893;

public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
{
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(Program).Assembly);

        modelBuilder.Entity<UsuarioModel>().HasData(
            new UsuarioModel {
                Codigo = Guid.NewGuid().ToString(),
                Data = JsonDocument.Parse("""
                    {
                        "a": 1,
                        "b": "2",
                        "c": {
                            "d": 1,
                            "e": "f"
                        }
                    }
                    """)});
    }
}
