using System;

namespace PontoDigital_final.Models
{
    public class Comentario
    {
        public int Id {get;set;}
        public Usuario Autor {get;set;}
        public string Assunto {get;set;} 
        public string Mensagem {get;set;}
        public DateTime DataDoComentario {get;set;}
        public bool EstaAprovado {get;set;}
    }
}