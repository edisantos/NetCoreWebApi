using System.Collections.Generic;
using LemosInfoTec.WebApi.Api.Repositories;
using LemosInfoTec.WebApi.Domain.DomainViewModels;
using Microsoft.AspNetCore.Mvc;


namespace LemosInfoTec.WebApi.Api.Controllers
{
    [Route("api/[Controller]")]
    public class UsuariosController:Controller
    {
        private readonly IUsuarioRepository _repository;
        public UsuariosController(IUsuarioRepository repostory)
        {
            _repository = repostory;
        }
         //Retorna todos os usuários
        [HttpGet]
        public IEnumerable<Usuarios> GetAll(){
         
           return  _repository.GetAllUsarios();
        }
        //Retorna o usuário pelo id
        [HttpGet("{id}",Name="GetUsuario")]
        public IActionResult GetUsuarioById(int id){
         
           var usuario = _repository.Find(id);
           if(usuario ==null){
               return NotFound();

           }
           return new ObjectResult(usuario);
        }
        [HttpPost]
        public IActionResult Registrar([FromBody] Usuarios usuarios){
           if(usuarios ==null){
               return BadRequest();
           }
           _repository.AddUsarios(usuarios);
           return CreatedAtRoute("GetUsuario",new {Id=usuarios.Id},usuarios);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int Id,[FromBody] Usuarios usuarios){
            if(usuarios==null || usuarios.Id!= Id){
                return BadRequest();
            }
            var _usuario = _repository.Find(Id);
            if(_usuario==null)
                return NotFound();
                _usuario.Email = usuarios.Email;
                _usuario.NomeCompleto = usuarios.NomeCompleto;
                _repository.UpdateUsuario(_usuario);
                return new NoContentResult();
            
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id){
           var usuario = _repository.Find(id);
           if(usuario==null)
           return NotFound(); 

           _repository.DeleleUsuario(id);
           return new NoContentResult();
        }

    }
}
