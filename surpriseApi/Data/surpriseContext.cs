namespace surpriseApi.Data;
using Microsoft.EntityFrameworkCore;
using surpriseApi.Models;

public class surpriseContext :DbContext
{
    public surpriseContext(DbContextOptions<surpriseContext> opts):base(opts)
    {
        
    }

    public DbSet<usuario> usuarios { get; set; }

}
