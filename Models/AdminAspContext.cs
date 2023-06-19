using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace AdministradorPersonas.Models;

public partial class AdminAspContext : DbContext
{
    public AdminAspContext()
    {
    }

    public AdminAspContext(DbContextOptions<AdminAspContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Pais> Pais { get; set; }

    public virtual DbSet<Persona> Personas { get; set; }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Pais>(entity =>
        {
            entity.HasKey(e => e.PaisId).HasName("PK__Pais__B501E18566E39675");

            entity.Property(e => e.Descripcion)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Persona>(entity =>
        {
            entity.HasKey(e => e.PersonaId).HasName("PK__Persona__7C34D303642C0A3E");

            entity.ToTable("Persona");

            entity.Property(e => e.Direccion)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.Pais).WithMany(p => p.Personas)
                .HasForeignKey(d => d.PaisId)
                .HasConstraintName("FK__Persona__Direcci__267ABA7A");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
