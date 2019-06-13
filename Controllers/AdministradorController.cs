using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PontoDigital_final.Models;
using PontoDigital_final.Repositories;
using PontoDigital_final.ViewModels;

namespace PontoDigital_final.Controllers
{
    
    public class AdministradorController : Controller
    {
        private const string SESSION_EMAIL = "_EMAIL";
        private const string SESSION_ADMIN = "_ADMINISTRADOR";
        private const string SESSION_USUARIO = "_USUARIO";
        ComentarioRepository comentarioRepositorio = new ComentarioRepository();
        UsuarioRepository usuarioRepositorio = new UsuarioRepository();
        AdministradorRepository administradorRepositorio = new AdministradorRepository();

        [HttpGet]
        public IActionResult Index()
        {
            AdministradorViewModel admViewModel = new AdministradorViewModel();
            admViewModel.Nome = HttpContext.Session.GetString(SESSION_ADMIN);
            ViewBag.Admin = HttpContext.Session.GetString(SESSION_ADMIN);
            if (string.IsNullOrEmpty(HttpContext.Session.GetString(SESSION_ADMIN)))
            {
                var erroViewModel = new ErroViewModel();
                TempData["erro"] = "Apenas administradores podem acessar essa página !";
                TempData["voltar"] = "/Home/Index";
                return View("_Erro",erroViewModel);
            }
            admViewModel.ListaDeUsuarios = usuarioRepositorio.Listar();
            admViewModel.ListaDeComentarios = comentarioRepositorio.Listar();
            admViewModel.ComentariosAprovados = 0;
            admViewModel.ComentariosRecusados = 0;

            foreach (var item in  admViewModel.ListaDeComentarios)
            {
                if (item.EstaAprovado)
                {
                    admViewModel.ComentariosAprovados++;
                } else
                {
                    admViewModel.ComentariosRecusados++;
                }
            }

            return View(admViewModel);
        }

        [HttpGet]
        public IActionResult CadastrarAdministrador()
        {
            ViewBag.Admin = HttpContext.Session.GetString(SESSION_ADMIN);
            if (string.IsNullOrEmpty(HttpContext.Session.GetString(SESSION_ADMIN)))
            {
                var erroViewModel = new ErroViewModel();
                TempData["erro"] = "Apenas administradores podem acessar essa página !";
                TempData["voltar"] = "/Home/Index";
                return View("_Erro",erroViewModel);
            }
            return View();
        }


        [HttpPost]
        public IActionResult CadastrarAdministrador(IFormCollection form)
        {
            if (!form["senha"].Equals(form["confirmarsenha"]))
            {

                ErroViewModel erroViewModel = new ErroViewModel();
                // erroViewModel.Mensagem = "Por favor, confirme sua senha corretamente.";
                // erroViewModel.LinkVoltar = "/Home/Index"; 
                TempData["erro"] = "Por favor, confirme sua senha corretamente.";
                TempData["voltar"] = "/Home/Index";
                return View("_Erro",erroViewModel);
            } else
            {
                Administrador admin = new Administrador();
                admin.Nome = form["nome"];
                admin.Setor = form["setor"];
                admin.Telefone = form["telefone"];
                admin.Endereco = form["endereco"];
                admin.Email = form["email"];
                admin.Senha = form["senha"];
                admin.DataNascimento = DateTime.Parse(form["data-nascimento"]);

                bool emailJaExiste = administradorRepositorio.VerificarEmailExistente(admin.Email);

                 if (!emailJaExiste)
                {
                    administradorRepositorio.Inserir(admin);
                    return RedirectToAction ("Index","Administrador");
                } else
                {
                    ErroViewModel erroViewModel = new ErroViewModel();
                    // erroViewModel.Mensagem = "Esse email já está sendo utilizado.";
                    // erroViewModel.LinkVoltar = "/Home/Index/";
                    TempData["erro"] = "Esse email já está sendo utilizado.";
                    TempData["voltar"] =  "/Administrador/Index/";
                    return View("_Erro",erroViewModel);
                }
            }
        }

        public IActionResult Login()
        {
            ViewBag.Admin = HttpContext.Session.GetString(SESSION_ADMIN);
            ViewBag.User = HttpContext.Session.GetString(SESSION_USUARIO);
            if (!string.IsNullOrEmpty(HttpContext.Session.GetString(SESSION_ADMIN)) || !string.IsNullOrEmpty(HttpContext.Session.GetString(SESSION_USUARIO)))
            {
                var erroViewModel = new ErroViewModel();
                TempData["erro"] = "Você já está logado";
                TempData["voltar"] = "/Home/Index";
                return View("_Erro",erroViewModel);
            }
            return View();
        }
        public IActionResult FazerLogin(IFormCollection form)
        {
            var email = form["email"];
            var senha = form["senha"];

            var usuario = administradorRepositorio.TentarLogin(email,senha);

            if (usuario != null)
            {
                string[] usuarioNomes = usuario.Nome.Split(" ");
                string primeiroNome = usuarioNomes[0];
                HttpContext.Session.SetString(SESSION_EMAIL, email);
                HttpContext.Session.SetString(SESSION_ADMIN, primeiroNome);

                
                return RedirectToAction("Index","Administrador");
            } else 
            {
                ErroViewModel erroViewModel = new ErroViewModel();
                TempData["erro"] =  "Email ou senha inválidos";
                TempData["voltar"] = "/Administrador/Login/";
                return View("_Erro",erroViewModel);
            }
        }
        

        [HttpGet]
        public IActionResult AprovarComentarios()
        {
            AdministradorViewModel admViewModel = new AdministradorViewModel();
            admViewModel.Nome = HttpContext.Session.GetString(SESSION_ADMIN);
            ViewBag.Admin = HttpContext.Session.GetString(SESSION_ADMIN);
            
            if (string.IsNullOrEmpty(admViewModel.Nome))
            {
                ErroViewModel erroViewModel = new ErroViewModel();
                TempData["erro"] = "Apenas administradores podem acessar essa pagina.";
                TempData["Voltar"] = "/Home/Index";
                return View("_Erro",erroViewModel);
            } else 
            {
                ComentarioViewModel comentarioViewModel = new ComentarioViewModel();

                if (TempData["lista"] == null)
                {
                    comentarioViewModel.ListaDeComentarios =  comentarioRepositorio.Listar();
                }
                else
                {
                    comentarioViewModel.ListaDeComentarios =  (List<Comentario>)TempData["lista"];
                }
                return View(comentarioViewModel);
            }
        }

        // [HttpPost]
        // public IActionResult FiltrarResultados(IFormCollection form)
        // {

        //     if (string.IsNullOrEmpty(form["data"]) && string.IsNullOrEmpty(form["status"]))
        //     {
        //         return RedirectToAction("AprovarComentarios");
        //     }

        //     ViewBag.Admin = HttpContext.Session.GetString(SESSION_ADMIN);
        //     // var comentarioViewModel = new ComentarioViewModel();
            


        //     if (string.IsNullOrEmpty(form["data"]))
        //     {
        //         var status = bool.Parse(form["status"]);
        //         TempData["lista"] = administradorRepositorio.Filtrar(status);
        //     } else if (string.IsNullOrEmpty(form["status"]))
        //     {
        //         var data = DateTime.Parse(form["data"]);
        //         TempData["lista"] = administradorRepositorio.Filtrar(data);
        //     } else
        //     {
        //         var data = DateTime.Parse(form["data"]);
        //         var status = bool.Parse(form["status"]);

        //         TempData["lista"] = administradorRepositorio.Filtrar(status,data);
        //     }
            
        //     return RedirectToAction("AprovarComentarios");
        // }


  


        [HttpGet]
        public IActionResult AprovarComentario(int id)
        {
            var comentario = comentarioRepositorio.ObterComentario(id);
            comentarioRepositorio.Aprovar(comentario);
            return RedirectToAction("AprovarComentarios");
        }
        
        [HttpGet]
        public IActionResult RecusarComentario(int id)
        {
            var comentario = comentarioRepositorio.ObterComentario(id);
            comentarioRepositorio.Recusar(comentario);
            return RedirectToAction("AprovarComentarios");
        }

        [HttpGet]
        public IActionResult ExibirUsuarios()
        {
            ViewBag.Admin = HttpContext.Session.GetString(SESSION_ADMIN);
            if (string.IsNullOrEmpty(HttpContext.Session.GetString(SESSION_ADMIN)))
            {
                var erroViewModel = new ErroViewModel();
                TempData["erro"] = "Apenas administradores podem acessar essa página !";
                TempData["voltar"] = "/Home/Index";
                return View("_Erro",erroViewModel);
            }

            UsuarioViewModel uvm = new UsuarioViewModel();
            uvm.ListaDeUsuarios = new List<Usuario>();

            var listaDeUsuarios = usuarioRepositorio.Listar();
            foreach (var item in listaDeUsuarios)
            {
                if (item != null)
                {
                    uvm.ListaDeUsuarios.Add(item);
                }
            }
            return View(uvm);
        }

        [HttpGet]
        public IActionResult FazerLogout()
        {
            HttpContext.Session.Remove(SESSION_EMAIL);
            HttpContext.Session.Remove(SESSION_ADMIN);
            HttpContext.Session.Clear();

            return RedirectToAction("Index", "Home");
        }
    }///////////////////////////////////////////////////////////**FIM**//////////////////////////////////////////////////////////////////////////////
}