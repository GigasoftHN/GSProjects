#pragma checksum "C:\Users\lfmendez\Documents\Visual Studio 2017\Projects\HelloMVCWorld2\HelloMVCWorld2\Views\WebUser\SimpleBinding.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "35a08454f704abbc8038b8a2a4120d7155656cbb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_WebUser_SimpleBinding), @"mvc.1.0.view", @"/Views/WebUser/SimpleBinding.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/WebUser/SimpleBinding.cshtml", typeof(AspNetCore.Views_WebUser_SimpleBinding))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"35a08454f704abbc8038b8a2a4120d7155656cbb", @"/Views/WebUser/SimpleBinding.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6fdc2d496fac8576866668511439863701c6dc11", @"/Views/_ViewImports.cshtml")]
    public class Views_WebUser_SimpleBinding : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HelloMVCWorld2.Models.WebUser>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(38, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 4 "C:\Users\lfmendez\Documents\Visual Studio 2017\Projects\HelloMVCWorld2\HelloMVCWorld2\Views\WebUser\SimpleBinding.cshtml"
 using (var form = Html.BeginForm())
{

#line default
#line hidden
            BeginContext(83, 19, true);
            WriteLiteral("    <div>\r\n        ");
            EndContext();
            BeginContext(103, 31, false);
#line 7 "C:\Users\lfmendez\Documents\Visual Studio 2017\Projects\HelloMVCWorld2\HelloMVCWorld2\Views\WebUser\SimpleBinding.cshtml"
   Write(Html.LabelFor(m => m.FirstName));

#line default
#line hidden
            EndContext();
            BeginContext(134, 10, true);
            WriteLiteral("\r\n        ");
            EndContext();
            BeginContext(145, 33, false);
#line 8 "C:\Users\lfmendez\Documents\Visual Studio 2017\Projects\HelloMVCWorld2\HelloMVCWorld2\Views\WebUser\SimpleBinding.cshtml"
   Write(Html.TextBoxFor(m => m.FirstName));

#line default
#line hidden
            EndContext();
            BeginContext(178, 14, true);
            WriteLiteral("\r\n    </div>\r\n");
            EndContext();
            BeginContext(194, 19, true);
            WriteLiteral("    <div>\r\n        ");
            EndContext();
            BeginContext(214, 30, false);
#line 12 "C:\Users\lfmendez\Documents\Visual Studio 2017\Projects\HelloMVCWorld2\HelloMVCWorld2\Views\WebUser\SimpleBinding.cshtml"
   Write(Html.LabelFor(m => m.LastName));

#line default
#line hidden
            EndContext();
            BeginContext(244, 10, true);
            WriteLiteral("\r\n        ");
            EndContext();
            BeginContext(255, 32, false);
#line 13 "C:\Users\lfmendez\Documents\Visual Studio 2017\Projects\HelloMVCWorld2\HelloMVCWorld2\Views\WebUser\SimpleBinding.cshtml"
   Write(Html.TextBoxFor(m => m.LastName));

#line default
#line hidden
            EndContext();
            BeginContext(287, 14, true);
            WriteLiteral("\r\n    </div>\r\n");
            EndContext();
            BeginContext(303, 19, true);
            WriteLiteral("    <div>\r\n        ");
            EndContext();
            BeginContext(323, 33, false);
#line 17 "C:\Users\lfmendez\Documents\Visual Studio 2017\Projects\HelloMVCWorld2\HelloMVCWorld2\Views\WebUser\SimpleBinding.cshtml"
   Write(Html.LabelFor(m => m.MailAddress));

#line default
#line hidden
            EndContext();
            BeginContext(356, 10, true);
            WriteLiteral("\r\n        ");
            EndContext();
            BeginContext(367, 35, false);
#line 18 "C:\Users\lfmendez\Documents\Visual Studio 2017\Projects\HelloMVCWorld2\HelloMVCWorld2\Views\WebUser\SimpleBinding.cshtml"
   Write(Html.TextBoxFor(m => m.MailAddress));

#line default
#line hidden
            EndContext();
            BeginContext(402, 14, true);
            WriteLiteral("\r\n    </div>\r\n");
            EndContext();
            BeginContext(418, 44, true);
            WriteLiteral("    <input type=\"submit\" value=\"Submit\" />\r\n");
            EndContext();
#line 22 "C:\Users\lfmendez\Documents\Visual Studio 2017\Projects\HelloMVCWorld2\HelloMVCWorld2\Views\WebUser\SimpleBinding.cshtml"
}

#line default
#line hidden
            BeginContext(465, 4, true);
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HelloMVCWorld2.Models.WebUser> Html { get; private set; }
    }
}
#pragma warning restore 1591
