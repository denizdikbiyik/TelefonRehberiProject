#pragma checksum "C:\Users\Deniz\Documents\GitHub\TelefonRehberiProject\TelefonRehberi\Areas\Identity\Pages\Account\Manage\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "514a0e8ad204a92ce4c9da1c8b3c91a06f7eb981"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(TelefonRehberi.Areas.Identity.Pages.Account.Manage.Areas_Identity_Pages_Account_Manage__Layout), @"mvc.1.0.view", @"/Areas/Identity/Pages/Account/Manage/_Layout.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Identity/Pages/Account/Manage/_Layout.cshtml", typeof(TelefonRehberi.Areas.Identity.Pages.Account.Manage.Areas_Identity_Pages_Account_Manage__Layout))]
namespace TelefonRehberi.Areas.Identity.Pages.Account.Manage
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 2 "C:\Users\Deniz\Documents\GitHub\TelefonRehberiProject\TelefonRehberi\Areas\Identity\Pages\_ViewImports.cshtml"
using TelefonRehberi.Areas.Identity;

#line default
#line hidden
#line 3 "C:\Users\Deniz\Documents\GitHub\TelefonRehberiProject\TelefonRehberi\Areas\Identity\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 1 "C:\Users\Deniz\Documents\GitHub\TelefonRehberiProject\TelefonRehberi\Areas\Identity\Pages\Account\_ViewImports.cshtml"
using TelefonRehberi.Areas.Identity.Pages.Account;

#line default
#line hidden
#line 1 "C:\Users\Deniz\Documents\GitHub\TelefonRehberiProject\TelefonRehberi\Areas\Identity\Pages\Account\Manage\_ViewImports.cshtml"
using TelefonRehberi.Areas.Identity.Pages.Account.Manage;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"514a0e8ad204a92ce4c9da1c8b3c91a06f7eb981", @"/Areas/Identity/Pages/Account/Manage/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"02202810d6589137e4d50d79a7ff3070094dc359", @"/Areas/Identity/Pages/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"20ebf198309720c3a1c2a603876a86693f31bf7e", @"/Areas/Identity/Pages/Account/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7c9aa13fb66768a19a3a391f5d618ed6105e805a", @"/Areas/Identity/Pages/Account/Manage/_ViewImports.cshtml")]
    public class Areas_Identity_Pages_Account_Manage__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\Deniz\Documents\GitHub\TelefonRehberiProject\TelefonRehberi\Areas\Identity\Pages\Account\Manage\_Layout.cshtml"
  
    //Layout = "/Areas/Identity/Pages/_Layout.cshtml";
    Layout = "/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(109, 336, true);
            WriteLiteral(@"<link rel=""stylesheet"" href=""//cdnjs.cloudflare.com/ajax/libs/jodit/3.1.92/jodit.min.css"">
<script src=""//cdnjs.cloudflare.com/ajax/libs/jodit/3.1.92/jodit.min.js""></script>
<section class=""ab-info-main py-md-5"">
    <div class=""container py-md-3"">
        <h1>Hesabınızı Yönetin</h1>
        <div>
            <div class=""row"">
");
            EndContext();
            BeginContext(564, 60, true);
            WriteLiteral("                <div class=\"col-md-9\">\r\n                    ");
            EndContext();
            BeginContext(625, 12, false);
#line 16 "C:\Users\Deniz\Documents\GitHub\TelefonRehberiProject\TelefonRehberi\Areas\Identity\Pages\Account\Manage\_Layout.cshtml"
               Write(RenderBody());

#line default
#line hidden
            EndContext();
            BeginContext(637, 86, true);
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(741, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(748, 41, false);
#line 23 "C:\Users\Deniz\Documents\GitHub\TelefonRehberiProject\TelefonRehberi\Areas\Identity\Pages\Account\Manage\_Layout.cshtml"
Write(RenderSection("Scripts", required: false));

#line default
#line hidden
                EndContext();
                BeginContext(789, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
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
