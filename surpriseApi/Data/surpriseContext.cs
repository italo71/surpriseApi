namespace surpriseApi.Data;
using Microsoft.EntityFrameworkCore;
using surpriseApi.Models;

public class surpriseContext :DbContext
{
    public surpriseContext(DbContextOptions<surpriseContext> opts):base(opts)
    {
        
    }

    public DbSet<Usuario> Usuarios { get; set; }
    public DbSet<Nivel> Niveis { get; set; }
    public DbSet<Token> Tokens { get; set; }
}
