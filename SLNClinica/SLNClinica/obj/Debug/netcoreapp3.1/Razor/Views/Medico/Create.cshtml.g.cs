#pragma checksum "C:\Users\Dudu\Desktop\Accenture Bootcamp\Curso 05\TP MVC\SLNClinica\SLNClinica\Views\Medico\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "66f35ae7ad38b311c4fce6af490b92d060aa52bc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Medico_Create), @"mvc.1.0.view", @"/Views/Medico/Create.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"66f35ae7ad38b311c4fce6af490b92d060aa52bc", @"/Views/Medico/Create.cshtml")]
    #nullable restore
    public class Views_Medico_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SLNClinica.Models.Medico>
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "66f35ae7ad38b311c4fce6af490b92d060aa52bc2816", async() => {
                WriteLiteral("\r\n    <meta name=\"viewport\" content=\"width=device-width\" />\r\n    <title>Create</title>\r\n");
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "66f35ae7ad38b311c4fce6af490b92d060aa52bc3876", async() => {
                WriteLiteral("\r\n\r\n    <h2>Ingrese un nuevo médico</h2>\r\n\r\n");
#nullable restore
#line 14 "C:\Users\Dudu\Desktop\Accenture Bootcamp\Curso 05\TP MVC\SLNClinica\SLNClinica\Views\Medico\Create.cshtml"
     using (Html.BeginForm("Create", "Medico", FormMethod.Post))
    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <p>\r\n            ");
#nullable restore
#line 17 "C:\Users\Dudu\Desktop\Accenture Bootcamp\Curso 05\TP MVC\SLNClinica\SLNClinica\Views\Medico\Create.cshtml"
       Write(Html.LabelFor(model=>model.Nombre));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            ");
#nullable restore
#line 18 "C:\Users\Dudu\Desktop\Accenture Bootcamp\Curso 05\TP MVC\SLNClinica\SLNClinica\Views\Medico\Create.cshtml"
       Write(Html.TextBoxFor(model=>model.Nombre));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            ");
#nullable restore
#line 19 "C:\Users\Dudu\Desktop\Accenture Bootcamp\Curso 05\TP MVC\SLNClinica\SLNClinica\Views\Medico\Create.cshtml"
       Write(Html.ValidationMessageFor(model=>model.Nombre));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </p>\r\n                 <p>\r\n            ");
#nullable restore
#line 22 "C:\Users\Dudu\Desktop\Accenture Bootcamp\Curso 05\TP MVC\SLNClinica\SLNClinica\Views\Medico\Create.cshtml"
       Write(Html.LabelFor(model=>model.Apellido));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            ");
#nullable restore
#line 23 "C:\Users\Dudu\Desktop\Accenture Bootcamp\Curso 05\TP MVC\SLNClinica\SLNClinica\Views\Medico\Create.cshtml"
       Write(Html.TextBoxFor(model=>model.Apellido));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            ");
#nullable restore
#line 24 "C:\Users\Dudu\Desktop\Accenture Bootcamp\Curso 05\TP MVC\SLNClinica\SLNClinica\Views\Medico\Create.cshtml"
       Write(Html.ValidationMessageFor(model=>model.Apellido));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </p>\r\n                 <p>\r\n            ");
#nullable restore
#line 27 "C:\Users\Dudu\Desktop\Accenture Bootcamp\Curso 05\TP MVC\SLNClinica\SLNClinica\Views\Medico\Create.cshtml"
       Write(Html.LabelFor(model=>model.Matricula));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            ");
#nullable restore
#line 28 "C:\Users\Dudu\Desktop\Accenture Bootcamp\Curso 05\TP MVC\SLNClinica\SLNClinica\Views\Medico\Create.cshtml"
       Write(Html.TextBoxFor(model=>model.Matricula));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            ");
#nullable restore
#line 29 "C:\Users\Dudu\Desktop\Accenture Bootcamp\Curso 05\TP MVC\SLNClinica\SLNClinica\Views\Medico\Create.cshtml"
       Write(Html.ValidationMessageFor(model=>model.Matricula));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </p>\r\n");
                WriteLiteral("                <input type=\"submit\"  action=\"Create\" />\r\n");
#nullable restore
#line 34 "C:\Users\Dudu\Desktop\Accenture Bootcamp\Curso 05\TP MVC\SLNClinica\SLNClinica\Views\Medico\Create.cshtml"
   Write(Html.ActionLink("Volver a Index", "Index", "Medico"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 34 "C:\Users\Dudu\Desktop\Accenture Bootcamp\Curso 05\TP MVC\SLNClinica\SLNClinica\Views\Medico\Create.cshtml"
                                                             
    }

#line default
#line hidden
#nullable disable
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
            WriteLiteral("\r\n</html>\r\n");
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
