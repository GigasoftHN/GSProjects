#pragma checksum "C:\Users\lfmendez\Documents\Visual Studio 2017\Projects\HelloMVCWorld2\HelloMVCWorld2\Views\WebUser\SimpleValidation.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e225057da55a69c98faad219c14f1f7a73be3bda"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_WebUser_SimpleValidation), @"mvc.1.0.view", @"/Views/WebUser/SimpleValidation.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/WebUser/SimpleValidation.cshtml", typeof(AspNetCore.Views_WebUser_SimpleValidation))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e225057da55a69c98faad219c14f1f7a73be3bda", @"/Views/WebUser/SimpleValidation.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6fdc2d496fac8576866668511439863701c6dc11", @"/Views/_ViewImports.cshtml")]
    public class Views_WebUser_SimpleValidation : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HelloMVCWorld2.Models.WebUser>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(38, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 4 "C:\Users\lfmendez\Documents\Visual Studio 2017\Projects\HelloMVCWorld2\HelloMVCWorld2\Views\WebUser\SimpleValidation.cshtml"
 using (var form = Html.BeginForm())
{
    

#line default
#line hidden
            BeginContext(88, 24, false);
#line 6 "C:\Users\lfmendez\Documents\Visual Studio 2017\Projects\HelloMVCWorld2\HelloMVCWorld2\Views\WebUser\SimpleValidation.cshtml"
Write(Html.ValidationSummary());

#line default
#line hidden
            EndContext();
#line 6 "C:\Users\lfmendez\Documents\Visual Studio 2017\Projects\HelloMVCWorld2\HelloMVCWorld2\Views\WebUser\SimpleValidation.cshtml"
                             ;


#line default
#line hidden
            BeginContext(117, 19, true);
            WriteLiteral("    <div>\r\n        ");
            EndContext();
            BeginContext(137, 31, false);
#line 9 "C:\Users\lfmendez\Documents\Visual Studio 2017\Projects\HelloMVCWorld2\HelloMVCWorld2\Views\WebUser\SimpleValidation.cshtml"
   Write(Html.LabelFor(m => m.FirstName));

#line default
#line hidden
            EndContext();
            BeginContext(168, 10, true);
            WriteLiteral("\r\n        ");
            EndContext();
            BeginContext(179, 33, false);
#line 10 "C:\Users\lfmendez\Documents\Visual Studio 2017\Projects\HelloMVCWorld2\HelloMVCWorld2\Views\WebUser\SimpleValidation.cshtml"
   Write(Html.TextBoxFor(m => m.FirstName));

#line default
#line hidden
            EndContext();
            BeginContext(212, 10, true);
            WriteLiteral("\r\n        ");
            EndContext();
            BeginContext(223, 43, false);
#line 11 "C:\Users\lfmendez\Documents\Visual Studio 2017\Projects\HelloMVCWorld2\HelloMVCWorld2\Views\WebUser\SimpleValidation.cshtml"
   Write(Html.ValidationMessageFor(m => m.FirstName));

#line default
#line hidden
            EndContext();
            BeginContext(266, 14, true);
            WriteLiteral("\r\n    </div>\r\n");
            EndContext();
            BeginContext(282, 19, true);
            WriteLiteral("    <div>\r\n        ");
            EndContext();
            BeginContext(302, 30, false);
#line 15 "C:\Users\lfmendez\Documents\Visual Studio 2017\Projects\HelloMVCWorld2\HelloMVCWorld2\Views\WebUser\SimpleValidation.cshtml"
   Write(Html.LabelFor(m => m.LastName));

#line default
#line hidden
            EndContext();
            BeginContext(332, 10, true);
            WriteLiteral("\r\n        ");
            EndContext();
            BeginContext(343, 32, false);
#line 16 "C:\Users\lfmendez\Documents\Visual Studio 2017\Projects\HelloMVCWorld2\HelloMVCWorld2\Views\WebUser\SimpleValidation.cshtml"
   Write(Html.TextBoxFor(m => m.LastName));

#line default
#line hidden
            EndContext();
            BeginContext(375, 10, true);
            WriteLiteral("\r\n        ");
            EndContext();
            BeginContext(386, 42, false);
#line 17 "C:\Users\lfmendez\Documents\Visual Studio 2017\Projects\HelloMVCWorld2\HelloMVCWorld2\Views\WebUser\SimpleValidation.cshtml"
   Write(Html.ValidationMessageFor(m => m.LastName));

#line default
#line hidden
            EndContext();
            BeginContext(428, 14, true);
            WriteLiteral("\r\n    </div>\r\n");
            EndContext();
            BeginContext(444, 19, true);
            WriteLiteral("    <div>\r\n        ");
            EndContext();
            BeginContext(464, 33, false);
#line 21 "C:\Users\lfmendez\Documents\Visual Studio 2017\Projects\HelloMVCWorld2\HelloMVCWorld2\Views\WebUser\SimpleValidation.cshtml"
   Write(Html.LabelFor(m => m.MailAddress));

#line default
#line hidden
            EndContext();
            BeginContext(497, 10, true);
            WriteLiteral("\r\n        ");
            EndContext();
            BeginContext(508, 35, false);
#line 22 "C:\Users\lfmendez\Documents\Visual Studio 2017\Projects\HelloMVCWorld2\HelloMVCWorld2\Views\WebUser\SimpleValidation.cshtml"
   Write(Html.TextBoxFor(m => m.MailAddress));

#line default
#line hidden
            EndContext();
            BeginContext(543, 10, true);
            WriteLiteral("\r\n        ");
            EndContext();
            BeginContext(554, 45, false);
#line 23 "C:\Users\lfmendez\Documents\Visual Studio 2017\Projects\HelloMVCWorld2\HelloMVCWorld2\Views\WebUser\SimpleValidation.cshtml"
   Write(Html.ValidationMessageFor(m => m.MailAddress));

#line default
#line hidden
            EndContext();
            BeginContext(599, 14, true);
            WriteLiteral("\r\n    </div>\r\n");
            EndContext();
            BeginContext(617, 44, true);
            WriteLiteral("    <input type=\"submit\" value=\"Submit\" />\r\n");
            EndContext();
#line 28 "C:\Users\lfmendez\Documents\Visual Studio 2017\Projects\HelloMVCWorld2\HelloMVCWorld2\Views\WebUser\SimpleValidation.cshtml"
}

#line default
#line hidden
            BeginContext(664, 4, true);
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
