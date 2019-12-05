using System;
using LemosInfoTec.WebApi.Domain.DomainViewModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LemosInfoTec.WebApi.Api.Contexto.EntityConfig
{
    public class PapeisConfiguration : IEntityTypeConfiguration<Papeis>
    {
        public void Configure(EntityTypeBuilder<Papeis> builder)
        {
            builder.HasKey(x=>x.Id);

            builder.Property(x=>x.Data)
            .HasColumnType("datetime")
            .IsRequired();

            builder.Property(x=>x.Name)
            .HasColumnType("varchar(50)")
            .IsRequired();

            builder.Property(x=>x.Ativo)
            .HasColumnType("bool");
        }
    }
}
