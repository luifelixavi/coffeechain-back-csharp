using CoffeeChain.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeeChain.Data.Configurations
{
    public class EntradasConfiguration : IEntityTypeConfiguration<Entradas>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Entradas> builder)
        {
            builder.ToTable("Entradas");
            builder.HasKey(p => p.EntradaId);
            builder.Property(p => p.ProdutorId);
            builder.Property(p => p.PropriedadeId);
            builder.Property(p => p.EmpresaId);
            builder.Property(p => p.ArmazemId);
            builder.Property(p => p.DataEntrada).HasColumnType("DATE");
            builder.Property(p => p.CodigoLote).HasColumnType("VARCHAR(30)");
            builder.Property(p => p.QtdSacas).HasColumnType("DECIMAL(9)");
            builder.Property(p => p.PrecoLote).HasColumnType("DECIMAL(9)");
            builder.Property(p => p.CustoEntrada).HasColumnType("DECIMAL(9)");
            builder.Property(p => p.NfeEntrada).HasColumnType("VARCHAR(30)");
            builder.Property(p => p.TipoEntrada).HasColumnType("INTEGER");
            builder.Property(p => p.Safra).HasColumnType("VARCHAR(20)");
            builder.Property(p => p.TipoCafe).HasColumnType("VARCHAR(200)");
            builder.Property(p => p.LocalArmazenado).HasColumnType("VARCHAR(200)");
            builder.Property(p => p.EmbalagemArmazenado).HasColumnType("VARCHAR(100)");

            builder.HasOne(p => p.Produtor)
                .WithMany(p => p.Entradas)
                .OnDelete(DeleteBehavior.NoAction)
                .HasForeignKey(p => p.ProdutorId);

            builder.HasOne(p => p.Propriedade)
                .WithMany(p => p.Entradas)
                .OnDelete(DeleteBehavior.NoAction)
                .HasForeignKey(p => p.PropriedadeId);

            builder.HasOne(p => p.Empresa)
                .WithMany(p => p.Entradas)
                 .OnDelete(DeleteBehavior.NoAction)
                .HasForeignKey(p => p.EmpresaId);

            builder.HasOne(p => p.Armazem)
              .WithMany(p => p.Entradas)
              .OnDelete(DeleteBehavior.NoAction)
              .HasForeignKey(p => p.ArmazemId);


        }
    }
}
