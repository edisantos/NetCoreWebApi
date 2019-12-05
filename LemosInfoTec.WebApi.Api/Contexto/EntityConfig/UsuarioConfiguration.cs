using LemosInfoTec.WebApi.Domain.DomainViewModels;
using Microsoft.EntityFrameworkCore;

namespace LemosInfoTec.WebApi.Api.Contexto.EntityConfig
{
    public class UsuarioConfiguration : IEntityTypeConfiguration<Usuarios>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Usuarios> builder)
        {
            builder.HasKey(x=>x.Id);

            builder.Property(x=>x.Data)
            .HasColumnType("datetime")
             .IsRequired();

             builder.Property(x=>x.NomeCompleto)
             .HasColumnType("varchar(100)")
             .IsRequired();

             builder.Property(x=>x.Email)
             .HasColumnType("varchar(100)")
             .IsRequired();

             builder.Property(x=>x.Usuario)
             .HasColumnType("varchar(50)")
             .IsRequired();

             builder.Property(x=>x.Senha)
             .HasColumnType("varchar(400)")
             .IsRequired();

        }
    }
}
