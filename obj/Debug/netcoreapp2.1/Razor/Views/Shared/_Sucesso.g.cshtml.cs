#pragma checksum "C:\Users\46735197879\Desktop\lucas\WebMvc\PontoDigital_final\Views\Shared\_Sucesso.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d750a95beeebd3f5fccf5406fcafa4e243cfebd3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Sucesso), @"mvc.1.0.view", @"/Views/Shared/_Sucesso.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_Sucesso.cshtml", typeof(AspNetCore.Views_Shared__Sucesso))]
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
#line 1 "C:\Users\46735197879\Desktop\lucas\WebMvc\PontoDigital_final\Views\_ViewImports.cshtml"
using PontoDigital_final;

#line default
#line hidden
#line 2 "C:\Users\46735197879\Desktop\lucas\WebMvc\PontoDigital_final\Views\_ViewImports.cshtml"
using PontoDigital_final.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d750a95beeebd3f5fccf5406fcafa4e243cfebd3", @"/Views/Shared/_Sucesso.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"03e2adbe3d9845469481b41f01920e08f481df38", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Sucesso : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PontoDigital_final.ViewModels.SucessoViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\46735197879\Desktop\lucas\WebMvc\PontoDigital_final\Views\Shared\_Sucesso.cshtml"
  
    ViewData["Title"] = "Sucesso | Ponto Digital";
    ViewData["css"] = "erro-style.css";

    if (string.IsNullOrEmpty((string)TempData["sucesso"]) || string.IsNullOrEmpty((string)TempData["voltar"]))
    {
        Model.Mensagem = "Ação realizada com sucesso!";
        Model.LinkVoltar = "Home/Index";
    } else
    {
        Model.Mensagem = (string)TempData["sucesso"];
        Model.LinkVoltar = (string)TempData["voltar"];
    }

#line default
#line hidden
            BeginContext(512, 38, true);
            WriteLiteral("<main>\r\n    <h2>Sucesso!</h2>\r\n    <p>");
            EndContext();
            BeginContext(551, 14, false);
#line 18 "C:\Users\46735197879\Desktop\lucas\WebMvc\PontoDigital_final\Views\Shared\_Sucesso.cshtml"
  Write(Model.Mensagem);

#line default
#line hidden
            EndContext();
            BeginContext(565, 25, true);
            WriteLiteral("</p>\r\n    <a class=\'link\'");
            EndContext();
            BeginWriteAttribute("href", " href=", 590, "", 613, 1);
#line 19 "C:\Users\46735197879\Desktop\lucas\WebMvc\PontoDigital_final\Views\Shared\_Sucesso.cshtml"
WriteAttributeValue("", 596, Model.LinkVoltar, 596, 17, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(613, 20, true);
            WriteLiteral(">Voltar</a>\r\n</main>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PontoDigital_final.ViewModels.SucessoViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
