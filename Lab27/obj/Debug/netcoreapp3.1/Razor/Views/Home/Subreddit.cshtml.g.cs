#pragma checksum "C:\Users\kyle\source\repos\Lab27\Lab27\Views\Home\Subreddit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d1b3ca0021aa9855f1d4caf8dbd9df283f75537b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Subreddit), @"mvc.1.0.view", @"/Views/Home/Subreddit.cshtml")]
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
#line 1 "C:\Users\kyle\source\repos\Lab27\Lab27\Views\_ViewImports.cshtml"
using Lab27;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\kyle\source\repos\Lab27\Lab27\Views\_ViewImports.cshtml"
using Lab27.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d1b3ca0021aa9855f1d4caf8dbd9df283f75537b", @"/Views/Home/Subreddit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d516de0345d55f6de0a7ecf503cf0bdf51f96fa7", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Subreddit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RedditPost>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("    <a");
            BeginWriteAttribute("href", " href=\"", 25, "\"", 48, 1);
#nullable restore
#line 2 "C:\Users\kyle\source\repos\Lab27\Lab27\Views\Home\Subreddit.cshtml"
WriteAttributeValue("", 32, Model.permalink, 32, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n        <h2>");
#nullable restore
#line 3 "C:\Users\kyle\source\repos\Lab27\Lab27\Views\Home\Subreddit.cshtml"
       Write(Model.title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n\r\n        <img");
            BeginWriteAttribute("src", " src=\"", 97, "\"", 119, 1);
#nullable restore
#line 5 "C:\Users\kyle\source\repos\Lab27\Lab27\Views\Home\Subreddit.cshtml"
WriteAttributeValue("", 103, Model.thumbnail, 103, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n    </a>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RedditPost> Html { get; private set; }
    }
}
#pragma warning restore 1591
