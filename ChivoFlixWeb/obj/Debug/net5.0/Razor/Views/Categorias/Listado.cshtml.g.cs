#pragma checksum "D:\RepositoriosGit\parcial03\ChivoFlixWeb\ChivoFlixWeb\Views\Categorias\Listado.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "135adb4e4859cbd4386a692691ecc69df8f83f0e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Categorias_Listado), @"mvc.1.0.view", @"/Views/Categorias/Listado.cshtml")]
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
#nullable restore
#line 1 "D:\RepositoriosGit\parcial03\ChivoFlixWeb\ChivoFlixWeb\Views\_ViewImports.cshtml"
using ChivoFlixWeb;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\RepositoriosGit\parcial03\ChivoFlixWeb\ChivoFlixWeb\Views\_ViewImports.cshtml"
using ChivoFlixWeb.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"135adb4e4859cbd4386a692691ecc69df8f83f0e", @"/Views/Categorias/Listado.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ab73aeab4a3503764f8e91d3671704d572842161", @"/Views/_ViewImports.cshtml")]
    public class Views_Categorias_Listado : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<ChivoFlixWeb.Models.Generos>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Categorias/NuevaCategoria"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary col-md-2 card-text-center"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
#nullable restore
#line 2 "D:\RepositoriosGit\parcial03\ChivoFlixWeb\ChivoFlixWeb\Views\Categorias\Listado.cshtml"
  
    ViewBag.Title = "Categorias";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>Listado de Categorias</h2>\r\n<div class=\"row right\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "135adb4e4859cbd4386a692691ecc69df8f83f0e4889", async() => {
                WriteLiteral("Nueva Categoria");
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
            WriteLiteral(@"
</div>
<br />
<div class=""row"">
    <div class=""col-md-12"">
        <table class=""table"">
            <thead class=""thead-dark"">
                <tr>
                    <th>ID</th>
                    <th>Nombre</th>
                   
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 22 "D:\RepositoriosGit\parcial03\ChivoFlixWeb\ChivoFlixWeb\Views\Categorias\Listado.cshtml"
                 if (Model.Any())
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "D:\RepositoriosGit\parcial03\ChivoFlixWeb\ChivoFlixWeb\Views\Categorias\Listado.cshtml"
                     foreach (var item in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td>");
#nullable restore
#line 27 "D:\RepositoriosGit\parcial03\ChivoFlixWeb\ChivoFlixWeb\Views\Categorias\Listado.cshtml"
                           Write(item.IdGeneros);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 28 "D:\RepositoriosGit\parcial03\ChivoFlixWeb\ChivoFlixWeb\Views\Categorias\Listado.cshtml"
                           Write(item.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                           \r\n                            <td>\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "135adb4e4859cbd4386a692691ecc69df8f83f0e7603", async() => {
                WriteLiteral("<i class=\"bi bi-pencil-square\"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 936, "~///", 936, 4, true);
#nullable restore
#line 31 "D:\RepositoriosGit\parcial03\ChivoFlixWeb\ChivoFlixWeb\Views\Categorias\Listado.cshtml"
AddHtmlAttributeValue("", 940, item.IdGeneros, 940, 15, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "135adb4e4859cbd4386a692691ecc69df8f83f0e9349", async() => {
                WriteLiteral("<i class=\"bi bi-trash\"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1132, "~///", 1132, 4, true);
#nullable restore
#line 34 "D:\RepositoriosGit\parcial03\ChivoFlixWeb\ChivoFlixWeb\Views\Categorias\Listado.cshtml"
AddHtmlAttributeValue("", 1136, item.IdGeneros, 1136, 15, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            </td>\r\n                        </tr>\r\n");
#nullable restore
#line 37 "D:\RepositoriosGit\parcial03\ChivoFlixWeb\ChivoFlixWeb\Views\Categorias\Listado.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 37 "D:\RepositoriosGit\parcial03\ChivoFlixWeb\ChivoFlixWeb\Views\Categorias\Listado.cshtml"
                     
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <th scope=\"row\">No hay registros</th>\r\n                    </tr>\r\n");
#nullable restore
#line 44 "D:\RepositoriosGit\parcial03\ChivoFlixWeb\ChivoFlixWeb\Views\Categorias\Listado.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n\r\n        </table>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<ChivoFlixWeb.Models.Generos>> Html { get; private set; }
    }
}
#pragma warning restore 1591