#pragma checksum "C:\Users\rafae\projeto_chamada\Views\Sala\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5ca7b645e74ea4b2d9815296370d86b1396c03e7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Sala_Index), @"mvc.1.0.view", @"/Views/Sala/Index.cshtml")]
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
#line 1 "C:\Users\rafae\projeto_chamada\Views\_ViewImports.cshtml"
using ProjetoN2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\rafae\projeto_chamada\Views\_ViewImports.cshtml"
using ProjetoN2.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5ca7b645e74ea4b2d9815296370d86b1396c03e7", @"/Views/Sala/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1d6aa26658f4f225c49b9585c40585cc84aa51b3", @"/Views/_ViewImports.cshtml")]
    public class Views_Sala_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ProjetoN2.Models.SalaViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\rafae\projeto_chamada\Views\Sala\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""text-center"">
    <h3>Salas</h3>
    <a class=""btn btn-striped btn-outline-dark"" href=""/Sala/Create"">Adicionar</a>
    <br><br><br>

    <table class=""table table-striped table-bordered"">
        <thead class=""thead-dark"">
            <tr>
                <th>Id</th>
                <th>Capacidade</th>
                <th>Ações</th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 20 "C:\Users\rafae\projeto_chamada\Views\Sala\Index.cshtml"
             foreach (var sala in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 23 "C:\Users\rafae\projeto_chamada\Views\Sala\Index.cshtml"
                   Write(sala.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 24 "C:\Users\rafae\projeto_chamada\Views\Sala\Index.cshtml"
                   Write(sala.Capacidade);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 728, "\"", 759, 2);
            WriteAttributeValue("", 735, "/Sala/Update?id=", 735, 16, true);
#nullable restore
#line 26 "C:\Users\rafae\projeto_chamada\Views\Sala\Index.cshtml"
WriteAttributeValue("", 751, sala.Id, 751, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-warning\">Atualizar</a>\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 834, "\"", 865, 2);
            WriteAttributeValue("", 841, "/Sala/Delete?id=", 841, 16, true);
#nullable restore
#line 27 "C:\Users\rafae\projeto_chamada\Views\Sala\Index.cshtml"
WriteAttributeValue("", 857, sala.Id, 857, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-danger\">Delete</a>\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 30 "C:\Users\rafae\projeto_chamada\Views\Sala\Index.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ProjetoN2.Models.SalaViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
