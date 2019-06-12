using System;
using Microsoft.AspNetCore.Http;

namespace PontoDigital_final.Models
{
    public class Usuario
    {
        public int Id {get;set;}
        public string Nome {get;set;}
        public string Endereco {get;set;}
        public string Email {get;set;}
        public string Senha {get;set;}
        public string Telefone {get;set;}
        public string Genero {get;set;}
        public Empresa Empresa {get;set;}
        public DateTime DataNascimento {get;set;}
        public string UrlFoto {get;set;}
        public IFormFile Foto {get;set;}

        
    }
}