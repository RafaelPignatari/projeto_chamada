#pragma checksum "C:\Users\losan\Desktop\Aulas\EC5\ProjetoN2\Views\Aula\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "220cab5e1a913b90a9c679e78718e3e478c67dcd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Aula_Index), @"mvc.1.0.view", @"/Views/Aula/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"220cab5e1a913b90a9c679e78718e3e478c67dcd", @"/Views/Aula/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1d6aa26658f4f225c49b9585c40585cc84aa51b3", @"/Views/_ViewImports.cshtml")]
    public class Views_Aula_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ProjetoN2.Models.AulaViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\losan\Desktop\Aulas\EC5\ProjetoN2\Views\Aula\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""text-center"">
    <h3>Aulas</h3>
    <a class=""btn btn-striped btn-outline-dark"" href=""/aula/Create"">Adicionar</a>
    <br><br><br>

    <table class=""table table-striped table-bordered"">
        <thead class=""thead-dark"">
            <tr>
                <th>Id</th>
                <th>Turma</th>
                <th>Materia</th>
                <th>Sala Nº</th>
                <th>Data</th>
                <th>Ações</th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 23 "C:\Users\losan\Desktop\Aulas\EC5\ProjetoN2\Views\Aula\Index.cshtml"
             foreach (var aula in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 26 "C:\Users\losan\Desktop\Aulas\EC5\ProjetoN2\Views\Aula\Index.cshtml"
                   Write(aula.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 27 "C:\Users\losan\Desktop\Aulas\EC5\ProjetoN2\Views\Aula\Index.cshtml"
                   Write(aula.TurmaNome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 28 "C:\Users\losan\Desktop\Aulas\EC5\ProjetoN2\Views\Aula\Index.cshtml"
                   Write(aula.MateriaNome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 29 "C:\Users\losan\Desktop\Aulas\EC5\ProjetoN2\Views\Aula\Index.cshtml"
                   Write(aula.SalaId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 30 "C:\Users\losan\Desktop\Aulas\EC5\ProjetoN2\Views\Aula\Index.cshtml"
                   Write(aula.Data.ToString("d"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 967, "\"", 998, 2);
            WriteAttributeValue("", 974, "/aula/Update?id=", 974, 16, true);
#nullable restore
#line 32 "C:\Users\losan\Desktop\Aulas\EC5\ProjetoN2\Views\Aula\Index.cshtml"
WriteAttributeValue("", 990, aula.Id, 990, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-warning\">Atualizar</a>\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 1073, "\"", 1104, 2);
            WriteAttributeValue("", 1080, "/aula/Delete?id=", 1080, 16, true);
#nullable restore
#line 33 "C:\Users\losan\Desktop\Aulas\EC5\ProjetoN2\Views\Aula\Index.cshtml"
WriteAttributeValue("", 1096, aula.Id, 1096, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-danger\">Delete</a>\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 36 "C:\Users\losan\Desktop\Aulas\EC5\ProjetoN2\Views\Aula\Index.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ProjetoN2.Models.AulaViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
