using System;
using System.Collections.Generic;
using LemosInfoTec.WebApi.Domain.DomainViewModels;

namespace LemosInfoTec.WebApi.Api.Repositories
{
    public interface IUsuarioRepository
    {
         void AddUsarios(Usuarios usuarios);

         IEnumerable<Usuarios> GetAllUsarios();

         Usuarios Find(int id);

         void DeleleUsuario(int id);

         void UpdateUsuario(Usuarios usuarios);
    }
}
