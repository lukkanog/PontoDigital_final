#pragma checksum "C:\Users\46735197879\Desktop\PontoDigital_final\Views\Usuario\EditarPerfil.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9ff4271cf5451f0475eedfa7e67a557be53a297d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Usuario_EditarPerfil), @"mvc.1.0.view", @"/Views/Usuario/EditarPerfil.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Usuario/EditarPerfil.cshtml", typeof(AspNetCore.Views_Usuario_EditarPerfil))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9ff4271cf5451f0475eedfa7e67a557be53a297d", @"/Views/Usuario/EditarPerfil.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"03e2adbe3d9845469481b41f01920e08f481df38", @"/Views/_ViewImports.cshtml")]
    public class Views_Usuario_EditarPerfil : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PontoDigital_final.ViewModels.UsuarioViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\46735197879\Desktop\PontoDigital_final\Views\Usuario\EditarPerfil.cshtml"
  
    ViewData["Title"] = "Editar Perfil | Ponto Digital";
    ViewData["css"] = "faleconosco-style.css";

#line default
#line hidden
            BeginContext(168, 73, true);
            WriteLiteral("<main class=\"container\">\r\n        <div class=\"content\">\r\n            <h2>");
            EndContext();
            BeginContext(242, 20, false);
#line 8 "C:\Users\46735197879\Desktop\PontoDigital_final\Views\Usuario\EditarPerfil.cshtml"
           Write(ViewData["Mensagem"]);

#line default
#line hidden
            EndContext();
            BeginContext(262, 19, true);
            WriteLiteral("</h2>\r\n            ");
            EndContext();
            BeginContext(281, 1984, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cce6fb6e31364f3c8458002112278544", async() => {
                BeginContext(378, 184, true);
                WriteLiteral("\r\n                <div class=\"campo\">\r\n                    <label for=\"nome\">Nome completo</label>\r\n                    <input type=\"text\" name=\"nome\" placeholder=\"Nome\" maxlength=\"50\"");
                EndContext();
                BeginWriteAttribute("value", "  value=\"", 562, "\"", 590, 1);
#line 12 "C:\Users\46735197879\Desktop\PontoDigital_final\Views\Usuario\EditarPerfil.cshtml"
WriteAttributeValue("", 571, Model.Usuario.Nome, 571, 19, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(591, 245, true);
                WriteLiteral(" required>\r\n                </div>\r\n                <div class=\"campo\">\r\n                    <label for=\"telefone\">Número de telefone</label>\r\n                    <input type=\"text\" name=\"telefone\" placeholder=\"Número de telefone\" maxlength=\"12\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 836, "\"", 867, 1);
#line 16 "C:\Users\46735197879\Desktop\PontoDigital_final\Views\Usuario\EditarPerfil.cshtml"
WriteAttributeValue("", 844, Model.Usuario.Telefone, 844, 23, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(868, 229, true);
                WriteLiteral(" required>\r\n                </div>\r\n                <div class=\"campo\">\r\n                    <label for=\"endereco\">Endereço</label>\r\n                    <input type=\"text\" name=\"endereco\" placeholder=\"Seu Endereço\" maxlength=\"70\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1097, "\"", 1128, 1);
#line 20 "C:\Users\46735197879\Desktop\PontoDigital_final\Views\Usuario\EditarPerfil.cshtml"
WriteAttributeValue("", 1105, Model.Usuario.Endereco, 1105, 23, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1129, 238, true);
                WriteLiteral(" required>\r\n                </div>\r\n                <div class=\"campo\">\r\n                    <label for=\"dataNascimento\">Data de nascimento</label>\r\n                <input type=\"date\" name=\"dataNascimento\" placeholder=\"Data de Nascimento\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1367, "\"", 1404, 1);
#line 24 "C:\Users\46735197879\Desktop\PontoDigital_final\Views\Usuario\EditarPerfil.cshtml"
WriteAttributeValue("", 1375, Model.Usuario.DataNascimento, 1375, 29, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1405, 228, true);
                WriteLiteral(">\r\n                </div>\r\n                <div class=\"campo\">\r\n                    <label for=\"empresa\">Empresa em que trabalha</label>\r\n                    <input type=\"text\" name=\"empresa\" placeholder=\"Empresa\" maxlength=\"50\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1633, "\"", 1668, 1);
#line 28 "C:\Users\46735197879\Desktop\PontoDigital_final\Views\Usuario\EditarPerfil.cshtml"
WriteAttributeValue("", 1641, Model.Usuario.Empresa.Nome, 1641, 27, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1669, 231, true);
                WriteLiteral(" required>\r\n                </div>\r\n                <div class=\"campo\">\r\n                    <label for=\"cnpj\">CNPJ da empresa</label>\r\n                    <input type=\"text\" name=\"cnpj\" placeholder=\"CNPJ da empresa\" maxlength=\"40\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1900, "\"", 1935, 1);
#line 32 "C:\Users\46735197879\Desktop\PontoDigital_final\Views\Usuario\EditarPerfil.cshtml"
WriteAttributeValue("", 1908, Model.Usuario.Empresa.Cnpj, 1908, 27, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1936, 322, true);
                WriteLiteral(@" required>
                </div>
                <div class=""campo"">
                    <label for=""foto"">Foto de Perfil</label>
                    <input type=""file"" name=""foto"" id=""foto-campo"">
                </div>

                <input type=""submit"" value=""Salvar alterações"" class=""submit"">
            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
#line 9 "C:\Users\46735197879\Desktop\PontoDigital_final\Views\Usuario\EditarPerfil.cshtml"
AddHtmlAttributeValue("", 295, Url.Action("EditarPerfil","Usuario"), 295, 37, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2265, 29, true);
            WriteLiteral("\r\n        </div>\r\n    </main>");
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
