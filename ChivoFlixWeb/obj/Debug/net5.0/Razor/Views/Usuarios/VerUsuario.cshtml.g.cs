#pragma checksum "D:\Daniel\Flutter Proyectos\repositorio\ChivoFlixWeb\ChivoFlixWeb\Views\Usuarios\VerUsuario.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "123067175b9e981aaaacccc848c90388d547aaff"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Usuarios_VerUsuario), @"mvc.1.0.view", @"/Views/Usuarios/VerUsuario.cshtml")]
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
#line 1 "D:\Daniel\Flutter Proyectos\repositorio\ChivoFlixWeb\ChivoFlixWeb\Views\_ViewImports.cshtml"
using ChivoFlixWeb;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Daniel\Flutter Proyectos\repositorio\ChivoFlixWeb\ChivoFlixWeb\Views\_ViewImports.cshtml"
using ChivoFlixWeb.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"123067175b9e981aaaacccc848c90388d547aaff", @"/Views/Usuarios/VerUsuario.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ab73aeab4a3503764f8e91d3671704d572842161", @"/Views/_ViewImports.cshtml")]
    public class Views_Usuarios_VerUsuario : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ChivoFlixWeb.Models.ViewModels.UsuarioVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Usuarios/Listado"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "D:\Daniel\Flutter Proyectos\repositorio\ChivoFlixWeb\ChivoFlixWeb\Views\Usuarios\VerUsuario.cshtml"
  
    ViewBag.Title = "Editar Usuario";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>Ver usuario ");
#nullable restore
#line 6 "D:\Daniel\Flutter Proyectos\repositorio\ChivoFlixWeb\ChivoFlixWeb\Views\Usuarios\VerUsuario.cshtml"
           Write(Html.LabelFor(d => d.Username));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n\r\n");
#nullable restore
#line 8 "D:\Daniel\Flutter Proyectos\repositorio\ChivoFlixWeb\ChivoFlixWeb\Views\Usuarios\VerUsuario.cshtml"
 using (Html.BeginForm("EditarUsuario", "Usuarios", FormMethod.Post))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"row\">\r\n        <div class=\"col-md-12\">\r\n            ");
#nullable restore
#line 12 "D:\Daniel\Flutter Proyectos\repositorio\ChivoFlixWeb\ChivoFlixWeb\Views\Usuarios\VerUsuario.cshtml"
       Write(Html.LabelFor(d => d.IdUsuarios));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 13 "D:\Daniel\Flutter Proyectos\repositorio\ChivoFlixWeb\ChivoFlixWeb\Views\Usuarios\VerUsuario.cshtml"
       Write(Html.TextBoxFor(d => d.IdUsuarios, "", new { @class = "form-control", @readonly = "readonly" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <div>\r\n                ");
#nullable restore
#line 15 "D:\Daniel\Flutter Proyectos\repositorio\ChivoFlixWeb\ChivoFlixWeb\Views\Usuarios\VerUsuario.cshtml"
           Write(Html.LabelFor(d => d.Username));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 16 "D:\Daniel\Flutter Proyectos\repositorio\ChivoFlixWeb\ChivoFlixWeb\Views\Usuarios\VerUsuario.cshtml"
           Write(Html.TextBoxFor(d => d.Username, "", new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 17 "D:\Daniel\Flutter Proyectos\repositorio\ChivoFlixWeb\ChivoFlixWeb\Views\Usuarios\VerUsuario.cshtml"
           Write(Html.ValidationMessageFor(d => d.Username, null, new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n            <div>\r\n                ");
#nullable restore
#line 20 "D:\Daniel\Flutter Proyectos\repositorio\ChivoFlixWeb\ChivoFlixWeb\Views\Usuarios\VerUsuario.cshtml"
           Write(Html.LabelFor(d => d.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 21 "D:\Daniel\Flutter Proyectos\repositorio\ChivoFlixWeb\ChivoFlixWeb\Views\Usuarios\VerUsuario.cshtml"
           Write(Html.TextBoxFor(d => d.Email, "", new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 22 "D:\Daniel\Flutter Proyectos\repositorio\ChivoFlixWeb\ChivoFlixWeb\Views\Usuarios\VerUsuario.cshtml"
           Write(Html.ValidationMessageFor(d => d.Email, null, new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n            <div>\r\n                ");
#nullable restore
#line 25 "D:\Daniel\Flutter Proyectos\repositorio\ChivoFlixWeb\ChivoFlixWeb\Views\Usuarios\VerUsuario.cshtml"
           Write(Html.LabelFor(d => d.Password));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 26 "D:\Daniel\Flutter Proyectos\repositorio\ChivoFlixWeb\ChivoFlixWeb\Views\Usuarios\VerUsuario.cshtml"
           Write(Html.TextBoxFor(d => d.Password, "", new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 27 "D:\Daniel\Flutter Proyectos\repositorio\ChivoFlixWeb\ChivoFlixWeb\Views\Usuarios\VerUsuario.cshtml"
           Write(Html.ValidationMessageFor(d => d.Password, null, new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n            <div>\r\n                ");
#nullable restore
#line 30 "D:\Daniel\Flutter Proyectos\repositorio\ChivoFlixWeb\ChivoFlixWeb\Views\Usuarios\VerUsuario.cshtml"
           Write(Html.LabelFor(d => d.ConfirmPassword));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 31 "D:\Daniel\Flutter Proyectos\repositorio\ChivoFlixWeb\ChivoFlixWeb\Views\Usuarios\VerUsuario.cshtml"
           Write(Html.TextBoxFor(d => d.ConfirmPassword, "", new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 32 "D:\Daniel\Flutter Proyectos\repositorio\ChivoFlixWeb\ChivoFlixWeb\Views\Usuarios\VerUsuario.cshtml"
           Write(Html.ValidationMessageFor(d => d.ConfirmPassword, null, new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n            <div>\r\n                ");
#nullable restore
#line 35 "D:\Daniel\Flutter Proyectos\repositorio\ChivoFlixWeb\ChivoFlixWeb\Views\Usuarios\VerUsuario.cshtml"
           Write(Html.LabelFor(d => d.Imagen));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 36 "D:\Daniel\Flutter Proyectos\repositorio\ChivoFlixWeb\ChivoFlixWeb\Views\Usuarios\VerUsuario.cshtml"
           Write(Html.TextBoxFor(d => d.Imagen, "", new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 37 "D:\Daniel\Flutter Proyectos\repositorio\ChivoFlixWeb\ChivoFlixWeb\Views\Usuarios\VerUsuario.cshtml"
           Write(Html.ValidationMessageFor(d => d.Imagen, null, new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n            <br />\r\n            <div class=\"col-md-1\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "123067175b9e981aaaacccc848c90388d547aaff10366", async() => {
                WriteLiteral("Regresar");
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
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 45 "D:\Daniel\Flutter Proyectos\repositorio\ChivoFlixWeb\ChivoFlixWeb\Views\Usuarios\VerUsuario.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ChivoFlixWeb.Models.ViewModels.UsuarioVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
