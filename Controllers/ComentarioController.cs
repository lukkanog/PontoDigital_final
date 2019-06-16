using System.Collections.Generic;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PontoDigital_final.Models;
using PontoDigital_final.Repositories;
using PontoDigital_final.ViewModels;

namespace PontoDigital_final.Controllers
{
    public class ComentarioController : Controller
    {
        ComentarioRepository comentarioRepositorio = new ComentarioRepository();
        UsuarioRepository usuarioRepositorio = new UsuarioRepository();
        private const string  SESSION_EMAIL = "_EMAIL";
        private const string SESSION_USUARIO = "_USUARIO";
        private const string SESSION_ADMIN = "_ADMINISTRADOR";


        [HttpGet]
        public IActionResult Avaliacoes()
        {
            ComentarioViewModel cvm = new ComentarioViewModel();
            cvm.ListaDeComentarios = new List<Comentario>();
            var lista = comentarioRepositorio.Listar();
                foreach (var item in lista)
                {
                    if (item.EstaAprovado == true)
                    {
                        cvm.ListaDeComentarios.Add(item);
                    }
                }
            ViewBag.Admin = HttpContext.Session.GetString(SESSION_ADMIN);
            ViewBag.User = HttpContext.Session.GetString(SESSION_USUARIO);
            return View(cvm);
        }


        [HttpGet]
        public IActionResult CadastrarComentario()
        {
            var usuario = usuarioRepositorio.ObterUsuario(HttpContext.Session.GetString(SESSION_EMAIL));
            ViewBag.Admin = HttpContext.Session.GetString(SESSION_ADMIN);
            // ViewBag.User = HttpContext.Session.GetString(SESSION_USUARIO);

            ComentarioViewModel cvm = new ComentarioViewModel();
            
            if (usuario!=null)
            {
                cvm.Usuario = usuario;
                ViewBag.User = HttpContext.Session.GetString(SESSION_USUARIO);
                return View(cvm);
            } else 
            {
                ErroViewModel erro = new ErroViewModel();
                TempData["erro"] = "Você deve estar logado para fazer uma avaliação!";
                TempData["voltar"] = "/Home/Index";
                return View("_Erro",erro);    
            }
        }

        [HttpPost]
        public IActionResult CadastrarComentario(IFormCollection form)
        {
            Comentario comentario = new Comentario();
            comentario.Assunto = form["assunto"];
            comentario.Mensagem = form["mensagem"];
            
            comentario.Autor = usuarioRepositorio.ObterUsuario((HttpContext.Session.GetString(SESSION_EMAIL)));
            comentarioRepositorio.Inserir(comentario);

            var sucessoViewModel = new SucessoViewModel();
            TempData["sucesso"] = "Comentário cadastrado com sucesso! Seu comentário agora passará pelo processo de verificação";
            TempData["voltar"] = "/Comentario/CadastrarComentario";
            return View("_Sucesso",sucessoViewModel);
        }


    }
}