using CoffeeChain.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeeChain.Data.Configurations
{
    public class SaidasConfiguration : IEntityTypeConfiguration<Saidas>
    {
        public void Configure(EntityTypeBuilder<Saidas> builder)
        {
            builder.ToTable("Saidas");
            builder.HasKey(p => p.SaidaId);
            builder.Property(p => p.DestinoProdutorId);
            builder.Property(p => p.DestinoPropriedadeId);
            builder.Property(p => p.DestinoEmpresaId);
            builder.Property(p => p.EntradaId);
            builder.Property(p => p.DestinoArmazemId);
            builder.Property(p => p.DataSaida).HasColumnType("DATE");
            builder.Property(p => p.QtdSacas).HasColumnType("DECIMAL(9)");
            builder.Property(p => p.TipoSaida).HasColumnType("INTEGER");
            builder.Property(p => p.PrecoSaida).HasColumnType("DECIMAL(9)");
            builder.Property(p => p.CustoSaida).HasColumnType("DECIMAL(9)");
            builder.Property(p => p.NfeSaida).HasColumnType("VARCHAR(100)");
            builder.Property(p => p.EmbalagemSaida).HasColumnType("VARCHAR(100)");

            builder.HasOne(p => p.Produtor)
               .WithMany(p => p.Saidas)
               .OnDelete(DeleteBehavior.NoAction)
               .HasForeignKey(p => p.DestinoProdutorId);

            builder.HasOne(p => p.Propriedade)
              .WithMany(p => p.Saidas)
              .OnDelete(DeleteBehavior.NoAction)
              .HasForeignKey(p => p.DestinoPropriedadeId);

            builder.HasOne(p => p.Empresa)
              .WithMany(p => p.Saidas)
              .OnDelete(DeleteBehavior.NoAction)
              .HasForeignKey(p => p.DestinoEmpresaId);

            builder.HasOne(p => p.Armazem)
              .WithMany(p => p.Saidas)
              .OnDelete(DeleteBehavior.NoAction)
              .HasForeignKey(p => p.DestinoArmazemId);

            builder.HasOne(p => p.Entradas)
              .WithMany(p => p.Saidas)
              .OnDelete(DeleteBehavior.NoAction)
              .HasForeignKey(p => p.EntradaId);
        }
    }
}
