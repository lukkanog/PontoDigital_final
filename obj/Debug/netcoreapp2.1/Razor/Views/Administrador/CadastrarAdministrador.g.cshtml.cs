#pragma checksum "c:\Users\USER\Desktop\PontoDigital_final\Views\Administrador\CadastrarAdministrador.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "af33dc8b27c7fca2e3e2b5b9ee71cda571a306ea"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Administrador_CadastrarAdministrador), @"mvc.1.0.view", @"/Views/Administrador/CadastrarAdministrador.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Administrador/CadastrarAdministrador.cshtml", typeof(AspNetCore.Views_Administrador_CadastrarAdministrador))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"af33dc8b27c7fca2e3e2b5b9ee71cda571a306ea", @"/Views/Administrador/CadastrarAdministrador.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8a12cf24a622b5515d7b44a1d5000cf1eb2c499a", @"/Views/_ViewImports.cshtml")]
    public class Views_Administrador_CadastrarAdministrador : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
#line 1 "c:\Users\USER\Desktop\PontoDigital_final\Views\Administrador\CadastrarAdministrador.cshtml"
  
    ViewData["Title"] = "Cadastrar administrador | Ponto Digital";
    ViewData["css"] = "faleconosco-style.css";

#line default
#line hidden
            BeginContext(123, 55, true);
            WriteLiteral("<main>\r\n    <h2>Cadastrar novo administrador</h2>\r\n    ");
            EndContext();
            BeginContext(178, 1344, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0edc6c3c9ef44dfe88e92e4566b859ae", async() => {
                BeginContext(261, 1254, true);
                WriteLiteral(@"
        <div class=""campo"">
            <input type=""text"" name=""nome"" placeholder=""Nome"" maxlength=""50"" required>
        </div>
        <div class=""campo"">
            <input type=""text"" name=""setor"" placeholder=""Setor"" maxlength=""20"" required>
        </div>
        <div class=""campo"">
            <input type=""text"" name=""telefone"" placeholder=""Número de telefone"" maxlength=""12"" required>
        </div>
        <div class=""campo"">
            <input type=""email"" name=""email"" maxlength=""50"" id=""email"" placeholder=""Email"" required>
        </div>
        <div class=""campo"">
            <input type=""text"" name=""endereco"" placeholder=""Seu Endereço"" maxlength=""70"" required>
        </div>
        <div class=""campo"">
            <input type=""date"" name=""data-nascimento"" placeholder=""Data de Nascimento"" required>
        </div>
        <div class=""campo"">
            <input type=""password"" name=""senha"" placeholder=""Nova Senha"" required minlength=""8"" maxlength=""40"">
        </div>
        <d");
                WriteLiteral("iv class=\"campo\">\r\n            <input type=\"password\" name=\"confirmarsenha\" placeholder=\"Confirmar Senha\" required minlength=\"8\" maxlength=\"40\">\r\n        </div>\r\n        <input type=\"submit\" value=\"Cadastrar\" class=\"submit\">\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
#line 7 "c:\Users\USER\Desktop\PontoDigital_final\Views\Administrador\CadastrarAdministrador.cshtml"
AddHtmlAttributeValue("", 192, Url.Action("CadastrarAdministrador","Administrador"), 192, 53, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1522, 9, true);
            WriteLiteral("\r\n</main>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
