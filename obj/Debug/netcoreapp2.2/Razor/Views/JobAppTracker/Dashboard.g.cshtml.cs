#pragma checksum "/Users/cthulhu/Documents/Dojo/JobAppTracker/Views/JobAppTracker/Dashboard.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b4e7aa05794005db4e47e2105aeaa951756643fd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_JobAppTracker_Dashboard), @"mvc.1.0.view", @"/Views/JobAppTracker/Dashboard.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/JobAppTracker/Dashboard.cshtml", typeof(AspNetCore.Views_JobAppTracker_Dashboard))]
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
#line 1 "/Users/cthulhu/Documents/Dojo/JobAppTracker/Views/_ViewImports.cshtml"
using JobAppTracker;

#line default
#line hidden
#line 2 "/Users/cthulhu/Documents/Dojo/JobAppTracker/Views/_ViewImports.cshtml"
using JobAppTracker.Models;

#line default
#line hidden
#line 4 "/Users/cthulhu/Documents/Dojo/JobAppTracker/Views/_ViewImports.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b4e7aa05794005db4e47e2105aeaa951756643fd", @"/Views/JobAppTracker/Dashboard.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a1a8f28911e08e19150cb7989cfa8ddaa93db4e7", @"/Views/_ViewImports.cshtml")]
    public class Views_JobAppTracker_Dashboard : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/cthulhu/Documents/Dojo/JobAppTracker/Views/JobAppTracker/Dashboard.cshtml"
  
    int? loggedInUserId = Context.Session.GetInt32("UserId");
    string loggedInFirstName = Context.Session.GetString("FirstName");

#line default
#line hidden
            BeginContext(138, 33, true);
            WriteLiteral("\n\n\n<div>\n    <h1>Body</h1>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591