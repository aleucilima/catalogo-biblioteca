#pragma checksum "/home/ale/Área de Trabalho/www/catalogo-biblioteca/CatalogoBiblioteca.Web/Views/Home/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0dfc60aa0aa82b76474bb6691012cb200886bd92"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "/home/ale/Área de Trabalho/www/catalogo-biblioteca/CatalogoBiblioteca.Web/Views/_ViewImports.cshtml"
using CatalogoBiblioteca.Web;

#line default
#line hidden
#line 2 "/home/ale/Área de Trabalho/www/catalogo-biblioteca/CatalogoBiblioteca.Web/Views/_ViewImports.cshtml"
using CatalogoBiblioteca.Web.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0dfc60aa0aa82b76474bb6691012cb200886bd92", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ada2f5ea43528f3046e6b2fc617a767225d572af", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/home/ale/Área de Trabalho/www/catalogo-biblioteca/CatalogoBiblioteca.Web/Views/Home/Index.cshtml"
  
    ViewData["Title"] = "Início";

#line default
#line hidden
            BeginContext(42, 1292, true);
            WriteLiteral(@"
<section class=""hero"">
    <div class=""container"">
        <div class=""img__container-logo"">
            <img src=""https://ucienegam.mx/wp-content/uploads/2016/12/Bibioteca-800x400.jpg"" alt="""">
        </div>
    </div>
</section>

<div class=""container"">
    <h2 class=""titleEntity"">Catálogo da Biblioteca</h2>

    <div class=""cards"">
        <div class=""card"">
            <div class=""image-card"">
                <a href=""/Publisher""><img src=""https://img.icons8.com/fluency/96/000000/company.png""/></a>
            </div>
            <div class=""content-card"">
                <div>Editora</div>
            </div>
        </div>
         <div class=""card"">
            <div class=""image-card"">
                <a href=""/Author""><img src=""https://img.icons8.com/color/96/000000/edit-user-male--v1.png""/></a>
            </div>
            <div class=""content-card"">
                <div>Autores</div>
            </div>
        </div>
         <div class=""card"" >
            <div class=""");
            WriteLiteral(@"image-card"">
                 <a href=""/Book""><img src=""https://img.icons8.com/color/96/000000/book.png""/></a>
            </div>
            <div class=""content-card"">
                <div>Livros</div>
            </div>
        </div>

    </div>
</div>

");
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