#pragma checksum "C:\Users\losan\Desktop\Aulas\EC5\ProjetoN2\Views\Professor\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "44f3e8822c2d398308d45cc299650f38684c5dcc"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"44f3e8822c2d398308d45cc299650f38684c5dcc", @"/Views/Professor/Index.cshtml")]
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

    <a class=""btn btn-striped btn-info"" href=""/Professor/Create"">Adicionar</a>
    <br>
    <table class=""table table-striped table-bordered table-responsive"">
        <thead class=""thead-dark"">
            <tr>
                <th>Id</th>
                <th>Nome</th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 18 "C:\Users\losan\Desktop\Aulas\EC5\ProjetoN2\Views\Professor\Index.cshtml"
             foreach (var professor in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 21 "C:\Users\losan\Desktop\Aulas\EC5\ProjetoN2\Views\Professor\Index.cshtml"
                   Write(professor.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 22 "C:\Users\losan\Desktop\Aulas\EC5\ProjetoN2\Views\Professor\Index.cshtml"
                   Write(professor.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n");
#nullable restore
#line 24 "C:\Users\losan\Desktop\Aulas\EC5\ProjetoN2\Views\Professor\Index.cshtml"
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
