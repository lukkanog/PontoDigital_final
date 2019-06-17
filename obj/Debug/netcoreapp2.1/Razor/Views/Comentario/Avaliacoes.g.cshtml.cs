#pragma checksum "C:\Users\46735197879\Desktop\PontoDigital_final\Views\Comentario\Avaliacoes.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f2336edb863f3c21b8de9c38c289463de11c002f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Comentario_Avaliacoes), @"mvc.1.0.view", @"/Views/Comentario/Avaliacoes.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Comentario/Avaliacoes.cshtml", typeof(AspNetCore.Views_Comentario_Avaliacoes))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\46735197879\Desktop\PontoDigital_final\Views\_ViewImports.cshtml"
using PontoDigital_final;

#line default
#line hidden
#line 2 "C:\Users\46735197879\Desktop\PontoDigital_final\Views\_ViewImports.cshtml"
using PontoDigital_final.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f2336edb863f3c21b8de9c38c289463de11c002f", @"/Views/Comentario/Avaliacoes.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"03e2adbe3d9845469481b41f01920e08f481df38", @"/Views/_ViewImports.cshtml")]
    public class Views_Comentario_Avaliacoes : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PontoDigital_final.ViewModels.ComentarioViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\46735197879\Desktop\PontoDigital_final\Views\Comentario\Avaliacoes.cshtml"
  
    ViewData["Title"] = "Avaliações | Ponto Digital";
    ViewData["css"] = "avaliações-style.css";

#line default
#line hidden
            BeginContext(167, 117, true);
            WriteLiteral("\r\n<main class=\"container\">\r\n    <section class=\"content\">\r\n        <h2>Avaliações de alguns de nossos clientes</h2>\r\n");
            EndContext();
#line 10 "C:\Users\46735197879\Desktop\PontoDigital_final\Views\Comentario\Avaliacoes.cshtml"
             foreach (var comentario in Model.ListaDeComentarios)
            {

#line default
#line hidden
            BeginContext(366, 62, true);
            WriteLiteral("                <div class=\"pessoa\">\r\n                    <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 428, "\"", 459, 1);
#line 13 "C:\Users\46735197879\Desktop\PontoDigital_final\Views\Comentario\Avaliacoes.cshtml"
WriteAttributeValue("", 434, comentario.Autor.UrlFoto, 434, 25, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(460, 93, true);
            WriteLiteral(" alt=\"Foto de perfil\">\r\n                    <div class=\"texto\">\r\n                        <h3>");
            EndContext();
            BeginContext(554, 21, false);
#line 15 "C:\Users\46735197879\Desktop\PontoDigital_final\Views\Comentario\Avaliacoes.cshtml"
                       Write(comentario.Autor.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(575, 3, true);
            WriteLiteral(" - ");
            EndContext();
            BeginContext(579, 29, false);
#line 15 "C:\Users\46735197879\Desktop\PontoDigital_final\Views\Comentario\Avaliacoes.cshtml"
                                                Write(comentario.Autor.Empresa.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(608, 35, true);
            WriteLiteral("</h3>\r\n                        <h4>");
            EndContext();
            BeginContext(644, 18, false);
#line 16 "C:\Users\46735197879\Desktop\PontoDigital_final\Views\Comentario\Avaliacoes.cshtml"
                       Write(comentario.Assunto);

#line default
#line hidden
            EndContext();
            BeginContext(662, 34, true);
            WriteLiteral("</h4>\r\n                        <p>");
            EndContext();
            BeginContext(697, 19, false);
#line 17 "C:\Users\46735197879\Desktop\PontoDigital_final\Views\Comentario\Avaliacoes.cshtml"
                      Write(comentario.Mensagem);

#line default
#line hidden
            EndContext();
            BeginContext(716, 43, true);
            WriteLiteral("</p>\r\n                        <p id=\"data\">");
            EndContext();
            BeginContext(760, 47, false);
#line 18 "C:\Users\46735197879\Desktop\PontoDigital_final\Views\Comentario\Avaliacoes.cshtml"
                                Write(comentario.DataDoComentario.ToShortDateString());

#line default
#line hidden
            EndContext();
            BeginContext(807, 58, true);
            WriteLiteral("</p>\r\n                    </div>\r\n                </div>\r\n");
            EndContext();
#line 21 "C:\Users\46735197879\Desktop\PontoDigital_final\Views\Comentario\Avaliacoes.cshtml"
            }

#line default
#line hidden
            BeginContext(880, 10, true);
            WriteLiteral("        <a");
            EndContext();
            BeginWriteAttribute("href", " href=\'", 890, "\'", 944, 1);
#line 22 "C:\Users\46735197879\Desktop\PontoDigital_final\Views\Comentario\Avaliacoes.cshtml"
WriteAttributeValue("", 897, Url.Action("CadastrarComentario","Comentario"), 897, 47, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(945, 49, true);
            WriteLiteral(">Envie sua avaliação</a>\r\n    </section>\r\n</main>");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PontoDigital_final.ViewModels.ComentarioViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
