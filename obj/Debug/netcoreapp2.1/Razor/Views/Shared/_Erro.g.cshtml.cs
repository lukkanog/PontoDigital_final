#pragma checksum "C:\Users\46735197879\Desktop\PontoDigital_final\Views\Shared\_Erro.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "04bf5bca520acd2d16982c3bc0941242f56284a8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Erro), @"mvc.1.0.view", @"/Views/Shared/_Erro.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_Erro.cshtml", typeof(AspNetCore.Views_Shared__Erro))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"04bf5bca520acd2d16982c3bc0941242f56284a8", @"/Views/Shared/_Erro.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"03e2adbe3d9845469481b41f01920e08f481df38", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Erro : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PontoDigital_final.ViewModels.ErroViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\46735197879\Desktop\PontoDigital_final\Views\Shared\_Erro.cshtml"
  
    ViewData["Title"] = "Erro | Ponto Digital";
    ViewData["css"] = "erro-style.css";

    if (string.IsNullOrEmpty((string)TempData["erro"]) || string.IsNullOrEmpty((string)TempData["voltar"]))
    {
        Model.Mensagem = "Um erro inesperado aconteceu";
        Model.LinkVoltar = "Home/Index";
    } else
    {
        Model.Mensagem = (string)TempData["erro"];
        Model.LinkVoltar = (string)TempData["voltar"];
    }


#line default
#line hidden
            BeginContext(487, 113, true);
            WriteLiteral("<main class=\"container\">\n    <div class=\"content\">\n        <h2>Erro</h2>\n        <h3>Oops !</h3>\n        <!-- <p>");
            EndContext();
            BeginContext(601, 16, false);
#line 21 "C:\Users\46735197879\Desktop\PontoDigital_final\Views\Shared\_Erro.cshtml"
           Write(TempData["erro"]);

#line default
#line hidden
            EndContext();
            BeginContext(617, 20, true);
            WriteLiteral("</p> -->\n        <p>");
            EndContext();
            BeginContext(638, 14, false);
#line 22 "C:\Users\46735197879\Desktop\PontoDigital_final\Views\Shared\_Erro.cshtml"
      Write(Model.Mensagem);

#line default
#line hidden
            EndContext();
            BeginContext(652, 28, true);
            WriteLiteral("</p>\n        <a class=\'link\'");
            EndContext();
            BeginWriteAttribute("href", " href=", 680, "", 703, 1);
#line 23 "C:\Users\46735197879\Desktop\PontoDigital_final\Views\Shared\_Erro.cshtml"
WriteAttributeValue("", 686, Model.LinkVoltar, 686, 17, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(703, 30, true);
            WriteLiteral(">Voltar</a>\n    </div>\n</main>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PontoDigital_final.ViewModels.ErroViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
