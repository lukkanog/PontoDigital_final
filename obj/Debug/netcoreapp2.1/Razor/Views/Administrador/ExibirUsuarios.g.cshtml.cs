#pragma checksum "C:\Users\46735197879\Desktop\lucas\WebMvc\PontoDigital_final\Views\Administrador\ExibirUsuarios.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "11c442c1dc2432e8f1846281b84cc50306fc6569"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Administrador_ExibirUsuarios), @"mvc.1.0.view", @"/Views/Administrador/ExibirUsuarios.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Administrador/ExibirUsuarios.cshtml", typeof(AspNetCore.Views_Administrador_ExibirUsuarios))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"11c442c1dc2432e8f1846281b84cc50306fc6569", @"/Views/Administrador/ExibirUsuarios.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"03e2adbe3d9845469481b41f01920e08f481df38", @"/Views/_ViewImports.cshtml")]
    public class Views_Administrador_ExibirUsuarios : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PontoDigital_final.ViewModels.UsuarioViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/usuario_defaultpicture.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Foto de perfil"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\46735197879\Desktop\lucas\WebMvc\PontoDigital_final\Views\Administrador\ExibirUsuarios.cshtml"
  
    ViewData["Title"] = "Avaliações | Ponto Digital";
    ViewData["css"] = "avaliações-style.css";

#line default
#line hidden
            BeginContext(164, 98, true);
            WriteLiteral("\r\n<main class=\"container\">\r\n    <section class=\"content\">\r\n        <h2>Usuários cadastrados</h2>\r\n");
            EndContext();
#line 10 "C:\Users\46735197879\Desktop\lucas\WebMvc\PontoDigital_final\Views\Administrador\ExibirUsuarios.cshtml"
         if (Model.ListaDeUsuarios.Count == 0)
        {

#line default
#line hidden
            BeginContext(321, 69, true);
            WriteLiteral("            <h2>Ainda não há usuários cadastrados no programa!</h2>\r\n");
            EndContext();
#line 13 "C:\Users\46735197879\Desktop\lucas\WebMvc\PontoDigital_final\Views\Administrador\ExibirUsuarios.cshtml"
        }

#line default
#line hidden
            BeginContext(401, 8, true);
            WriteLiteral("        ");
            EndContext();
#line 14 "C:\Users\46735197879\Desktop\lucas\WebMvc\PontoDigital_final\Views\Administrador\ExibirUsuarios.cshtml"
         foreach (var item in Model.ListaDeUsuarios)
        {

#line default
#line hidden
            BeginContext(466, 50, true);
            WriteLiteral("            <div class=\"pessoa\">\r\n                ");
            EndContext();
            BeginContext(516, 65, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "8fa2c9a00365435e9c764aeb79eb3c49", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(581, 75, true);
            WriteLiteral("\r\n                <div class=\"texto\">\r\n                    <p><b>Nome:</b> ");
            EndContext();
            BeginContext(657, 9, false);
#line 19 "C:\Users\46735197879\Desktop\lucas\WebMvc\PontoDigital_final\Views\Administrador\ExibirUsuarios.cshtml"
                               Write(item.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(666, 40, true);
            WriteLiteral("</p>\r\n                    <p><b>Id:</b> ");
            EndContext();
            BeginContext(707, 7, false);
#line 20 "C:\Users\46735197879\Desktop\lucas\WebMvc\PontoDigital_final\Views\Administrador\ExibirUsuarios.cshtml"
                             Write(item.Id);

#line default
#line hidden
            EndContext();
            BeginContext(714, 44, true);
            WriteLiteral("</p>\r\n                    <p><b>Gênero:</b> ");
            EndContext();
            BeginContext(759, 11, false);
#line 21 "C:\Users\46735197879\Desktop\lucas\WebMvc\PontoDigital_final\Views\Administrador\ExibirUsuarios.cshtml"
                                 Write(item.Genero);

#line default
#line hidden
            EndContext();
            BeginContext(770, 45, true);
            WriteLiteral("</p>\r\n                    <p><b>Empresa:</b> ");
            EndContext();
            BeginContext(816, 17, false);
#line 22 "C:\Users\46735197879\Desktop\lucas\WebMvc\PontoDigital_final\Views\Administrador\ExibirUsuarios.cshtml"
                                  Write(item.Empresa.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(833, 43, true);
            WriteLiteral("</p>\r\n                    <p><b>Email</b>: ");
            EndContext();
            BeginContext(877, 10, false);
#line 23 "C:\Users\46735197879\Desktop\lucas\WebMvc\PontoDigital_final\Views\Administrador\ExibirUsuarios.cshtml"
                                Write(item.Email);

#line default
#line hidden
            EndContext();
            BeginContext(887, 46, true);
            WriteLiteral("</p>\r\n                    <p><b>Telefone:</b> ");
            EndContext();
            BeginContext(934, 13, false);
#line 24 "C:\Users\46735197879\Desktop\lucas\WebMvc\PontoDigital_final\Views\Administrador\ExibirUsuarios.cshtml"
                                   Write(item.Telefone);

#line default
#line hidden
            EndContext();
            BeginContext(947, 46, true);
            WriteLiteral("</p>\r\n                    <p><b>Endereço:</b> ");
            EndContext();
            BeginContext(994, 13, false);
#line 25 "C:\Users\46735197879\Desktop\lucas\WebMvc\PontoDigital_final\Views\Administrador\ExibirUsuarios.cshtml"
                                   Write(item.Endereco);

#line default
#line hidden
            EndContext();
            BeginContext(1007, 56, true);
            WriteLiteral("</p>\r\n                    <p><b>Data de nascimento:</b> ");
            EndContext();
            BeginContext(1064, 39, false);
#line 26 "C:\Users\46735197879\Desktop\lucas\WebMvc\PontoDigital_final\Views\Administrador\ExibirUsuarios.cshtml"
                                             Write(item.DataNascimento.ToShortDateString());

#line default
#line hidden
            EndContext();
            BeginContext(1103, 53, true);
            WriteLiteral("</p>\r\n                    <p><b>CNPJ da empresa:</b> ");
            EndContext();
            BeginContext(1157, 17, false);
#line 27 "C:\Users\46735197879\Desktop\lucas\WebMvc\PontoDigital_final\Views\Administrador\ExibirUsuarios.cshtml"
                                          Write(item.Empresa.Cnpj);

#line default
#line hidden
            EndContext();
            BeginContext(1174, 50, true);
            WriteLiteral("</p>\r\n                </div>\r\n            </div>\r\n");
            EndContext();
#line 30 "C:\Users\46735197879\Desktop\lucas\WebMvc\PontoDigital_final\Views\Administrador\ExibirUsuarios.cshtml"
        }

#line default
#line hidden
            BeginContext(1235, 23, true);
            WriteLiteral("    </section>\r\n</main>");
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
