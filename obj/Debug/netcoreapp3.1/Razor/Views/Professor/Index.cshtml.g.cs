#pragma checksum "C:\Users\losan\Desktop\Aulas\EC5\ProjetoN2\Views\Professor\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5b4c3d2ad75fd5788c9d86fe2a388fc8957911e2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Professor_Index), @"mvc.1.0.view", @"/Views/Professor/Index.cshtml")]
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
#line 1 "C:\Users\losan\Desktop\Aulas\EC5\ProjetoN2\Views\_ViewImports.cshtml"
using ProjetoN2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\losan\Desktop\Aulas\EC5\ProjetoN2\Views\_ViewImports.cshtml"
using ProjetoN2.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5b4c3d2ad75fd5788c9d86fe2a388fc8957911e2", @"/Views/Professor/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1d6aa26658f4f225c49b9585c40585cc84aa51b3", @"/Views/_ViewImports.cshtml")]
    public class Views_Professor_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ProjetoN2.Models.ProfessorViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\losan\Desktop\Aulas\EC5\ProjetoN2\Views\Professor\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""text-center"">
    <h3>Professores</h3>
    <a class=""btn btn-striped btn-outline-dark"" href=""/Professor/Create"">Adicionar</a>
    <br><br><br>

    <table class=""table table-striped table-bordered"">
        <thead class=""thead-dark"">
            <tr>
                <th>Id</th>
                <th>Nome</th>
                <th>Ações</th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 20 "C:\Users\losan\Desktop\Aulas\EC5\ProjetoN2\Views\Professor\Index.cshtml"
             foreach (var professor in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 23 "C:\Users\losan\Desktop\Aulas\EC5\ProjetoN2\Views\Professor\Index.cshtml"
                   Write(professor.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 24 "C:\Users\losan\Desktop\Aulas\EC5\ProjetoN2\Views\Professor\Index.cshtml"
                   Write(professor.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 747, "\"", 788, 2);
            WriteAttributeValue("", 754, "/Professor/Update?id=", 754, 21, true);
#nullable restore
#line 26 "C:\Users\losan\Desktop\Aulas\EC5\ProjetoN2\Views\Professor\Index.cshtml"
WriteAttributeValue("", 775, professor.Id, 775, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-warning\">Atualizar</a>\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 863, "\"", 904, 2);
            WriteAttributeValue("", 870, "/Professor/Delete?id=", 870, 21, true);
#nullable restore
#line 27 "C:\Users\losan\Desktop\Aulas\EC5\ProjetoN2\Views\Professor\Index.cshtml"
WriteAttributeValue("", 891, professor.Id, 891, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-danger\">Delete</a>\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 30 "C:\Users\losan\Desktop\Aulas\EC5\ProjetoN2\Views\Professor\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ProjetoN2.Models.ProfessorViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
