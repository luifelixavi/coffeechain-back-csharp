using CoffeeChain.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeeChain.Data.Configurations
{
    public class ProdutorConfiguration : IEntityTypeConfiguration<Produtor>
    {
        public void Configure(EntityTypeBuilder<Produtor> builder)
        {
            builder.ToTable("Produtor");
            builder.HasKey(p => p.ProdutorId);
            builder.Property(p => p.NomeProdutor).HasColumnType("VARCHAR(100)");
            builder.Property(p => p.CpfProdutor).HasColumnType("VARCHAR(20)");
            builder.Property(p => p.RgProdutor).HasColumnType("VARCHAR(20)");
            builder.Property(p => p.TelefoneProdutor).HasColumnType("VARCHAR(20)");
            builder.Property(p => p.EnderecoProdutor).HasColumnType("VARCHAR(100)");
            builder.Property(p => p.CidadeProdutor).HasColumnType("VARCHAR(50)");
            builder.Property(p => p.UfProdutor).HasColumnType("VARCHAR(2)");
            builder.Property(p => p.EmailProdutor).HasColumnType("VARCHAR(100)");
            builder.Property(p => p.CepProdutor).HasColumnType("VARCHAR(20)");
        }
    }
}
