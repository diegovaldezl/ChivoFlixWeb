#pragma checksum "C:\Users\Diego\Documents\gitRepos\ChivoFlixWeb\ChivoFlixWeb\Views\Categorias\EditarCategoria.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "041fbfe7b6e6ee6d5db0fee2236730fd153f3368"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Categorias_EditarCategoria), @"mvc.1.0.view", @"/Views/Categorias/EditarCategoria.cshtml")]
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
#line 1 "C:\Users\Diego\Documents\gitRepos\ChivoFlixWeb\ChivoFlixWeb\Views\_ViewImports.cshtml"
using ChivoFlixWeb;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Diego\Documents\gitRepos\ChivoFlixWeb\ChivoFlixWeb\Views\_ViewImports.cshtml"
using ChivoFlixWeb.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"041fbfe7b6e6ee6d5db0fee2236730fd153f3368", @"/Views/Categorias/EditarCategoria.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ab73aeab4a3503764f8e91d3671704d572842161", @"/Views/_ViewImports.cshtml")]
    public class Views_Categorias_EditarCategoria : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ChivoFlixWeb.Models.ViewModels.GenerosVM>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Diego\Documents\gitRepos\ChivoFlixWeb\ChivoFlixWeb\Views\Categorias\EditarCategoria.cshtml"
  
    ViewBag.Title = "Editar Categoria";
    List<SelectListItem> items = (List<SelectListItem>)ViewBag.items;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>Editar Categoria</h2>\r\n\r\n");
#nullable restore
#line 9 "C:\Users\Diego\Documents\gitRepos\ChivoFlixWeb\ChivoFlixWeb\Views\Categorias\EditarCategoria.cshtml"
 using (Html.BeginForm("EditarCategoria", "Categorias", FormMethod.Post))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"row\">\r\n        <div class=\"col-md-12\">\r\n            <div>\r\n                ");
#nullable restore
#line 14 "C:\Users\Diego\Documents\gitRepos\ChivoFlixWeb\ChivoFlixWeb\Views\Categorias\EditarCategoria.cshtml"
           Write(Html.LabelFor(d => d.IdGeneros));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 15 "C:\Users\Diego\Documents\gitRepos\ChivoFlixWeb\ChivoFlixWeb\Views\Categorias\EditarCategoria.cshtml"
           Write(Html.TextBoxFor(d => d.IdGeneros, "", new { @class = "form-control", @readonly = "readonly" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n            <div>\r\n                ");
#nullable restore
#line 18 "C:\Users\Diego\Documents\gitRepos\ChivoFlixWeb\ChivoFlixWeb\Views\Categorias\EditarCategoria.cshtml"
           Write(Html.LabelFor(d => d.Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 19 "C:\Users\Diego\Documents\gitRepos\ChivoFlixWeb\ChivoFlixWeb\Views\Categorias\EditarCategoria.cshtml"
           Write(Html.TextBoxFor(d => d.Nombre, "", new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 20 "C:\Users\Diego\Documents\gitRepos\ChivoFlixWeb\ChivoFlixWeb\Views\Categorias\EditarCategoria.cshtml"
           Write(Html.ValidationMessageFor(d => d.Nombre, null, new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
            </div>
           
            <br />
            <div class=""row"">
                <div class=""col-md-6"">
                </div>
                <div class=""col-md-6"">
                    <input value=""Guardar"" class=""btn btn-primary"" type=""submit"" />

                    <a href=""/Peliculas/Listado"" class=""btn btn-success"">Regresar</a>
                </div>
            </div>
        </div>
    </div>
");
#nullable restore
#line 35 "C:\Users\Diego\Documents\gitRepos\ChivoFlixWeb\ChivoFlixWeb\Views\Categorias\EditarCategoria.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ChivoFlixWeb.Models.ViewModels.GenerosVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
