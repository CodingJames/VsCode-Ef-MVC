#pragma checksum "C:\Users\James\Desktop\EF03\Views\Employee\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ad3d0ea2eda60c90425f3329ff8d57ac52635675"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Employee_Index), @"mvc.1.0.view", @"/Views/Employee/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Employee/Index.cshtml", typeof(AspNetCore.Views_Employee_Index))]
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
#line 1 "C:\Users\James\Desktop\EF03\Views\_ViewImports.cshtml"
using EF03;

#line default
#line hidden
#line 2 "C:\Users\James\Desktop\EF03\Views\_ViewImports.cshtml"
using EF03.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ad3d0ea2eda60c90425f3329ff8d57ac52635675", @"/Views/Employee/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0bf5309f09b1e664656003c1fe94a78d99a9d2d9", @"/Views/_ViewImports.cshtml")]
    public class Views_Employee_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<EF03.Models.Employee>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(41, 322, true);
            WriteLiteral(@"
<button class=""btn btn-sm btn-success"" onclick=""window.location='Employee/CreateEmployee'"">Create</button>
<table class=""table table-strip"">
    <thead>
        <tr>
            <th>ID</th>
            <th>Name</th>
            <th>Age</th>
            <th colspan=""2"">Options</th>
        </tr>
    </thead>
    <tbody>
");
            EndContext();
#line 14 "C:\Users\James\Desktop\EF03\Views\Employee\Index.cshtml"
         foreach(var x in Model){

#line default
#line hidden
            BeginContext(397, 29, true);
            WriteLiteral("        <tr>\n            <td>");
            EndContext();
            BeginContext(427, 4, false);
#line 16 "C:\Users\James\Desktop\EF03\Views\Employee\Index.cshtml"
           Write(x.Id);

#line default
#line hidden
            EndContext();
            BeginContext(431, 22, true);
            WriteLiteral("</td>\n            <td>");
            EndContext();
            BeginContext(454, 6, false);
#line 17 "C:\Users\James\Desktop\EF03\Views\Employee\Index.cshtml"
           Write(x.Name);

#line default
#line hidden
            EndContext();
            BeginContext(460, 22, true);
            WriteLiteral("</td>\n            <td>");
            EndContext();
            BeginContext(483, 5, false);
#line 18 "C:\Users\James\Desktop\EF03\Views\Employee\Index.cshtml"
           Write(x.Age);

#line default
#line hidden
            EndContext();
            BeginContext(488, 59, true);
            WriteLiteral("</td>\n            <td><button class=\"btn btn-sm btn-danger\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 547, "\"", 609, 3);
            WriteAttributeValue("", 557, "window.location=\'Employee/DeleteEmployee?Id=", 557, 44, true);
#line 19 "C:\Users\James\Desktop\EF03\Views\Employee\Index.cshtml"
WriteAttributeValue("", 601, x.Id, 601, 7, false);

#line default
#line hidden
            WriteAttributeValue("", 608, "\'", 608, 1, true);
            EndWriteAttribute();
            BeginContext(610, 114, true);
            WriteLiteral("><i class=\"glyphicon glyphicon-trash \"></i></button></td>\n            <td><button class=\"btn btn-sm btn-secondary\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 724, "\"", 784, 3);
            WriteAttributeValue("", 734, "window.location=\'Employee/EditEmployee?Id=", 734, 42, true);
#line 20 "C:\Users\James\Desktop\EF03\Views\Employee\Index.cshtml"
WriteAttributeValue("", 776, x.Id, 776, 7, false);

#line default
#line hidden
            WriteAttributeValue("", 783, "\'", 783, 1, true);
            EndWriteAttribute();
            BeginContext(785, 85, true);
            WriteLiteral("><i class=\"glyphicon glyphicon-trash \"></i></button></td>\n            \n        </tr>\n");
            EndContext();
#line 23 "C:\Users\James\Desktop\EF03\Views\Employee\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(880, 30, true);
            WriteLiteral("        \n    </tbody>\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<EF03.Models.Employee>> Html { get; private set; }
    }
}
#pragma warning restore 1591
