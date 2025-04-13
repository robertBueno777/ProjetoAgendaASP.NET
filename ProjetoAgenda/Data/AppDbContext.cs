using ProjetoAgenda.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<DocumentoIdentificacao> DocumentoIdentificacao { get; set; }
    public DbSet<Usuario> Usuarios { get; set; }
    public DbSet<Endereco> Enderecos { get; set; }
    public DbSet<Telefone> Telefones { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Usuario>()
            .HasOne(u => u.Endereco)
            .WithOne(e => e.Usuario)
            .HasForeignKey<Endereco>(e => e.UsuarioId);

        modelBuilder.Entity<Usuario>()
           .HasOne(u => u.DocumentoIdentificacao)
           .WithOne(e => e.Usuario)
           .HasForeignKey<DocumentoIdentificacao>(e => e.UsuarioId);

        modelBuilder.Entity<Usuario>()
          .HasMany(u => u.Telefones)
          .WithOne(t => t.Usuario)
          .HasForeignKey(e => e.UsuarioId);





    }




}