#pragma checksum "C:\Users\Dudu\Desktop\Accenture Bootcamp\Curso 05\TP MVC\WebEscuelaMVC\WebEscuelaMVC\Views\Aula\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d546bfff0a72ffb314675828f9d303fa3d381f3f"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d546bfff0a72ffb314675828f9d303fa3d381f3f", @"/Views/Aula/Index.cshtml")]
    #nullable restore
    public class Views_Aula_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<WebEscuelaMVC.Models.Aula>>
    #nullable disable
    {
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d546bfff0a72ffb314675828f9d303fa3d381f3f2821", async() => {
                WriteLiteral("\r\n    <meta name=\"viewport\" content=\"width=device-width\" />\r\n    <title>Index</title>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d546bfff0a72ffb314675828f9d303fa3d381f3f3880", async() => {
                WriteLiteral("\r\n    ");
#nullable restore
#line 11 "C:\Users\Dudu\Desktop\Accenture Bootcamp\Curso 05\TP MVC\WebEscuelaMVC\WebEscuelaMVC\Views\Aula\Index.cshtml"
Write(Html.ActionLink("Nuevo", "Register", "Aula"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n    <h1>Lista de Aulas</h1>\r\n    <table>\r\n        <tr>\r\n            <th>");
#nullable restore
#line 16 "C:\Users\Dudu\Desktop\Accenture Bootcamp\Curso 05\TP MVC\WebEscuelaMVC\WebEscuelaMVC\Views\Aula\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Numero));

#line default
#line hidden
#nullable disable
                WriteLiteral("</th>\r\n            <th>");
#nullable restore
#line 17 "C:\Users\Dudu\Desktop\Accenture Bootcamp\Curso 05\TP MVC\WebEscuelaMVC\WebEscuelaMVC\Views\Aula\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Estado));

#line default
#line hidden
#nullable disable
                WriteLiteral("</th>\r\n\r\n            <th></th>\r\n        </tr>\r\n\r\n");
#nullable restore
#line 22 "C:\Users\Dudu\Desktop\Accenture Bootcamp\Curso 05\TP MVC\WebEscuelaMVC\WebEscuelaMVC\Views\Aula\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 25 "C:\Users\Dudu\Desktop\Accenture Bootcamp\Curso 05\TP MVC\WebEscuelaMVC\WebEscuelaMVC\Views\Aula\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Numero));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 26 "C:\Users\Dudu\Desktop\Accenture Bootcamp\Curso 05\TP MVC\WebEscuelaMVC\WebEscuelaMVC\Views\Aula\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Estado));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n\r\n                    <td>\r\n                    ");
#nullable restore
#line 29 "C:\Users\Dudu\Desktop\Accenture Bootcamp\Curso 05\TP MVC\WebEscuelaMVC\WebEscuelaMVC\Views\Aula\Index.cshtml"
               Write(Html.ActionLink("Detalle", "Detalle", "Aula", new{id = item.Id}));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    ");
#nullable restore
#line 30 "C:\Users\Dudu\Desktop\Accenture Bootcamp\Curso 05\TP MVC\WebEscuelaMVC\WebEscuelaMVC\Views\Aula\Index.cshtml"
               Write(Html.ActionLink("Eliminar", "Delete", "Aula", new{id = item.Id}));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    ");
#nullable restore
#line 31 "C:\Users\Dudu\Desktop\Accenture Bootcamp\Curso 05\TP MVC\WebEscuelaMVC\WebEscuelaMVC\Views\Aula\Index.cshtml"
               Write(Html.ActionLink("Editar", "Edit", "Aula", new{id = item.Id}));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 34 "C:\Users\Dudu\Desktop\Accenture Bootcamp\Curso 05\TP MVC\WebEscuelaMVC\WebEscuelaMVC\Views\Aula\Index.cshtml"

        }

#line default
#line hidden
#nullable disable
                WriteLiteral("    </table>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<WebEscuelaMVC.Models.Aula>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591