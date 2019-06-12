using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PontoDigital_final.Models;
using PontoDigital_final.Repositories;
using PontoDigital_final.ViewModels;

namespace PontoDigital_final.Controllers
{
    public class HomeController : Controller
    {
        private const string  SESSION_EMAIL = "_EMAIL";
        private const string SESSION_USUARIO = "_USUARIO";
        private const string SESSION_ADMIN = "_ADMINISTRADOR";
        UsuarioRepository usuarioRepositorio = new UsuarioRepository();
    
        public IActionResult Index()
        {
            // var baseViewModel = new BaseViewModel();
            // baseViewModel.User = HttpContext.Session.GetString(SESSION_USUARIO);
            ViewBag.Admin = HttpContext.Session.GetString(SESSION_ADMIN);
            ViewBag.User = HttpContext.Session.GetString(SESSION_USUARIO);
            return View();
        }
        public IActionResult ComoFunciona()
        {
            ViewBag.Admin = HttpContext.Session.GetString(SESSION_ADMIN);
            ViewBag.User = HttpContext.Session.GetString(SESSION_USUARIO);
            return View();
        }
        public IActionResult Planos()
        {
            ViewBag.Admin = HttpContext.Session.GetString(SESSION_ADMIN);
            ViewBag.User = HttpContext.Session.GetString(SESSION_USUARIO);
            return View();
        }

        public IActionResult Contato()
        {
            ViewBag.Admin = HttpContext.Session.GetString(SESSION_ADMIN);
            ViewBag.User = HttpContext.Session.GetString(SESSION_USUARIO);
            return View();
        }
        public IActionResult QuemSomos()
        {
            ViewBag.Admin = HttpContext.Session.GetString(SESSION_ADMIN);
            ViewBag.User = HttpContext.Session.GetString(SESSION_USUARIO);
            return View();
        }

        public IActionResult Faq()
        {
            ViewBag.Admin = HttpContext.Session.GetString(SESSION_ADMIN);
            ViewBag.User = HttpContext.Session.GetString(SESSION_USUARIO);
            return View();
        }



        // public IActionResult About()
        // {
        //     ViewData["Message"] = "Your application description page.";

        //     return View();
        // }

        // public IActionResult Contact()
        // {
        //     ViewData["Message"] = "Your contact page.";

        //     return View();
        // }

        // public IActionResult Privacy()
        // {
        //     return View();
        // }

        // [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        // public IActionResult Error()
        // {
        //     return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        // }
    }
}
