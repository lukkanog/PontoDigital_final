#pragma checksum "C:\Users\46735197879\Desktop\PontoDigital_final\Views\Administrador\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0e08c9bc5d256102ea071b666423d6828b05bd76"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Administrador_Index), @"mvc.1.0.view", @"/Views/Administrador/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Administrador/Index.cshtml", typeof(AspNetCore.Views_Administrador_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0e08c9bc5d256102ea071b666423d6828b05bd76", @"/Views/Administrador/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"03e2adbe3d9845469481b41f01920e08f481df38", @"/Views/_ViewImports.cshtml")]
    public class Views_Administrador_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PontoDigital_final.ViewModels.AdministradorViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\46735197879\Desktop\PontoDigital_final\Views\Administrador\Index.cshtml"
  
    ViewData["Title"] = "Administrador | Ponto Digital";
    ViewData["css"] = "dashboard-style.css";

#line default
#line hidden
            BeginContext(172, 10, true);
            WriteLiteral("\r\n<main>\r\n");
            EndContext();
#line 8 "C:\Users\46735197879\Desktop\PontoDigital_final\Views\Administrador\Index.cshtml"
     if (Model != null)
    {

#line default
#line hidden
            BeginContext(214, 28, true);
            WriteLiteral("        <h2>Seja bem vindo, ");
            EndContext();
            BeginContext(243, 10, false);
#line 10 "C:\Users\46735197879\Desktop\PontoDigital_final\Views\Administrador\Index.cshtml"
                       Write(Model.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(253, 7, true);
            WriteLiteral("</h2>\r\n");
            EndContext();
#line 11 "C:\Users\46735197879\Desktop\PontoDigital_final\Views\Administrador\Index.cshtml"
    } else {

#line default
#line hidden
            BeginContext(274, 49, true);
            WriteLiteral("        <h2>Seja bem vindo, administrador!</h2>\r\n");
            EndContext();
#line 13 "C:\Users\46735197879\Desktop\PontoDigital_final\Views\Administrador\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(330, 72, true);
            WriteLiteral("\r\n    <div class=\"flex-me\">\r\n        <div class=\"links\">\r\n            <a");
            EndContext();
            BeginWriteAttribute("href", " href=\'", 402, "\'", 458, 1);
#line 17 "C:\Users\46735197879\Desktop\PontoDigital_final\Views\Administrador\Index.cshtml"
WriteAttributeValue("", 409, Url.Action("AprovarComentarios","Administrador"), 409, 49, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(459, 42, true);
            WriteLiteral(">Gerenciar comentários</a>\r\n            <a");
            EndContext();
            BeginWriteAttribute("href", " href=\'", 501, "\'", 561, 1);
#line 18 "C:\Users\46735197879\Desktop\PontoDigital_final\Views\Administrador\Index.cshtml"
WriteAttributeValue("", 508, Url.Action("CadastrarAdministrador","Administrador"), 508, 53, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(562, 49, true);
            WriteLiteral(">Cadastrar novo administrador</a>\r\n            <a");
            EndContext();
            BeginWriteAttribute("href", " href=\'", 611, "\'", 663, 1);
#line 19 "C:\Users\46735197879\Desktop\PontoDigital_final\Views\Administrador\Index.cshtml"
WriteAttributeValue("", 618, Url.Action("ExibirUsuarios","Administrador"), 618, 45, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(664, 515, true);
            WriteLiteral(@">Ver lista de usuários</a>
        </div>
        <div class=""infos"">
            <h3>Informações</h3>
            <table>
                <thead>
                    <tr>
                        <th>Usuários Cadastrados</th>
                        <th>Depoimentos cadastrados</th>
                        <th>Depoimentos aprovados</th>
                        <th>Depoimentos não aprovados</th>
                    </tr>
                </thead>
                    <tr>
                        <td>");
            EndContext();
            BeginContext(1180, 27, false);
#line 33 "C:\Users\46735197879\Desktop\PontoDigital_final\Views\Administrador\Index.cshtml"
                       Write(Model.ListaDeUsuarios.Count);

#line default
#line hidden
            EndContext();
            BeginContext(1207, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(1243, 30, false);
#line 34 "C:\Users\46735197879\Desktop\PontoDigital_final\Views\Administrador\Index.cshtml"
                       Write(Model.ListaDeComentarios.Count);

#line default
#line hidden
            EndContext();
            BeginContext(1273, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(1309, 26, false);
#line 35 "C:\Users\46735197879\Desktop\PontoDigital_final\Views\Administrador\Index.cshtml"
                       Write(Model.ComentariosAprovados);

#line default
#line hidden
            EndContext();
            BeginContext(1335, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(1371, 26, false);
#line 36 "C:\Users\46735197879\Desktop\PontoDigital_final\Views\Administrador\Index.cshtml"
                       Write(Model.ComentariosRecusados);

#line default
#line hidden
            EndContext();
            BeginContext(1397, 187, true);
            WriteLiteral("</td>\r\n                    </tr>\r\n                <tbody>\r\n                    <tr></tr>\r\n                </tbody>\r\n            </table>\r\n            <!-- <p><b>Usuários cadastrados:</b> ");
            EndContext();
            BeginContext(1585, 27, false);
#line 42 "C:\Users\46735197879\Desktop\PontoDigital_final\Views\Administrador\Index.cshtml"
                                            Write(Model.ListaDeUsuarios.Count);

#line default
#line hidden
            EndContext();
            BeginContext(1612, 53, true);
            WriteLiteral("</p>\r\n            <p><b>Depoimentos cadastrados:</b> ");
            EndContext();
            BeginContext(1666, 30, false);
#line 43 "C:\Users\46735197879\Desktop\PontoDigital_final\Views\Administrador\Index.cshtml"
                                          Write(Model.ListaDeComentarios.Count);

#line default
#line hidden
            EndContext();
            BeginContext(1696, 51, true);
            WriteLiteral("</p>\r\n            <p><b>Depoimentos aprovados:</b> ");
            EndContext();
            BeginContext(1748, 26, false);
#line 44 "C:\Users\46735197879\Desktop\PontoDigital_final\Views\Administrador\Index.cshtml"
                                        Write(Model.ComentariosAprovados);

#line default
#line hidden
            EndContext();
            BeginContext(1774, 53, true);
            WriteLiteral("</p>\r\n            <p><b>Depoimnetos reprovados::</b> ");
            EndContext();
            BeginContext(1828, 26, false);
#line 45 "C:\Users\46735197879\Desktop\PontoDigital_final\Views\Administrador\Index.cshtml"
                                          Write(Model.ComentariosRecusados);

#line default
#line hidden
            EndContext();
            BeginContext(1854, 45, true);
            WriteLiteral("</p>\r\n        </div> -->\r\n    </div>\r\n</main>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PontoDigital_final.ViewModels.AdministradorViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
