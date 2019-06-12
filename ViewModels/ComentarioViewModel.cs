using System.Collections.Generic;
using PontoDigital_final.Models;

namespace PontoDigital_final.ViewModels
{
    public class ComentarioViewModel
    {
        public List<Comentario> ListaDeComentarios {get;set;}
        public Usuario Usuario {get;set;}
    }
}