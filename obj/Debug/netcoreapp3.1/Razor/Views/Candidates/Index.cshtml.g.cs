#pragma checksum "C:\Navveenn\DIS\Navveenn-project\Latest_webproject\Views\Candidates\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2d8afd8993b4057d9ab95a2bc6377554b77e0de3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Candidates_Index), @"mvc.1.0.view", @"/Views/Candidates/Index.cshtml")]
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
#line 1 "C:\Navveenn\DIS\Navveenn-project\Latest_webproject\Views\_ViewImports.cshtml"
using Mywebproject_core;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Navveenn\DIS\Navveenn-project\Latest_webproject\Views\_ViewImports.cshtml"
using Mywebproject_core.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2d8afd8993b4057d9ab95a2bc6377554b77e0de3", @"/Views/Candidates/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"54bf2e16fdfaf8a526805a9e28c5ed1a1417a857", @"/Views/_ViewImports.cshtml")]
    public class Views_Candidates_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Mywebproject_core.Models.CandidateDetail>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Navveenn\DIS\Navveenn-project\Latest_webproject\Views\Candidates\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>Index</h2>\r\n\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 13 "C:\Navveenn\DIS\Navveenn-project\Latest_webproject\Views\Candidates\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 16 "C:\Navveenn\DIS\Navveenn-project\Latest_webproject\Views\Candidates\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.party));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 19 "C:\Navveenn\DIS\Navveenn-project\Latest_webproject\Views\Candidates\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.candidate_status));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 22 "C:\Navveenn\DIS\Navveenn-project\Latest_webproject\Views\Candidates\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.state));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 28 "C:\Navveenn\DIS\Navveenn-project\Latest_webproject\Views\Candidates\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 32 "C:\Navveenn\DIS\Navveenn-project\Latest_webproject\Views\Candidates\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 35 "C:\Navveenn\DIS\Navveenn-project\Latest_webproject\Views\Candidates\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.party));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 38 "C:\Navveenn\DIS\Navveenn-project\Latest_webproject\Views\Candidates\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.candidate_status));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 41 "C:\Navveenn\DIS\Navveenn-project\Latest_webproject\Views\Candidates\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.state));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n");
            WriteLiteral("            </tr>\r\n");
#nullable restore
#line 49 "C:\Navveenn\DIS\Navveenn-project\Latest_webproject\Views\Candidates\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Mywebproject_core.Models.CandidateDetail>> Html { get; private set; }
    }
}
#pragma warning restore 1591
