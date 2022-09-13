using CoffeeChain.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeeChain.Data.Configurations
{
    public class EmpresaConfiguration : IEntityTypeConfiguration<Empresa>
    {
        public void Configure(EntityTypeBuilder<Empresa> builder)
        {
            builder.ToTable("Empresa");
            builder.HasKey(p => p.EmpresaId);
            builder.Property(p => p.RazaoSocial).HasColumnType("VARCHAR(200)");
            builder.Property(p => p.NomeFantasia).HasColumnType("VARCHAR(200)");
            builder.Property(p => p.CNPJEmpresa).HasColumnType("VARCHAR(20)");
            builder.Property(p => p.TelefoneEmpresa).HasColumnType("VARCHAR(20)");
            builder.Property(p => p.EnderecoEmpresa).HasColumnType("VARCHAR(100)");
            builder.Property(p => p.CidadeEmpresa).HasColumnType("VARCHAR(100)");
            builder.Property(p => p.UfEmpresa).HasColumnType("VARCHAR(2)");
            builder.Property(p => p.PaisEmpresa).HasColumnType("VARCHAR(50)");
            builder.Property(p => p.CepEmpresa).HasColumnType("VARCHAR(100)");
            builder.Property(p => p.EmailEmpresa).HasColumnType("VARCHAR(100)");

        }
    }
}
