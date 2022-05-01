using Microsoft.EntityFrameworkCore;
using DemoMinimalApi.Models;

namespace DemoMinimalApi.Data;

class MinimalContextDb : DbContext
{
    public MinimalContextDb(DbContextOptions<MinimalContextDb> options) : base(options) { }
    public DbSet<Fornecedor> Fornecedores { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite("DataSource=app.db;Cache=Shared");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Fornecedor>()
            .HasKey(p => p.Id);

        modelBuilder.Entity<Fornecedor>()
            .Property(p => p.Nome)
            .IsRequired()
            .HasColumnType("varchar(200)");

        modelBuilder.Entity<Fornecedor>()
            .Property(p => p.Documento)
            .IsRequired()
            .HasColumnType("varchar(14)");

        modelBuilder.Entity<Fornecedor>()
            .ToTable("Fornecedores");

        base.OnModelCreating(modelBuilder);
    }
}
