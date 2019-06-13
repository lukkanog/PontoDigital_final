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

        public Usuario()    {}

        public Usuario(string nome,string endereco, string email, string telefone, string genero, DateTime dataNascimento, string nomeEmpresa,string cnpj, string senha)
        {
            this.Nome = nome;
            this.Email = endereco;
            this.Telefone = telefone;
            this.Genero = genero;
            this.DataNascimento = dataNascimento;
            Empresa empresa = new Empresa();
            empresa.Nome = nomeEmpresa;
            empresa.Cnpj = cnpj;
            this.Empresa = empresa;
        }
        
        public Usuario(int id,string nome,string endereco, string email, string telefone, string genero, DateTime dataNascimento, string nomeEmpresa,string cnpj, string senha, string foto)
        {
            this.Id = id;
            this.Nome = nome;
            this.Email = endereco;
            this.Telefone = telefone;
            this.Genero = genero;
            this.DataNascimento = dataNascimento;
            Empresa empresa = new Empresa();
            empresa.Nome = nomeEmpresa;
            empresa.Cnpj = cnpj;
            this.Empresa = empresa;
            this.UrlFoto = foto;
        }
        
    }
}