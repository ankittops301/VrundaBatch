#pragma checksum "C:\Ankit Patel\Lectures\VrundaBatch\Statemgmt\Statemgmt\Views\Default\svar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e5f114ac4e06919bff73029f598f84f96a193198"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Default_svar), @"mvc.1.0.view", @"/Views/Default/svar.cshtml")]
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
#line 1 "C:\Ankit Patel\Lectures\VrundaBatch\Statemgmt\Statemgmt\Views\_ViewImports.cshtml"
using Statemgmt;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Ankit Patel\Lectures\VrundaBatch\Statemgmt\Statemgmt\Views\_ViewImports.cshtml"
using Statemgmt.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e5f114ac4e06919bff73029f598f84f96a193198", @"/Views/Default/svar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b8cfe0d80f7ed4915d76db6d13139ef5f2dac930", @"/Views/_ViewImports.cshtml")]
    public class Views_Default_svar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Ankit Patel\Lectures\VrundaBatch\Statemgmt\Statemgmt\Views\Default\svar.cshtml"
  
    ViewData["Title"] = "svar";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>svar</h1>\r\n\r\n<h3>");
#nullable restore
#line 8 "C:\Ankit Patel\Lectures\VrundaBatch\Statemgmt\Statemgmt\Views\Default\svar.cshtml"
Write(ViewBag.message);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n<h3>");
#nullable restore
#line 9 "C:\Ankit Patel\Lectures\VrundaBatch\Statemgmt\Statemgmt\Views\Default\svar.cshtml"
Write(ViewData["msg"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n<h3>");
#nullable restore
#line 10 "C:\Ankit Patel\Lectures\VrundaBatch\Statemgmt\Statemgmt\Views\Default\svar.cshtml"
Write(TempData["info"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n\r\n<a href=\"/Default/second\">Goto Second Page</a>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
