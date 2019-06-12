using System.Collections.Generic;
using PontoDigital_final.Models;

namespace PontoDigital_final.ViewModels
{
    public class AdministradorViewModel
    {
        public string Nome {get;set;}
        public List<Comentario> ListaDeComentarios {get;set;}
        public List<Usuario> ListaDeUsuarios {get;set;}
        public int ComentariosAprovados {get;set;}
        public int ComentariosRecusados {get;set;}

        
    }
}