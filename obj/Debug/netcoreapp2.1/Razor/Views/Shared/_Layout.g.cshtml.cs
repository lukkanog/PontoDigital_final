#pragma checksum "C:\Users\46735197879\Desktop\PontoDigital_final\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "22523f768e53f95c70ce5447037f8142c85f84a6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Layout), @"mvc.1.0.view", @"/Views/Shared/_Layout.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_Layout.cshtml", typeof(AspNetCore.Views_Shared__Layout))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"22523f768e53f95c70ce5447037f8142c85f84a6", @"/Views/Shared/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"03e2adbe3d9845469481b41f01920e08f481df38", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/style.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("icon"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/logo_semletras.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/logo_semletras.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Logo do software Ponto Digital"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("title", new global::Microsoft.AspNetCore.Html.HtmlString("Ponto Digital"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/menu.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Menu"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/facebook.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Ícone do Facebook"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/location.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_12 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Ícone de indicação de localização"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_13 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/telefone.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_14 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Ícone de um telefone"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\46735197879\Desktop\PontoDigital_final\Views\Shared\_Layout.cshtml"
  
    var user = (string)ViewBag.User;
    var admin = (string)ViewBag.Admin;

#line default
#line hidden
            BeginContext(81, 37, true);
            WriteLiteral("<!DOCTYPE html>\n<html lang=\"pt-br\">\n\n");
            EndContext();
            BeginContext(118, 925, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d75e58843c0e4d3aae1cc872419478ab", async() => {
                BeginContext(124, 114, true);
                WriteLiteral("\n    <meta charset=\"UTF-8\">\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\">\n    <title>");
                EndContext();
                BeginContext(239, 17, false);
#line 11 "C:\Users\46735197879\Desktop\PontoDigital_final\Views\Shared\_Layout.cshtml"
      Write(ViewData["Title"]);

#line default
#line hidden
                EndContext();
                BeginContext(256, 13, true);
                WriteLiteral("</title>\n    ");
                EndContext();
                BeginContext(269, 46, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "de8670044931489781422613cba0bb2f", async() => {
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
                BeginContext(315, 1, true);
                WriteLiteral("\n");
                EndContext();
#line 13 "C:\Users\46735197879\Desktop\PontoDigital_final\Views\Shared\_Layout.cshtml"
     if (!ViewData["Title"].Equals("Ponto Digital"))
    {

#line default
#line hidden
                BeginContext(375, 8, true);
                WriteLiteral("        ");
                EndContext();
                BeginContext(383, 53, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "c2f340e5a17846f3b519076e3842ac29", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
                AddHtmlAttributeValue("", 412, "~/css/", 412, 6, true);
#line 15 "C:\Users\46735197879\Desktop\PontoDigital_final\Views\Shared\_Layout.cshtml"
AddHtmlAttributeValue("", 418, ViewData["css"], 418, 16, false);

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
                BeginContext(436, 1, true);
                WriteLiteral("\n");
                EndContext();
#line 16 "C:\Users\46735197879\Desktop\PontoDigital_final\Views\Shared\_Layout.cshtml"
        
    }

#line default
#line hidden
                BeginContext(452, 250, true);
                WriteLiteral("    <link href=\"https://fonts.googleapis.com/css?family=Comfortaa\" rel=\"stylesheet\">\n    <link href=\"https://fonts.googleapis.com/css?family=Varela+Round\" rel=\"stylesheet\">\n    <!-- <link rel=\"stylesheet\" href=\"~/fonts/sui-generis-free.ttf\"> -->\n    ");
                EndContext();
                BeginContext(702, 49, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "194f47831b784230b3d4371e480297c7", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(751, 285, true);
                WriteLiteral(@"

    <script src=""https://ajax.googleapis.com/ajax/libs/jquery/3.3.1/jquery.min.js""></script>
    <script>
        $(document).ready(function () {
            $(""#btn_menu"").click(function () {
                $("".menu"").slideToggle(""fast"");
            });
        });
    </script>
");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1043, 2, true);
            WriteLiteral("\n\n");
            EndContext();
            BeginContext(1045, 4445, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6db72b9036664eedb4cb6d624714219c", async() => {
                BeginContext(1051, 86, true);
                WriteLiteral("\n    <header class=\'topo container\'>\n        <div class=\'topo content\'>\n            <a");
                EndContext();
                BeginWriteAttribute("href", " href=\'", 1137, "\'", 1171, 1);
#line 36 "C:\Users\46735197879\Desktop\PontoDigital_final\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 1144, Url.Action("Index","Home"), 1144, 27, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1172, 31, true);
                WriteLiteral(" class=\"logo\">\n                ");
                EndContext();
                BeginContext(1203, 95, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "a8d6ebd6f5d844c680076858a50f4d9a", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1298, 109, true);
                WriteLiteral("\n                <h1>Ponto Digital</h1>\n            </a>\n            <nav class=\'menu\'>\n                <ul>\n");
                EndContext();
#line 42 "C:\Users\46735197879\Desktop\PontoDigital_final\Views\Shared\_Layout.cshtml"
                     if(string.IsNullOrEmpty(admin))
                    {

#line default
#line hidden
                BeginContext(1482, 30, true);
                WriteLiteral("                        <li><a");
                EndContext();
                BeginWriteAttribute("href", " href=\'", 1512, "\'", 1547, 1);
#line 44 "C:\Users\46735197879\Desktop\PontoDigital_final\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 1519, Url.Action("Planos","Home"), 1519, 28, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1548, 62, true);
                WriteLiteral(">Conheça nossos planos</a></li>\n                        <li><a");
                EndContext();
                BeginWriteAttribute("href", " href=\'", 1610, "\'", 1651, 1);
#line 45 "C:\Users\46735197879\Desktop\PontoDigital_final\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 1617, Url.Action("ComoFunciona","Home"), 1617, 34, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1652, 55, true);
                WriteLiteral(">Como funciona?</a></li>\n                        <li><a");
                EndContext();
                BeginWriteAttribute("href", " href=\'", 1707, "\'", 1752, 1);
#line 46 "C:\Users\46735197879\Desktop\PontoDigital_final\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 1714, Url.Action("Avaliacoes","Comentario"), 1714, 38, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1753, 51, true);
                WriteLiteral(">Avaliações</a></li>\n                        <li><a");
                EndContext();
                BeginWriteAttribute("href", " href=\'", 1804, "\'", 1842, 1);
#line 47 "C:\Users\46735197879\Desktop\PontoDigital_final\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 1811, Url.Action("QuemSomos","Home"), 1811, 31, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1843, 51, true);
                WriteLiteral(">Quem Somos</a></li>\n                        <li><a");
                EndContext();
                BeginWriteAttribute("href", " href=\'", 1894, "\'", 1930, 1);
#line 48 "C:\Users\46735197879\Desktop\PontoDigital_final\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 1901, Url.Action("Contato","Home"), 1901, 29, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1931, 48, true);
                WriteLiteral(">Contato</a></li>\n                        <li><a");
                EndContext();
                BeginWriteAttribute("href", " href=\'", 1979, "\'", 2011, 1);
#line 49 "C:\Users\46735197879\Desktop\PontoDigital_final\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 1986, Url.Action("Faq","Home"), 1986, 25, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2012, 14, true);
                WriteLiteral(">FAQ</a></li>\n");
                EndContext();
#line 51 "C:\Users\46735197879\Desktop\PontoDigital_final\Views\Shared\_Layout.cshtml"
                         if (!string.IsNullOrEmpty(user))
                        {

#line default
#line hidden
                BeginContext(2131, 34, true);
                WriteLiteral("                            <li><a");
                EndContext();
                BeginWriteAttribute("href", " href=\'", 2165, "\'", 2219, 1);
#line 53 "C:\Users\46735197879\Desktop\PontoDigital_final\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 2172, Url.Action("CadastrarComentario","Comentario"), 2172, 47, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2220, 57, true);
                WriteLiteral(">Avalie - nos</a></li>\n                            <li><a");
                EndContext();
                BeginWriteAttribute("href", " href=\'", 2277, "\'", 2321, 1);
#line 54 "C:\Users\46735197879\Desktop\PontoDigital_final\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 2284, Url.Action("ExibirPerfil","Usuario"), 2284, 37, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2322, 13, true);
                WriteLiteral(" id=\"perfil\">");
                EndContext();
                BeginContext(2336, 74, false);
#line 54 "C:\Users\46735197879\Desktop\PontoDigital_final\Views\Shared\_Layout.cshtml"
                                                                                       Write(System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(user));

#line default
#line hidden
                EndContext();
                BeginContext(2410, 44, true);
                WriteLiteral("</a></li>\n                            <li><a");
                EndContext();
                BeginWriteAttribute("href", " href=\'", 2454, "\'", 2497, 1);
#line 55 "C:\Users\46735197879\Desktop\PontoDigital_final\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 2461, Url.Action("FazerLogout","Usuario"), 2461, 36, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2498, 26, true);
                WriteLiteral(" id=\"login\">Sair</a></li>\n");
                EndContext();
#line 56 "C:\Users\46735197879\Desktop\PontoDigital_final\Views\Shared\_Layout.cshtml"
                        }else
                        {

#line default
#line hidden
                BeginContext(2580, 46, true);
                WriteLiteral("                            <!-- <li><a href=\'");
                EndContext();
                BeginContext(2627, 29, false);
#line 58 "C:\Users\46735197879\Desktop\PontoDigital_final\Views\Shared\_Layout.cshtml"
                                         Write(Url.Action("Index","Usuario"));

#line default
#line hidden
                EndContext();
                BeginContext(2656, 56, true);
                WriteLiteral("\'>Cadastre-se</a> -->\n                            <li><a");
                EndContext();
                BeginWriteAttribute("href", " href=\'", 2712, "\'", 2749, 1);
#line 59 "C:\Users\46735197879\Desktop\PontoDigital_final\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 2719, Url.Action("Login","Usuario"), 2719, 30, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2750, 27, true);
                WriteLiteral(" id=\"login\">Login</a></li>\n");
                EndContext();
#line 60 "C:\Users\46735197879\Desktop\PontoDigital_final\Views\Shared\_Layout.cshtml"
                        }

#line default
#line hidden
#line 60 "C:\Users\46735197879\Desktop\PontoDigital_final\Views\Shared\_Layout.cshtml"
                         
                    } else
                    {

#line default
#line hidden
                BeginContext(2852, 30, true);
                WriteLiteral("                        <li><a");
                EndContext();
                BeginWriteAttribute("href", " href=\'", 2882, "\'", 2925, 1);
#line 63 "C:\Users\46735197879\Desktop\PontoDigital_final\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 2889, Url.Action("Index","Administrador"), 2889, 36, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2926, 57, true);
                WriteLiteral("><b>Dashboard</b></a></li>\n                        <li><a");
                EndContext();
                BeginWriteAttribute("href", " href=\'", 2983, "\'", 3039, 1);
#line 64 "C:\Users\46735197879\Desktop\PontoDigital_final\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 2990, Url.Action("AprovarComentarios","Administrador"), 2990, 49, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3040, 62, true);
                WriteLiteral(">Gerenciar comentários</a></li>\n                        <li><a");
                EndContext();
                BeginWriteAttribute("href", " href=\'", 3102, "\'", 3162, 1);
#line 65 "C:\Users\46735197879\Desktop\PontoDigital_final\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 3109, Url.Action("CadastrarAdministrador","Administrador"), 3109, 53, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3163, 64, true);
                WriteLiteral(">Cadastrar administrador</a></li>\n                        <li><a");
                EndContext();
                BeginWriteAttribute("href", " href=\'", 3227, "\'", 3279, 1);
#line 66 "C:\Users\46735197879\Desktop\PontoDigital_final\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 3234, Url.Action("ExibirUsuarios","Administrador"), 3234, 45, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3280, 62, true);
                WriteLiteral(">Ver lista de usuários</a></li>\n                        <li><a");
                EndContext();
                BeginWriteAttribute("href", " href=\'", 3342, "\'", 3391, 1);
#line 67 "C:\Users\46735197879\Desktop\PontoDigital_final\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 3349, Url.Action("FazerLogout","Administrador"), 3349, 42, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3392, 26, true);
                WriteLiteral(" id=\"login\">Sair</a></li>\n");
                EndContext();
#line 68 "C:\Users\46735197879\Desktop\PontoDigital_final\Views\Shared\_Layout.cshtml"
                    }

#line default
#line hidden
                BeginContext(3440, 96, true);
                WriteLiteral("                    \n                </ul>\n            </nav>\n            <button id=\"btn_menu\">");
                EndContext();
                BeginContext(3536, 37, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "6cc1279f68304e6a940f8416f9475f35", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3573, 44, true);
                WriteLiteral("</button>\n        </div>\n    </header>\n\n    ");
                EndContext();
                BeginContext(3618, 12, false);
#line 76 "C:\Users\46735197879\Desktop\PontoDigital_final\Views\Shared\_Layout.cshtml"
Write(RenderBody());

#line default
#line hidden
                EndContext();
                BeginContext(3630, 238, true);
                WriteLiteral("\n\n    <footer class=\'container\'>\n        <div class=\"content\">\n            <h3>Agora Vai - Ponto Digital</h3>\n            <div class=\"footer_flex\">\n                <address>\n                    <div id=\"facebook\">\n                        ");
                EndContext();
                BeginContext(3868, 54, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "22f3bfdad83e40febef101943a669355", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3922, 127, true);
                WriteLiteral("\n                        <p>/pontodigital.com</p>\n                    </div>\n                    <div>\n                        ");
                EndContext();
                BeginContext(4049, 70, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "2455bf3c2e034573a5afab27f99d3ca7", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_11);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_12);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(4119, 163, true);
                WriteLiteral("\n                        Av. Paulista, 999 - Bela Vista, São Paulo - SP\n                    </div>\n                    <div id=\"telefone\">\n                        ");
                EndContext();
                BeginContext(4282, 57, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "61554921fce346f0ae191099aeb7c2fb", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_13);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_14);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(4339, 145, true);
                WriteLiteral("\n                        +55 11 9999 9999\n                    </div>\n                </address>\n            </div>\n        </div>\n    </footer>\n\n");
                EndContext();
#line 100 "C:\Users\46735197879\Desktop\PontoDigital_final\Views\Shared\_Layout.cshtml"
     if (@ViewData["Title"].Equals("Perguntas frequentes | Ponto Digital"))
    {

#line default
#line hidden
                BeginContext(4566, 911, true);
                WriteLiteral(@"        <script>
            function btn1()
            {
                $(""#p1"").slideToggle();
            }
            function btn2()
            {
                $(""#p2"").slideToggle();
            }
            function btn3()
            {
                $(""#p3"").slideToggle();
            }
            function btn4()
            {
                $(""#p4"").slideToggle();
            }
            function btn5()
            {
                $(""#p5"").slideToggle();
            }
            function btn6()
            {
                $(""#p6"").slideToggle();
            }
            function btn7()
            {
                $(""#p7"").slideToggle();
            }
            function btn8()
            {
                $(""#p8"").slideToggle();
            }
            function btn9()
            {
                $(""#p9"").slideToggle();
            }
        </script>            
");
                EndContext();
#line 140 "C:\Users\46735197879\Desktop\PontoDigital_final\Views\Shared\_Layout.cshtml"
    }

#line default
#line hidden
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
