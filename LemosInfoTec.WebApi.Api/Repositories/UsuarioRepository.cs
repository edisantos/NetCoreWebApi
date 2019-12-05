using System;
using System.Collections.Generic;
using System.Linq;
using LemosInfoTec.WebApi.Api.Contexto;
using LemosInfoTec.WebApi.Domain.DomainViewModels;

namespace LemosInfoTec.WebApi.Api.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly UsuarioDbContexto _contexto;

        public UsuarioRepository(UsuarioDbContexto contexto)
        {
            _contexto = contexto;
        }
        public void AddUsarios(Usuarios usuarios)
        {
            _contexto.Usuarios.Add(usuarios);
            _contexto.SaveChanges();
        }

        public void DeleleUsuario(int id)
        {
            var delete = _contexto.Usuarios.First(x=>x.Id == id);
            _contexto.Usuarios.Remove(delete);
            _contexto.SaveChanges();
        }

        public Usuarios Find(int id)
        {
           return _contexto.Usuarios.Find(id);
        }

        public IEnumerable<Usuarios> GetAllUsarios()
        {
           return _contexto.Usuarios.ToList();
        }

        public void UpdateUsuario(Usuarios usuarios)
        {
            _contexto.Usuarios.Update(usuarios);
            _contexto.SaveChanges();
        }
    }
}
