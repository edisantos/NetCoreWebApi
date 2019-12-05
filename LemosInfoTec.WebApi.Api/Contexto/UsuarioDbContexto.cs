using LemosInfoTec.WebApi.Api.Contexto.EntityConfig;
using LemosInfoTec.WebApi.Domain.DomainViewModels;
using Microsoft.EntityFrameworkCore;

namespace LemosInfoTec.WebApi.Api.Contexto
{
    public class UsuarioDbContexto : DbContext
    {
        public UsuarioDbContexto(DbContextOptions<UsuarioDbContexto> options) 
        : base(options)
        {
        }
        
        public DbSet<Usuarios> Usuarios{get;set;}
        public DbSet<Papeis> Papeis {get;set;}

        protected override void OnModelCreating(ModelBuilder builder){

            builder.ApplyConfiguration(new UsuarioConfiguration());
            builder.ApplyConfiguration(new PapeisConfiguration());

            base.OnModelCreating(builder);

        }
        
    }
}
