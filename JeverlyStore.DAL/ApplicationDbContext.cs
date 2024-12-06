using System.Collections.Immutable;
using Microsoft.EntityFrameworkCore;
using Npgsql.EntityFrameworkCore.PostgreSQL;
using Microsoft.Extensions.Configuration;
using JeverlyStroe.Domain.ModelsDb;

namespace JeverlyStore.DAL;

public class ApplicationDbContext:DbContext
{
    public DbSet<UserDb>UserDbs { get; set; }
    public DbSet<ProductDb>ProductDbs { get; set; }
    public DbSet<PicturesProductDb>PicturesProductDbs { get; set; }
    public DbSet<OrderDb>OrderDbs { get; set; }
    protected readonly IConfiguration Configuration;




    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=StroyRab;Username=postgres;password=Privet1301");
    }
    public ApplicationDbContext() { }
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
    {
        
    }
    
}