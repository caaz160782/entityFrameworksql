using Microsoft.EntityFrameworkCore;
using sqlServer.Models;
namespace sqlServer.Datos;

public class Contexto:DbContext{
    string? _connectionString;

    public Contexto(string _connectionString)
    {
        this._connectionString=_connectionString;
    }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
     //   base.OnConfiguring(optionsBuilder);
     optionsBuilder.UseSqlServer(this._connectionString);
    }

     public DbSet<Categoria>Categorias {get; set;}
     public DbSet<Producto>Productos {get; set;}
}