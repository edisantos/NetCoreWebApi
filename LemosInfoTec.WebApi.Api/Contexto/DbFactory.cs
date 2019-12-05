using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace LemosInfoTec.WebApi.Api.Contexto
{
    public class DbFactory : IDesignTimeDbContextFactory<UsuarioDbContexto>
    {
        public UsuarioDbContexto CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<UsuarioDbContexto>();
            optionsBuilder.UseMySql("Server=localhost;DataBase=DbWebApiDemo;Uid=root;Pwd=info@1234");
            return new UsuarioDbContexto(optionsBuilder.Options);
            
        }
    }
}
