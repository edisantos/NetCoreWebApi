using System;

namespace LemosInfoTec.WebApi.Domain.DomainViewModels
{
    public class Usuarios:Generic
    {
        public string NomeCompleto { get; set; }
        public string Email{get;set;}
        public string  Usuario { get; set; }
        public string Senha { get; set; }
    }
}
