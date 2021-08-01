#pragma checksum "/home/ale/Área de Trabalho/www/catalogo-biblioteca/CatalogoBiblioteca.Web/Views/Author/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f636161c45c63a76c51b21a605b9898608e13eee"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Author_Index), @"mvc.1.0.view", @"/Views/Author/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Author/Index.cshtml", typeof(AspNetCore.Views_Author_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f636161c45c63a76c51b21a605b9898608e13eee", @"/Views/Author/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ada2f5ea43528f3046e6b2fc617a767225d572af", @"/Views/_ViewImports.cshtml")]
    public class Views_Author_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<CatalogoBiblioteca.Domain.Entities.Author>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(63, 598, true);
            WriteLiteral(@"
<h2 class=""titleEntity"">Autores Cadastrados</h2>
<div class=""row"">
    <div class=""col-md-8 col-md-offset-2 centraliza"">
        <a href=""/Author/Save"" class=""btn btn-primary"">Novo Autor</a>
    </div>
</div>

<div class=""row"">
    <div class=""col-md-8 col-md-offset-2 centraliza"">
        <table class=""table table-hover mx-auto"">
            <thead>
                <tr>
                    <th>Nome</th>
                    <th>CPF</th>
                    <th>Telefone</th>
                    <th>E-mail</th>
                </tr>
            </thead>
            <tbody>
");
            EndContext();
#line 22 "/home/ale/Área de Trabalho/www/catalogo-biblioteca/CatalogoBiblioteca.Web/Views/Author/Index.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
            BeginContext(726, 54, true);
            WriteLiteral("                    <tr>\r\n                        <td>");
            EndContext();
            BeginContext(781, 9, false);
#line 25 "/home/ale/Área de Trabalho/www/catalogo-biblioteca/CatalogoBiblioteca.Web/Views/Author/Index.cshtml"
                       Write(item.Name);

#line default
#line hidden
            EndContext();
            BeginContext(790, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(826, 8, false);
#line 26 "/home/ale/Área de Trabalho/www/catalogo-biblioteca/CatalogoBiblioteca.Web/Views/Author/Index.cshtml"
                       Write(item.CPF);

#line default
#line hidden
            EndContext();
            BeginContext(834, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(870, 10, false);
#line 27 "/home/ale/Área de Trabalho/www/catalogo-biblioteca/CatalogoBiblioteca.Web/Views/Author/Index.cshtml"
                       Write(item.Phone);

#line default
#line hidden
            EndContext();
            BeginContext(880, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(916, 10, false);
#line 28 "/home/ale/Área de Trabalho/www/catalogo-biblioteca/CatalogoBiblioteca.Web/Views/Author/Index.cshtml"
                       Write(item.Email);

#line default
#line hidden
            EndContext();
            BeginContext(926, 67, true);
            WriteLiteral("</td>\r\n                        <td>\r\n                            <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 993, "\"", 1021, 2);
            WriteAttributeValue("", 1000, "/Author/Edit/", 1000, 13, true);
#line 30 "/home/ale/Área de Trabalho/www/catalogo-biblioteca/CatalogoBiblioteca.Web/Views/Author/Index.cshtml"
WriteAttributeValue("", 1013, item.Id, 1013, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1022, 126, true);
            WriteLiteral(" class=\"btn btn-info\">Editar</a>\r\n                        </td>\r\n                         <td>\r\n                            <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1148, "\"", 1178, 2);
            WriteAttributeValue("", 1155, "/Author/Delete/", 1155, 15, true);
#line 33 "/home/ale/Área de Trabalho/www/catalogo-biblioteca/CatalogoBiblioteca.Web/Views/Author/Index.cshtml"
WriteAttributeValue("", 1170, item.Id, 1170, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1179, 95, true);
            WriteLiteral(" class=\"btn btn-danger\">Deletar</a>\r\n                        </td>\r\n                    </tr>\r\n");
            EndContext();
#line 36 "/home/ale/Área de Trabalho/www/catalogo-biblioteca/CatalogoBiblioteca.Web/Views/Author/Index.cshtml"
                }

#line default
#line hidden
            BeginContext(1293, 58, true);
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<CatalogoBiblioteca.Domain.Entities.Author>> Html { get; private set; }
    }
}
#pragma warning restore 1591
