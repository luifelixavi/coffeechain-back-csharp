using CoffeeChain.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeeChain.Data.Configurations
{
    public class ArmazemConfiguration : IEntityTypeConfiguration<Armazem>
    {
        public void Configure(EntityTypeBuilder<Armazem> builder)
        {
            builder.ToTable("Armazem");
            builder.HasKey(p => p.ArmazemId);
            builder.Property(p => p.EmpresaId);
            builder.Property(p => p.TelefoneArmazem).HasColumnType("VARCHAR(20)");
            builder.Property(p => p.EnderecoArmazem).HasColumnType("VARCHAR(200)");
            builder.Property(p => p.CidadeArmazem).HasColumnType("VARCHAR(100)");
            builder.Property(p => p.UfArmazem).HasColumnType("VARCHAR(2)");
            builder.Property(p => p.EmailArmazem).HasColumnType("VARCHAR(100)");

            builder.HasOne(p => p.Empresa)
                .WithMany(p => p.Armazens)
                .OnDelete(DeleteBehavior.Cascade)
                .HasForeignKey(p => p.EmpresaId);

        }
    }
}
