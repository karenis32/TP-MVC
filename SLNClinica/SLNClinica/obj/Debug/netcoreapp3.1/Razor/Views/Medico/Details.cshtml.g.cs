#pragma checksum "C:\Users\Dudu\Desktop\Accenture Bootcamp\Curso 05\TP MVC\SLNClinica\SLNClinica\Views\Medico\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1c9d603695667f4947f1571a1904583fc95dc037"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Medico_Details), @"mvc.1.0.view", @"/Views/Medico/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1c9d603695667f4947f1571a1904583fc95dc037", @"/Views/Medico/Details.cshtml")]
    #nullable restore
    public class Views_Medico_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SLNClinica.Models.Medico>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Dudu\Desktop\Accenture Bootcamp\Curso 05\TP MVC\SLNClinica\SLNClinica\Views\Medico\Details.cshtml"
  
    ViewData["Title"] = "Detail";

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h2>");
#nullable restore
#line 6 "C:\Users\Dudu\Desktop\Accenture Bootcamp\Curso 05\TP MVC\SLNClinica\SLNClinica\Views\Medico\Details.cshtml"
   Write(Html.DisplayFor(modelItem=>modelItem.Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n            <h2>");
#nullable restore
#line 7 "C:\Users\Dudu\Desktop\Accenture Bootcamp\Curso 05\TP MVC\SLNClinica\SLNClinica\Views\Medico\Details.cshtml"
           Write(Html.DisplayFor(modelItem=>modelItem.Apellido));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n            <h2>");
#nullable restore
#line 8 "C:\Users\Dudu\Desktop\Accenture Bootcamp\Curso 05\TP MVC\SLNClinica\SLNClinica\Views\Medico\Details.cshtml"
           Write(Html.DisplayFor(modelItem=>modelItem.Matricula));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n    \r\n\r\n    ");
#nullable restore
#line 11 "C:\Users\Dudu\Desktop\Accenture Bootcamp\Curso 05\TP MVC\SLNClinica\SLNClinica\Views\Medico\Details.cshtml"
Write(Html.ActionLink("Volver al index","Index","Medico"));

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SLNClinica.Models.Medico> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
