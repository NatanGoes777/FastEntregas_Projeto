#pragma checksum "C:\UFS\FastEntregas\Codigo\Fast Entregas\Fast Entregas\Views\Cartao\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8fe3a95391f63d0ea541f9462cb7635eff98fdb4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cartao_Details), @"mvc.1.0.view", @"/Views/Cartao/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Cartao/Details.cshtml", typeof(AspNetCore.Views_Cartao_Details))]
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
#line 1 "C:\UFS\FastEntregas\Codigo\Fast Entregas\Fast Entregas\Views\_ViewImports.cshtml"
using Fast_Entregas;

#line default
#line hidden
#line 2 "C:\UFS\FastEntregas\Codigo\Fast Entregas\Fast Entregas\Views\_ViewImports.cshtml"
using Fast_Entregas.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8fe3a95391f63d0ea541f9462cb7635eff98fdb4", @"/Views/Cartao/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f3e57456748e9e8528fa18a08bb68a9c2b12e137", @"/Views/_ViewImports.cshtml")]
    public class Views_Cartao_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Model.Cartao>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(21, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\UFS\FastEntregas\Codigo\Fast Entregas\Fast Entregas\Views\Cartao\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(66, 129, true);
            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n<div>\r\n    <h4>Cartao</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(196, 45, false);
#line 14 "C:\UFS\FastEntregas\Codigo\Fast Entregas\Fast Entregas\Views\Cartao\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.CodCartao));

#line default
#line hidden
            EndContext();
            BeginContext(241, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(305, 41, false);
#line 17 "C:\UFS\FastEntregas\Codigo\Fast Entregas\Fast Entregas\Views\Cartao\Details.cshtml"
       Write(Html.DisplayFor(model => model.CodCartao));

#line default
#line hidden
            EndContext();
            BeginContext(346, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(409, 42, false);
#line 20 "C:\UFS\FastEntregas\Codigo\Fast Entregas\Fast Entregas\Views\Cartao\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Numero));

#line default
#line hidden
            EndContext();
            BeginContext(451, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(515, 38, false);
#line 23 "C:\UFS\FastEntregas\Codigo\Fast Entregas\Fast Entregas\Views\Cartao\Details.cshtml"
       Write(Html.DisplayFor(model => model.Numero));

#line default
#line hidden
            EndContext();
            BeginContext(553, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(616, 44, false);
#line 26 "C:\UFS\FastEntregas\Codigo\Fast Entregas\Fast Entregas\Views\Cartao\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.NomeDono));

#line default
#line hidden
            EndContext();
            BeginContext(660, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(724, 40, false);
#line 29 "C:\UFS\FastEntregas\Codigo\Fast Entregas\Fast Entregas\Views\Cartao\Details.cshtml"
       Write(Html.DisplayFor(model => model.NomeDono));

#line default
#line hidden
            EndContext();
            BeginContext(764, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(827, 48, false);
#line 32 "C:\UFS\FastEntregas\Codigo\Fast Entregas\Fast Entregas\Views\Cartao\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.DataValidade));

#line default
#line hidden
            EndContext();
            BeginContext(875, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(939, 44, false);
#line 35 "C:\UFS\FastEntregas\Codigo\Fast Entregas\Fast Entregas\Views\Cartao\Details.cshtml"
       Write(Html.DisplayFor(model => model.DataValidade));

#line default
#line hidden
            EndContext();
            BeginContext(983, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1046, 39, false);
#line 38 "C:\UFS\FastEntregas\Codigo\Fast Entregas\Fast Entregas\Views\Cartao\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Cvv));

#line default
#line hidden
            EndContext();
            BeginContext(1085, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1149, 35, false);
#line 41 "C:\UFS\FastEntregas\Codigo\Fast Entregas\Fast Entregas\Views\Cartao\Details.cshtml"
       Write(Html.DisplayFor(model => model.Cvv));

#line default
#line hidden
            EndContext();
            BeginContext(1184, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1247, 46, false);
#line 44 "C:\UFS\FastEntregas\Codigo\Fast Entregas\Fast Entregas\Views\Cartao\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.CodUsuario));

#line default
#line hidden
            EndContext();
            BeginContext(1293, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1357, 42, false);
#line 47 "C:\UFS\FastEntregas\Codigo\Fast Entregas\Fast Entregas\Views\Cartao\Details.cshtml"
       Write(Html.DisplayFor(model => model.CodUsuario));

#line default
#line hidden
            EndContext();
            BeginContext(1399, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(1447, 65, false);
#line 52 "C:\UFS\FastEntregas\Codigo\Fast Entregas\Fast Entregas\Views\Cartao\Details.cshtml"
Write(Html.ActionLink("Edit", "Edit", new { codigo = Model.CodCartao }));

#line default
#line hidden
            EndContext();
            BeginContext(1512, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(1520, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8fe3a95391f63d0ea541f9462cb7635eff98fdb49407", async() => {
                BeginContext(1542, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1558, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Model.Cartao> Html { get; private set; }
    }
}
#pragma warning restore 1591
