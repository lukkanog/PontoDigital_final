#pragma checksum "C:\Users\46735197879\Desktop\PontoDigital_final\Views\Administrador\AprovarComentarios.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cf668bf8053bdb55a5eb4fa0504ce07c6d9a7877"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Administrador_AprovarComentarios), @"mvc.1.0.view", @"/Views/Administrador/AprovarComentarios.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Administrador/AprovarComentarios.cshtml", typeof(AspNetCore.Views_Administrador_AprovarComentarios))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cf668bf8053bdb55a5eb4fa0504ce07c6d9a7877", @"/Views/Administrador/AprovarComentarios.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"03e2adbe3d9845469481b41f01920e08f481df38", @"/Views/_ViewImports.cshtml")]
    public class Views_Administrador_AprovarComentarios : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PontoDigital_final.ViewModels.ComentarioViewModel>
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
#line 2 "C:\Users\46735197879\Desktop\PontoDigital_final\Views\Administrador\AprovarComentarios.cshtml"
  
ViewData["Title"] = "Comentarios | Ponto Digital";
ViewData["css"] = "aprovar_comentarios-style.css";

#line default
#line hidden
            BeginContext(169, 57, true);
            WriteLiteral("\r\n<main class=\"container\">\r\n    <div class=\"content\">\r\n\r\n");
            EndContext();
#line 10 "C:\Users\46735197879\Desktop\PontoDigital_final\Views\Administrador\AprovarComentarios.cshtml"
         if (Model.ListaDeComentarios.Count == 0)
        {

#line default
#line hidden
            BeginContext(288, 66, true);
            WriteLiteral("            <h2>Ainda não há comentários a serem aprovados!</h2>\r\n");
            EndContext();
#line 13 "C:\Users\46735197879\Desktop\PontoDigital_final\Views\Administrador\AprovarComentarios.cshtml"
        } else
        {

#line default
#line hidden
            BeginContext(381, 41, true);
            WriteLiteral("            <h2>Comentarios feitos</h2>\r\n");
            EndContext();
            BeginContext(424, 12, true);
            WriteLiteral("            ");
            EndContext();
            BeginContext(436, 559, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9c141703aa2840ad85b323b6d8c789d8", async() => {
                BeginContext(514, 474, true);
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
#line 17 "C:\Users\46735197879\Desktop\PontoDigital_final\Views\Administrador\AprovarComentarios.cshtml"
AddHtmlAttributeValue("", 464, Url.Action("FiltrarResultados","Administrador"), 464, 48, false);

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
            BeginContext(995, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 29 "C:\Users\46735197879\Desktop\PontoDigital_final\Views\Administrador\AprovarComentarios.cshtml"
             foreach (var comentario in Model.ListaDeComentarios)
            {

#line default
#line hidden
            BeginContext(1081, 54, true);
            WriteLiteral("            <div class=\"pessoa\">\r\n                <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 1135, "\"", 1166, 1);
#line 32 "C:\Users\46735197879\Desktop\PontoDigital_final\Views\Administrador\AprovarComentarios.cshtml"
WriteAttributeValue("", 1141, comentario.Autor.UrlFoto, 1141, 25, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1167, 58, true);
            WriteLiteral(" alt=\"Foto de Perfil\">\r\n                <div class=\"texto\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 1225, "\"", 1244, 1);
#line 33 "C:\Users\46735197879\Desktop\PontoDigital_final\Views\Administrador\AprovarComentarios.cshtml"
WriteAttributeValue("", 1230, comentario.Id, 1230, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1245, 37, true);
            WriteLiteral(">\r\n                    <p><b>ID:</b> ");
            EndContext();
            BeginContext(1283, 13, false);
#line 34 "C:\Users\46735197879\Desktop\PontoDigital_final\Views\Administrador\AprovarComentarios.cshtml"
                             Write(comentario.Id);

#line default
#line hidden
            EndContext();
            BeginContext(1296, 43, true);
            WriteLiteral("</p>\r\n                    <p><b>Autor:</b> ");
            EndContext();
            BeginContext(1340, 21, false);
#line 35 "C:\Users\46735197879\Desktop\PontoDigital_final\Views\Administrador\AprovarComentarios.cshtml"
                                Write(comentario.Autor.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(1361, 3, true);
            WriteLiteral(" - ");
            EndContext();
            BeginContext(1365, 29, false);
#line 35 "C:\Users\46735197879\Desktop\PontoDigital_final\Views\Administrador\AprovarComentarios.cshtml"
                                                         Write(comentario.Autor.Empresa.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(1394, 57, true);
            WriteLiteral("</p>\r\n                    <p><b>Comentario feito em:</b> ");
            EndContext();
            BeginContext(1452, 27, false);
#line 36 "C:\Users\46735197879\Desktop\PontoDigital_final\Views\Administrador\AprovarComentarios.cshtml"
                                              Write(comentario.DataDoComentario);

#line default
#line hidden
            EndContext();
            BeginContext(1479, 47, true);
            WriteLiteral("</p>\r\n                    <p><b>Avaliação:</b> ");
            EndContext();
            BeginContext(1527, 18, false);
#line 37 "C:\Users\46735197879\Desktop\PontoDigital_final\Views\Administrador\AprovarComentarios.cshtml"
                                    Write(comentario.Assunto);

#line default
#line hidden
            EndContext();
            BeginContext(1545, 63, true);
            WriteLiteral("</p>\r\n                    <p class=\"mensagem\"><b>Mensagem:</b> ");
            EndContext();
            BeginContext(1609, 19, false);
#line 38 "C:\Users\46735197879\Desktop\PontoDigital_final\Views\Administrador\AprovarComentarios.cshtml"
                                                    Write(comentario.Mensagem);

#line default
#line hidden
            EndContext();
            BeginContext(1628, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 39 "C:\Users\46735197879\Desktop\PontoDigital_final\Views\Administrador\AprovarComentarios.cshtml"
                     if (comentario.EstaAprovado == false)
                    {

#line default
#line hidden
            BeginContext(1717, 26, true);
            WriteLiteral("                        <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1743, "\"", 1800, 2);
            WriteAttributeValue("", 1750, "/Administrador/AprovarComentario?id=", 1750, 36, true);
#line 41 "C:\Users\46735197879\Desktop\PontoDigital_final\Views\Administrador\AprovarComentarios.cshtml"
WriteAttributeValue("", 1786, comentario.Id, 1786, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1801, 14, true);
            WriteLiteral(">Aprovar</a>\r\n");
            EndContext();
#line 42 "C:\Users\46735197879\Desktop\PontoDigital_final\Views\Administrador\AprovarComentarios.cshtml"
                    } else
                    {

#line default
#line hidden
            BeginContext(1866, 26, true);
            WriteLiteral("                        <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1892, "\"", 1949, 2);
            WriteAttributeValue("", 1899, "/Administrador/RecusarComentario?id=", 1899, 36, true);
#line 44 "C:\Users\46735197879\Desktop\PontoDigital_final\Views\Administrador\AprovarComentarios.cshtml"
WriteAttributeValue("", 1935, comentario.Id, 1935, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1950, 22, true);
            WriteLiteral(">Não exibir mais</a>\r\n");
            EndContext();
#line 45 "C:\Users\46735197879\Desktop\PontoDigital_final\Views\Administrador\AprovarComentarios.cshtml"
                    }

#line default
#line hidden
            BeginContext(1995, 44, true);
            WriteLiteral("                </div>\r\n            </div>\r\n");
            EndContext();
#line 48 "C:\Users\46735197879\Desktop\PontoDigital_final\Views\Administrador\AprovarComentarios.cshtml"
            }

#line default
#line hidden
#line 48 "C:\Users\46735197879\Desktop\PontoDigital_final\Views\Administrador\AprovarComentarios.cshtml"
                
        }

#line default
#line hidden
            BeginContext(2068, 19, true);
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
