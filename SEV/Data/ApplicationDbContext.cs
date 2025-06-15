using SEV.Models;
using Microsoft.EntityFrameworkCore;

namespace SEV.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public DbSet<Produto> Produtos{ get; set; }
    public DbSet<Venda> Vendas { get; set; }
}
