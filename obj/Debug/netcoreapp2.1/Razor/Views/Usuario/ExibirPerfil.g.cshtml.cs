#pragma checksum "c:\Users\USER\Desktop\PontoDigital_final\Views\Usuario\ExibirPerfil.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b90e6e8da521213236744c7dad3c92b27420a330"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Usuario_ExibirPerfil), @"mvc.1.0.view", @"/Views/Usuario/ExibirPerfil.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Usuario/ExibirPerfil.cshtml", typeof(AspNetCore.Views_Usuario_ExibirPerfil))]
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
#line 1 "c:\Users\USER\Desktop\PontoDigital_final\Views\_ViewImports.cshtml"
using PontoDigital_final;

#line default
#line hidden
#line 2 "c:\Users\USER\Desktop\PontoDigital_final\Views\_ViewImports.cshtml"
using PontoDigital_final.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b90e6e8da521213236744c7dad3c92b27420a330", @"/Views/Usuario/ExibirPerfil.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8a12cf24a622b5515d7b44a1d5000cf1eb2c499a", @"/Views/_ViewImports.cshtml")]
    public class Views_Usuario_ExibirPerfil : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PontoDigital_final.ViewModels.UsuarioViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "c:\Users\USER\Desktop\PontoDigital_final\Views\Usuario\ExibirPerfil.cshtml"
  
    ViewData["Title"] = "Perfil | Ponto Digital";
    ViewData["css"] = "perfil-style.css";

#line default
#line hidden
            BeginContext(156, 67, true);
            WriteLiteral("<main class=\"container\">\r\n    <div class=\"content\">\r\n\r\n        <h2>");
            EndContext();
            BeginContext(224, 18, false);
#line 9 "c:\Users\USER\Desktop\PontoDigital_final\Views\Usuario\ExibirPerfil.cshtml"
       Write(Model.Usuario.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(242, 88, true);
            WriteLiteral("</h2>\r\n        <div id=\"dados-perfil\">\r\n            <div>\r\n                <p>Endereço: ");
            EndContext();
            BeginContext(331, 22, false);
#line 12 "c:\Users\USER\Desktop\PontoDigital_final\Views\Usuario\ExibirPerfil.cshtml"
                        Write(Model.Usuario.Endereco);

#line default
#line hidden
            EndContext();
            BeginContext(353, 35, true);
            WriteLiteral("</p>\r\n                <p>Telefone: ");
            EndContext();
            BeginContext(389, 22, false);
#line 13 "c:\Users\USER\Desktop\PontoDigital_final\Views\Usuario\ExibirPerfil.cshtml"
                        Write(Model.Usuario.Telefone);

#line default
#line hidden
            EndContext();
            BeginContext(411, 45, true);
            WriteLiteral("</p>\r\n                <p>Data de nascimento: ");
            EndContext();
            BeginContext(457, 48, false);
#line 14 "c:\Users\USER\Desktop\PontoDigital_final\Views\Usuario\ExibirPerfil.cshtml"
                                  Write(Model.Usuario.DataNascimento.ToShortDateString());

#line default
#line hidden
            EndContext();
            BeginContext(505, 34, true);
            WriteLiteral("</p>\r\n                <p>Empresa: ");
            EndContext();
            BeginContext(540, 26, false);
#line 15 "c:\Users\USER\Desktop\PontoDigital_final\Views\Usuario\ExibirPerfil.cshtml"
                       Write(Model.Usuario.Empresa.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(566, 42, true);
            WriteLiteral("</p>\r\n                <p>CNPJ da empresa: ");
            EndContext();
            BeginContext(609, 26, false);
#line 16 "c:\Users\USER\Desktop\PontoDigital_final\Views\Usuario\ExibirPerfil.cshtml"
                               Write(Model.Usuario.Empresa.Cnpj);

#line default
#line hidden
            EndContext();
            BeginContext(635, 136, true);
            WriteLiteral("</p>\r\n            </div>\r\n            \r\n            <div id=\"flex-coluna\">\r\n                <p>Foto de perfil:</p>\r\n                <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 771, "\"", 799, 1);
#line 21 "c:\Users\USER\Desktop\PontoDigital_final\Views\Usuario\ExibirPerfil.cshtml"
WriteAttributeValue("", 777, Model.Usuario.UrlFoto, 777, 22, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(800, 59, true);
            WriteLiteral(" alt=\"Foto de Perfil\" id=\"foto_perfil\">\r\n                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\'", 859, "\'", 903, 1);
#line 22 "c:\Users\USER\Desktop\PontoDigital_final\Views\Usuario\ExibirPerfil.cshtml"
WriteAttributeValue("", 866, Url.Action("EditarPerfil","Usuario"), 866, 37, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(904, 88, true);
            WriteLiteral(" class=\"link\">Editar Perfil</a>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</main>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PontoDigital_final.ViewModels.UsuarioViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
