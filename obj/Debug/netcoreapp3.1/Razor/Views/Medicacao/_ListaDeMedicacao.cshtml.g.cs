#pragma checksum "C:\Users\Administrador\Documents\Hsf_Receituario\Views\Medicacao\_ListaDeMedicacao.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2785f08ae84f70cf00e00b0b01b4b12e80c92851"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Medicacao__ListaDeMedicacao), @"mvc.1.0.view", @"/Views/Medicacao/_ListaDeMedicacao.cshtml")]
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
#line 1 "C:\Users\Administrador\Documents\Hsf_Receituario\Views\_ViewImports.cshtml"
using Hsf_Receitas;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Administrador\Documents\Hsf_Receituario\Views\_ViewImports.cshtml"
using Hsf_Receitas.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Administrador\Documents\Hsf_Receituario\Views\Medicacao\_ListaDeMedicacao.cshtml"
using Hsf_Receitas.Services;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2785f08ae84f70cf00e00b0b01b4b12e80c92851", @"/Views/Medicacao/_ListaDeMedicacao.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"489f18548069da5d6cb12941c30987820b77cd47", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Medicacao__ListaDeMedicacao : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Medicacao>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\Administrador\Documents\Hsf_Receituario\Views\Medicacao\_ListaDeMedicacao.cshtml"
  
    ViewData["title"] = "Listagem de medicamentos";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 8 "C:\Users\Administrador\Documents\Hsf_Receituario\Views\Medicacao\_ListaDeMedicacao.cshtml"
 if (Model.Count() > 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <table class=""table table-responsive table-bordered table-sm table-striped
    table-light table-hover table-medicament"" id=""medic-list"">

        <thead class=""bg-primary text-light"">

            <tr>

                <th>Nome da Medicação</th>
                <th>Dosagem</th>
                <th>Tipo de Uso</th>

            </tr>

        </thead>

        <tbody>

");
#nullable restore
#line 27 "C:\Users\Administrador\Documents\Hsf_Receituario\Views\Medicacao\_ListaDeMedicacao.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n\r\n                    <td class=\"text-center\">");
#nullable restore
#line 31 "C:\Users\Administrador\Documents\Hsf_Receituario\Views\Medicacao\_ListaDeMedicacao.cshtml"
                                       Write(item.MedicationName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                    <td>");
#nullable restore
#line 33 "C:\Users\Administrador\Documents\Hsf_Receituario\Views\Medicacao\_ListaDeMedicacao.cshtml"
                   Write(item.MedicationDosage);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                    <td>");
#nullable restore
#line 35 "C:\Users\Administrador\Documents\Hsf_Receituario\Views\Medicacao\_ListaDeMedicacao.cshtml"
                   Write(item.MedicationMethodUse);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                </tr>\r\n");
#nullable restore
#line 38 "C:\Users\Administrador\Documents\Hsf_Receituario\Views\Medicacao\_ListaDeMedicacao.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </tbody>\r\n\r\n    </table>\r\n");
#nullable restore
#line 43 "C:\Users\Administrador\Documents\Hsf_Receituario\Views\Medicacao\_ListaDeMedicacao.cshtml"

}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"alert alert-warning w-100 alert-TA\" role=\"alert\">\r\n        Nenhuma medicação adicionada !\r\n    </div>\r\n");
#nullable restore
#line 50 "C:\Users\Administrador\Documents\Hsf_Receituario\Views\Medicacao\_ListaDeMedicacao.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Medicacao>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
