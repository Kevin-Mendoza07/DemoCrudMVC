using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace FarmaciaDemoApp.Models;

public partial class FarmaValueContext : DbContext
{
    public FarmaValueContext()
    {
    }

    public FarmaValueContext(DbContextOptions<FarmaValueContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Cliente> Clientes { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Cliente>(entity =>
        {
            entity.HasKey(e => e.IdCliente).HasName("PK__Cliente__3DD0A8CBD72FDEB4");

            entity.ToTable("Cliente");

            entity.Property(e => e.IdCliente).HasColumnName("Id_Cliente");
            entity.Property(e => e.ApellidoCliente).HasMaxLength(30);
            entity.Property(e => e.Direccion).HasMaxLength(50);
            entity.Property(e => e.NombreCliente).HasMaxLength(30);
            entity.Property(e => e.Telefono).HasMaxLength(25);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
