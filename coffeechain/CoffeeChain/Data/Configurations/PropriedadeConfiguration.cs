using CoffeeChain.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeeChain.Data.Configurations
{
    public class PropriedadeConfiguration : IEntityTypeConfiguration<Propriedade>
    {
        public void Configure(EntityTypeBuilder<Propriedade> builder)
        {
            builder.ToTable("Propriedade");
            builder.HasKey(p => p.PropriedadeId);
            builder.Property(p => p.ProdutorId);
            builder.Property(p => p.NomeFazenda).HasColumnType("VARCHAR(100)");
            builder.Property(p => p.CNPJFazenda).HasColumnType("VARCHAR(20)");
            builder.Property(p => p.InscEstadual).HasColumnType("VARCHAR(20)");
            builder.Property(p => p.TelefonePropriedade).HasColumnType("VARCHAR(20)");
            builder.Property(p => p.EnderecoPropriedade).HasColumnType("VARCHAR(200)");
            builder.Property(p => p.CidadePropriedade).HasColumnType("VARCHAR(50)");
            builder.Property(p => p.UfPropriedade).HasColumnType("VARCHAR(2)");
            builder.Property(p => p.EmailPropriedade).HasColumnType("VARCHAR(100)");
            builder.Property(p => p.CepPropriedade).HasColumnType("VARCHAR(20)");

            builder.HasOne(p => p.Produtor)
               .WithMany(p => p.Propriedades)
               .OnDelete(DeleteBehavior.Cascade)
               .HasForeignKey(p => p.ProdutorId);
        }
    }
}
