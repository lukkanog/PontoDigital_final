#pragma checksum "c:\Users\USER\Desktop\PontoDigital_final\Views\Administrador\FiltrarResultados.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6d8b259024e7fc946210c154926c367207bb62ce"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Administrador_FiltrarResultados), @"mvc.1.0.view", @"/Views/Administrador/FiltrarResultados.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Administrador/FiltrarResultados.cshtml", typeof(AspNetCore.Views_Administrador_FiltrarResultados))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6d8b259024e7fc946210c154926c367207bb62ce", @"/Views/Administrador/FiltrarResultados.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8a12cf24a622b5515d7b44a1d5000cf1eb2c499a", @"/Views/_ViewImports.cshtml")]
    public class Views_Administrador_FiltrarResultados : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PontoDigital_final.ViewModels.ComentarioViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "c:\Users\USER\Desktop\PontoDigital_final\Views\Administrador\FiltrarResultados.cshtml"
  
    ViewData["Title"] = "Comentarios | Ponto Digital";
    ViewData["css"] = "aprovar_comentarios-style.css";

#line default
#line hidden
            BeginContext(177, 63, true);
            WriteLiteral("\r\n<main class=\"container\">\r\n    <div class=\"content\">\r\n\r\n    \r\n");
            EndContext();
#line 11 "c:\Users\USER\Desktop\PontoDigital_final\Views\Administrador\FiltrarResultados.cshtml"
     if (Model.ListaDeComentarios.Count == 0)
    {

#line default
#line hidden
            BeginContext(294, 51, true);
            WriteLiteral("        <h2>Resultado não encontrado</h2>\r\n        ");
            EndContext();
            BeginContext(345, 559, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6cfcab1a492240cc9edd77e613220fe2", async() => {
                BeginContext(423, 474, true);
                WriteLiteral(@"
                <div class=""campo"">
                    <label for=""id"">Filtrar por ID do comentário</label>
                    <input type=""text"" name=""id"" placeholder=""ID do comentário"">
                </div>
                <div class=""campo"">
                    <label for=""data"">Filtrar por Data</label>
                    <input type=""date"" name=""data"" id=""data"">
                </div>
                <input type=""submit"" value=""Filtrar"">
            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
#line 14 "c:\Users\USER\Desktop\PontoDigital_final\Views\Administrador\FiltrarResultados.cshtml"
AddHtmlAttributeValue("", 373, Url.Action("FiltrarResultados","Administrador"), 373, 48, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(904, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 25 "c:\Users\USER\Desktop\PontoDigital_final\Views\Administrador\FiltrarResultados.cshtml"
    } else 
    {

#line default
#line hidden
            BeginContext(926, 39, true);
            WriteLiteral("        <h2>Resultados filtrados</h2>\r\n");
            EndContext();
            BeginContext(967, 8, true);
            WriteLiteral("        ");
            EndContext();
            BeginContext(975, 528, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8cc450b9a4a94d25802ec3d97f3d7905", async() => {
                BeginContext(1053, 443, true);
                WriteLiteral(@"
                <div class=""campo"">
                    <label for=""id"">Filtrar por ID do comentário</label>
                    <input type=""text"" name=""id"">
                </div>
                <div class=""campo"">
                    <label for=""data"">Filtrar por Data</label>
                    <input type=""date"" name=""data"" id=""data"">
                </div>
                <input type=""submit"" value=""Filtrar"">
            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
#line 29 "c:\Users\USER\Desktop\PontoDigital_final\Views\Administrador\FiltrarResultados.cshtml"
AddHtmlAttributeValue("", 1003, Url.Action("FiltrarResultados","Administrador"), 1003, 48, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1503, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 41 "c:\Users\USER\Desktop\PontoDigital_final\Views\Administrador\FiltrarResultados.cshtml"
         foreach (var comentario in Model.ListaDeComentarios)
        {

#line default
#line hidden
            BeginContext(1581, 54, true);
            WriteLiteral("            <div class=\"pessoa\">\r\n                <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 1635, "\"", 1666, 1);
#line 44 "c:\Users\USER\Desktop\PontoDigital_final\Views\Administrador\FiltrarResultados.cshtml"
WriteAttributeValue("", 1641, comentario.Autor.UrlFoto, 1641, 25, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1667, 95, true);
            WriteLiteral(" alt=\"Foto de Perfil\">\r\n                <div class=\"texto\">\r\n                    <p><b>ID:</b> ");
            EndContext();
            BeginContext(1763, 13, false);
#line 46 "c:\Users\USER\Desktop\PontoDigital_final\Views\Administrador\FiltrarResultados.cshtml"
                             Write(comentario.Id);

#line default
#line hidden
            EndContext();
            BeginContext(1776, 43, true);
            WriteLiteral("</p>\r\n                    <p><b>Autor:</b> ");
            EndContext();
            BeginContext(1820, 21, false);
#line 47 "c:\Users\USER\Desktop\PontoDigital_final\Views\Administrador\FiltrarResultados.cshtml"
                                Write(comentario.Autor.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(1841, 3, true);
            WriteLiteral(" - ");
            EndContext();
            BeginContext(1845, 29, false);
#line 47 "c:\Users\USER\Desktop\PontoDigital_final\Views\Administrador\FiltrarResultados.cshtml"
                                                         Write(comentario.Autor.Empresa.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(1874, 57, true);
            WriteLiteral("</p>\r\n                    <p><b>Comentario feito em:</b> ");
            EndContext();
            BeginContext(1932, 27, false);
#line 48 "c:\Users\USER\Desktop\PontoDigital_final\Views\Administrador\FiltrarResultados.cshtml"
                                              Write(comentario.DataDoComentario);

#line default
#line hidden
            EndContext();
            BeginContext(1959, 47, true);
            WriteLiteral("</p>\r\n                    <p><b>Avaliação:</b> ");
            EndContext();
            BeginContext(2007, 18, false);
#line 49 "c:\Users\USER\Desktop\PontoDigital_final\Views\Administrador\FiltrarResultados.cshtml"
                                    Write(comentario.Assunto);

#line default
#line hidden
            EndContext();
            BeginContext(2025, 29, true);
            WriteLiteral("</p>\r\n                    <p>");
            EndContext();
            BeginContext(2055, 19, false);
#line 50 "c:\Users\USER\Desktop\PontoDigital_final\Views\Administrador\FiltrarResultados.cshtml"
                  Write(comentario.Mensagem);

#line default
#line hidden
            EndContext();
            BeginContext(2074, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 51 "c:\Users\USER\Desktop\PontoDigital_final\Views\Administrador\FiltrarResultados.cshtml"
                     if (comentario.EstaAprovado == false)
                    {

#line default
#line hidden
            BeginContext(2163, 26, true);
            WriteLiteral("                        <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2189, "\"", 2246, 2);
            WriteAttributeValue("", 2196, "/Administrador/AprovarComentario?id=", 2196, 36, true);
#line 53 "c:\Users\USER\Desktop\PontoDigital_final\Views\Administrador\FiltrarResultados.cshtml"
WriteAttributeValue("", 2232, comentario.Id, 2232, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2247, 14, true);
            WriteLiteral(">Aprovar</a>\r\n");
            EndContext();
#line 54 "c:\Users\USER\Desktop\PontoDigital_final\Views\Administrador\FiltrarResultados.cshtml"
                    } else
                    {

#line default
#line hidden
            BeginContext(2312, 26, true);
            WriteLiteral("                        <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2338, "\"", 2395, 2);
            WriteAttributeValue("", 2345, "/Administrador/RecusarComentario?id=", 2345, 36, true);
#line 56 "c:\Users\USER\Desktop\PontoDigital_final\Views\Administrador\FiltrarResultados.cshtml"
WriteAttributeValue("", 2381, comentario.Id, 2381, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2396, 22, true);
            WriteLiteral(">Não exibir mais</a>\r\n");
            EndContext();
#line 57 "c:\Users\USER\Desktop\PontoDigital_final\Views\Administrador\FiltrarResultados.cshtml"
                    }

#line default
#line hidden
            BeginContext(2441, 74, true);
            WriteLiteral("                </div>\r\n                    \r\n            </div>        \r\n");
            EndContext();
#line 61 "c:\Users\USER\Desktop\PontoDigital_final\Views\Administrador\FiltrarResultados.cshtml"
        }

#line default
#line hidden
#line 61 "c:\Users\USER\Desktop\PontoDigital_final\Views\Administrador\FiltrarResultados.cshtml"
         
    }

#line default
#line hidden
            BeginContext(2533, 19, true);
            WriteLiteral("    </div>\r\n</main>");
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
