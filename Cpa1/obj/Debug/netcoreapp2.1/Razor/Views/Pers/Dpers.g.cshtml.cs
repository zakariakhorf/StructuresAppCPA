#pragma checksum "C:\Users\Win 10\source\repos\Cpa1\Views\Pers\Dpers.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a77f1cc3dd40ef4f524a7eb6f52b110ed181a8f8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pers_Dpers), @"mvc.1.0.view", @"/Views/Pers/Dpers.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Pers/Dpers.cshtml", typeof(AspNetCore.Views_Pers_Dpers))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a77f1cc3dd40ef4f524a7eb6f52b110ed181a8f8", @"/Views/Pers/Dpers.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"09256092b795e023b9a20a16e92112052861c5c2", @"/Views/_ViewImports.cshtml")]
    public class Views_Pers_Dpers : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Cpa1.Models.Personne>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(29, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Win 10\source\repos\Cpa1\Views\Pers\Dpers.cshtml"
  
    ViewData["Title"] = "Dpers";

#line default
#line hidden
            BeginContext(72, 129, true);
            WriteLiteral("\r\n<h2>Détails Gérant</h2>\r\n\r\n<div>\r\n    <h4>Personne</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(202, 40, false);
#line 14 "C:\Users\Win 10\source\repos\Cpa1\Views\Pers\Dpers.cshtml"
       Write(Html.DisplayNameFor(model => model.code));

#line default
#line hidden
            EndContext();
            BeginContext(242, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(286, 36, false);
#line 17 "C:\Users\Win 10\source\repos\Cpa1\Views\Pers\Dpers.cshtml"
       Write(Html.DisplayFor(model => model.code));

#line default
#line hidden
            EndContext();
            BeginContext(322, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(366, 39, false);
#line 20 "C:\Users\Win 10\source\repos\Cpa1\Views\Pers\Dpers.cshtml"
       Write(Html.DisplayNameFor(model => model.Nom));

#line default
#line hidden
            EndContext();
            BeginContext(405, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(449, 35, false);
#line 23 "C:\Users\Win 10\source\repos\Cpa1\Views\Pers\Dpers.cshtml"
       Write(Html.DisplayFor(model => model.Nom));

#line default
#line hidden
            EndContext();
            BeginContext(484, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(528, 42, false);
#line 26 "C:\Users\Win 10\source\repos\Cpa1\Views\Pers\Dpers.cshtml"
       Write(Html.DisplayNameFor(model => model.Prenom));

#line default
#line hidden
            EndContext();
            BeginContext(570, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(614, 38, false);
#line 29 "C:\Users\Win 10\source\repos\Cpa1\Views\Pers\Dpers.cshtml"
       Write(Html.DisplayFor(model => model.Prenom));

#line default
#line hidden
            EndContext();
            BeginContext(652, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(696, 43, false);
#line 32 "C:\Users\Win 10\source\repos\Cpa1\Views\Pers\Dpers.cshtml"
       Write(Html.DisplayNameFor(model => model.qualite));

#line default
#line hidden
            EndContext();
            BeginContext(739, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(783, 39, false);
#line 35 "C:\Users\Win 10\source\repos\Cpa1\Views\Pers\Dpers.cshtml"
       Write(Html.DisplayFor(model => model.qualite));

#line default
#line hidden
            EndContext();
            BeginContext(822, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(870, 56, false);
#line 40 "C:\Users\Win 10\source\repos\Cpa1\Views\Pers\Dpers.cshtml"
Write(Html.ActionLink("Edit", "Edit", new { id = Model.code }));

#line default
#line hidden
            EndContext();
            BeginContext(926, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(935, 92, false);
#line 41 "C:\Users\Win 10\source\repos\Cpa1\Views\Pers\Dpers.cshtml"
Write(Html.ActionLink("Back to list", "Lstruct", "structure", new { /* id = Model.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(1027, 40, true);
            WriteLiteral("\r\n    <p>&copy; 2019 - CPA</p>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Cpa1.Models.Personne> Html { get; private set; }
    }
}
#pragma warning restore 1591
