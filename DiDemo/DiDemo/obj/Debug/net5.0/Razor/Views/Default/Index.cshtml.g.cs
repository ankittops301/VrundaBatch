#pragma checksum "C:\Ankit Patel\Lectures\VrundaBatch\DiDemo\DiDemo\Views\Default\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "701cf8a7edf8ca3f3507d9e6dfdcaea518098df5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Default_Index), @"mvc.1.0.view", @"/Views/Default/Index.cshtml")]
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
#line 1 "C:\Ankit Patel\Lectures\VrundaBatch\DiDemo\DiDemo\Views\_ViewImports.cshtml"
using DiDemo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Ankit Patel\Lectures\VrundaBatch\DiDemo\DiDemo\Views\_ViewImports.cshtml"
using DiDemo.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Ankit Patel\Lectures\VrundaBatch\DiDemo\DiDemo\Views\Default\Index.cshtml"
using DiDemo.Services;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"701cf8a7edf8ca3f3507d9e6dfdcaea518098df5", @"/Views/Default/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9638c4931f857e32a2e008550df05d866e421ed6", @"/Views/_ViewImports.cshtml")]
    public class Views_Default_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Ankit Patel\Lectures\VrundaBatch\DiDemo\DiDemo\Views\Default\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Index</h1>\r\n\r\n<h3>Controller level count: ");
#nullable restore
#line 10 "C:\Ankit Patel\Lectures\VrundaBatch\DiDemo\DiDemo\Views\Default\Index.cshtml"
                       Write(ViewBag.count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n<h3>View Level count: ");
#nullable restore
#line 11 "C:\Ankit Patel\Lectures\VrundaBatch\DiDemo\DiDemo\Views\Default\Index.cshtml"
                 Write(_counter.GetCount());

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n<h3>View level count: ");
#nullable restore
#line 12 "C:\Ankit Patel\Lectures\VrundaBatch\DiDemo\DiDemo\Views\Default\Index.cshtml"
                 Write(ViewBag.cnt);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IVisitorCounter _counter { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
