#pragma checksum "C:\Users\cwmorency\source\repos\ProjetCSharp\ProjetCSharp\Views\Home\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ec0bee1a8f24ee6bbaacbc4f2f1ed44a4fbbb8ba"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Create), @"mvc.1.0.view", @"/Views/Home/Create.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Create.cshtml", typeof(AspNetCore.Views_Home_Create))]
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
#line 1 "C:\Users\cwmorency\source\repos\ProjetCSharp\ProjetCSharp\Views\_ViewImports.cshtml"
using ProjetCSharp;

#line default
#line hidden
#line 2 "C:\Users\cwmorency\source\repos\ProjetCSharp\ProjetCSharp\Views\_ViewImports.cshtml"
using ProjetCSharp.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ec0bee1a8f24ee6bbaacbc4f2f1ed44a4fbbb8ba", @"/Views/Home/Create.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c3ae7e349d58e3176f57cd2b6f4eb7a75f5bf365", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Movies>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\cwmorency\source\repos\ProjetCSharp\ProjetCSharp\Views\Home\Create.cshtml"
  
    ViewData["Title"] = "Create";

#line default
#line hidden
            BeginContext(57, 211, true);
            WriteLiteral("    <style type=\"text/css\">\r\n        select {\r\n            border: 1px solid #cccccc;\r\n            vertical-align: top;\r\n            height: 30px;\r\n        }\r\n    </style>\r\n\r\n    <h1>New movie information</h1>\r\n");
            EndContext();
#line 14 "C:\Users\cwmorency\source\repos\ProjetCSharp\ProjetCSharp\Views\Home\Create.cshtml"
     using (Html.BeginForm("Insert", "Home", FormMethod.Post))
    {



#line default
#line hidden
            BeginContext(343, 314, true);
            WriteLiteral(@"        <table class=""table table-striped; table table-responsive-sm"">
            <tr>
                
                <th>Name</th>
                <th>Description</th>
                <th>Status</th>
                <th></th>
            </tr>

            <tr>
                
                <td>");
            EndContext();
            BeginContext(658, 36, false);
#line 29 "C:\Users\cwmorency\source\repos\ProjetCSharp\ProjetCSharp\Views\Home\Create.cshtml"
               Write(Html.TextBoxFor(model => model.name));

#line default
#line hidden
            EndContext();
            BeginContext(694, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(722, 43, false);
#line 30 "C:\Users\cwmorency\source\repos\ProjetCSharp\ProjetCSharp\Views\Home\Create.cshtml"
               Write(Html.TextBoxFor(model => model.description));

#line default
#line hidden
            EndContext();
            BeginContext(765, 49, true);
            WriteLiteral("</td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(815, 206, false);
#line 32 "C:\Users\cwmorency\source\repos\ProjetCSharp\ProjetCSharp\Views\Home\Create.cshtml"
               Write(Html.DropDownListFor(model => model.status,
                                                new SelectList(Enum.GetValues(typeof(Status))),
                                                "Select status"));

#line default
#line hidden
            EndContext();
            BeginContext(1021, 45, true);
            WriteLiteral("\r\n                </td>\r\n                <td>");
            EndContext();
            BeginContext(1067, 78, false);
#line 36 "C:\Users\cwmorency\source\repos\ProjetCSharp\ProjetCSharp\Views\Home\Create.cshtml"
               Write(Html.TextBoxFor(model => model.id, new { style = "display:none", @Name = "" }));

#line default
#line hidden
            EndContext();
            BeginContext(1145, 186, true);
            WriteLiteral("</td>\r\n                <td><button type=\"submit\" class=\"btn btn-primary\" style=\"height:30px;text-align:center;font-size:small\">Submit</button></td>\r\n            </tr>\r\n        </table>\r\n");
            EndContext();
#line 40 "C:\Users\cwmorency\source\repos\ProjetCSharp\ProjetCSharp\Views\Home\Create.cshtml"
    }

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Movies> Html { get; private set; }
    }
}
#pragma warning restore 1591