#pragma checksum "C:\Users\Win 10\source\repos\Cpa1\Views\structure\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ff669caf634d245d7ab1fbd4f2b0d1391231e3f6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_structure_Delete), @"mvc.1.0.view", @"/Views/structure/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/structure/Delete.cshtml", typeof(AspNetCore.Views_structure_Delete))]
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
#line 1 "C:\Users\Win 10\source\repos\Cpa1\Views\_ViewImports.cshtml"
using Cpa1;

#line default
#line hidden
#line 2 "C:\Users\Win 10\source\repos\Cpa1\Views\_ViewImports.cshtml"
using Cpa1.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ff669caf634d245d7ab1fbd4f2b0d1391231e3f6", @"/Views/structure/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"09256092b795e023b9a20a16e92112052861c5c2", @"/Views/_ViewImports.cshtml")]
    public class Views_structure_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Cpa1.Models.structure>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "lstruct", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeleteOK", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(30, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Win 10\source\repos\Cpa1\Views\structure\Delete.cshtml"
  
    ViewData["Title"] = "Delete";

#line default
#line hidden
            BeginContext(74, 170, true);
            WriteLiteral("\r\n<h2>Delete</h2>\r\n\r\n<h3>Are you sure you want to delete this?</h3>\r\n<div>\r\n    <h4>structure</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(245, 40, false);
#line 15 "C:\Users\Win 10\source\repos\Cpa1\Views\structure\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.code));

#line default
#line hidden
            EndContext();
            BeginContext(285, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(329, 36, false);
#line 18 "C:\Users\Win 10\source\repos\Cpa1\Views\structure\Delete.cshtml"
       Write(Html.DisplayFor(model => model.code));

#line default
#line hidden
            EndContext();
            BeginContext(365, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(409, 39, false);
#line 21 "C:\Users\Win 10\source\repos\Cpa1\Views\structure\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.abr));

#line default
#line hidden
            EndContext();
            BeginContext(448, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(492, 35, false);
#line 24 "C:\Users\Win 10\source\repos\Cpa1\Views\structure\Delete.cshtml"
       Write(Html.DisplayFor(model => model.abr));

#line default
#line hidden
            EndContext();
            BeginContext(527, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(571, 41, false);
#line 27 "C:\Users\Win 10\source\repos\Cpa1\Views\structure\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.desig));

#line default
#line hidden
            EndContext();
            BeginContext(612, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(656, 37, false);
#line 30 "C:\Users\Win 10\source\repos\Cpa1\Views\structure\Delete.cshtml"
       Write(Html.DisplayFor(model => model.desig));

#line default
#line hidden
            EndContext();
            BeginContext(693, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(737, 39, false);
#line 33 "C:\Users\Win 10\source\repos\Cpa1\Views\structure\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.adr));

#line default
#line hidden
            EndContext();
            BeginContext(776, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(820, 35, false);
#line 36 "C:\Users\Win 10\source\repos\Cpa1\Views\structure\Delete.cshtml"
       Write(Html.DisplayFor(model => model.adr));

#line default
#line hidden
            EndContext();
            BeginContext(855, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(899, 45, false);
#line 39 "C:\Users\Win 10\source\repos\Cpa1\Views\structure\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.telephone));

#line default
#line hidden
            EndContext();
            BeginContext(944, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(988, 41, false);
#line 42 "C:\Users\Win 10\source\repos\Cpa1\Views\structure\Delete.cshtml"
       Write(Html.DisplayFor(model => model.telephone));

#line default
#line hidden
            EndContext();
            BeginContext(1029, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1073, 39, false);
#line 45 "C:\Users\Win 10\source\repos\Cpa1\Views\structure\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.fax));

#line default
#line hidden
            EndContext();
            BeginContext(1112, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1156, 35, false);
#line 48 "C:\Users\Win 10\source\repos\Cpa1\Views\structure\Delete.cshtml"
       Write(Html.DisplayFor(model => model.fax));

#line default
#line hidden
            EndContext();
            BeginContext(1191, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1235, 46, false);
#line 51 "C:\Users\Win 10\source\repos\Cpa1\Views\structure\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.IDpersonne));

#line default
#line hidden
            EndContext();
            BeginContext(1281, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1325, 42, false);
#line 54 "C:\Users\Win 10\source\repos\Cpa1\Views\structure\Delete.cshtml"
       Write(Html.DisplayFor(model => model.IDpersonne));

#line default
#line hidden
            EndContext();
            BeginContext(1367, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1411, 45, false);
#line 57 "C:\Users\Win 10\source\repos\Cpa1\Views\structure\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.IDattaché));

#line default
#line hidden
            EndContext();
            BeginContext(1456, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1500, 41, false);
#line 60 "C:\Users\Win 10\source\repos\Cpa1\Views\structure\Delete.cshtml"
       Write(Html.DisplayFor(model => model.IDattaché));

#line default
#line hidden
            EndContext();
            BeginContext(1541, 38, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n    \r\n    ");
            EndContext();
            BeginContext(1579, 165, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "22f236ae11ff427fadd42625c679a75e", async() => {
                BeginContext(1607, 84, true);
                WriteLiteral("\r\n        <input type=\"submit\" value=\"Delete\" class=\"btn btn-default\" /> |\r\n        ");
                EndContext();
                BeginContext(1691, 40, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "09e2cb2849bd49ab9d4a24dd4381a78d", async() => {
                    BeginContext(1715, 12, true);
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
                BeginContext(1731, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1744, 10, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Cpa1.Models.structure> Html { get; private set; }
    }
}
#pragma warning restore 1591
