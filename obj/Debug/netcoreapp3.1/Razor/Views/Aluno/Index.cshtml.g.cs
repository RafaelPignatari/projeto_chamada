#pragma checksum "C:\Users\losan\Desktop\Aulas\EC5\ProjetoN2\Views\Aluno\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d8225291d299ee4fa0880564763d3e8ba50f8b19"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Aluno_Index), @"mvc.1.0.view", @"/Views/Aluno/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d8225291d299ee4fa0880564763d3e8ba50f8b19", @"/Views/Aluno/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1d6aa26658f4f225c49b9585c40585cc84aa51b3", @"/Views/_ViewImports.cshtml")]
    public class Views_Aluno_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ProjetoN2.Models.AlunoViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\losan\Desktop\Aulas\EC5\ProjetoN2\Views\Aluno\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""text-center"">
    <h3>Alunos</h3>
    <a class=""btn btn-striped btn-outline-dark"" href=""/aluno/Create"">Adicionar</a>
    <br><br><br>

    <table class=""table table-striped table-bordered"">
        <thead class=""thead-dark"">
            <tr>
                <th>Id</th>
                <th>Nome</th>
                <th>Turma</th>
                <th>Ações</th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 21 "C:\Users\losan\Desktop\Aulas\EC5\ProjetoN2\Views\Aluno\Index.cshtml"
             foreach (var aluno in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 24 "C:\Users\losan\Desktop\Aulas\EC5\ProjetoN2\Views\Aluno\Index.cshtml"
                   Write(aluno.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 25 "C:\Users\losan\Desktop\Aulas\EC5\ProjetoN2\Views\Aluno\Index.cshtml"
                   Write(aluno.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 26 "C:\Users\losan\Desktop\Aulas\EC5\ProjetoN2\Views\Aluno\Index.cshtml"
                   Write(aluno.TurmaNome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 801, "\"", 834, 2);
            WriteAttributeValue("", 808, "/aluno/Update?id=", 808, 17, true);
#nullable restore
#line 28 "C:\Users\losan\Desktop\Aulas\EC5\ProjetoN2\Views\Aluno\Index.cshtml"
WriteAttributeValue("", 825, aluno.Id, 825, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-warning\">Atualizar</a>\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 909, "\"", 942, 2);
            WriteAttributeValue("", 916, "/aluno/Delete?id=", 916, 17, true);
#nullable restore
#line 29 "C:\Users\losan\Desktop\Aulas\EC5\ProjetoN2\Views\Aluno\Index.cshtml"
WriteAttributeValue("", 933, aluno.Id, 933, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-danger\">Delete</a>\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 32 "C:\Users\losan\Desktop\Aulas\EC5\ProjetoN2\Views\Aluno\Index.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ProjetoN2.Models.AlunoViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
