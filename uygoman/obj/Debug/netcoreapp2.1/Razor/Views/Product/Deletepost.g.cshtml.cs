#pragma checksum "C:\Users\zahid\Desktop\clean\WEBSITE_DEV\uygoman\uygoman\uygoman\Views\Product\Deletepost.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b88f908747701b4c44aacb583d26edc18f36b6aa"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Deletepost), @"mvc.1.0.view", @"/Views/Product/Deletepost.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Product/Deletepost.cshtml", typeof(AspNetCore.Views_Product_Deletepost))]
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
#line 1 "C:\Users\zahid\Desktop\clean\WEBSITE_DEV\uygoman\uygoman\uygoman\Views\_ViewImports.cshtml"
using uygoman;

#line default
#line hidden
#line 2 "C:\Users\zahid\Desktop\clean\WEBSITE_DEV\uygoman\uygoman\uygoman\Views\_ViewImports.cshtml"
using uygoman.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b88f908747701b4c44aacb583d26edc18f36b6aa", @"/Views/Product/Deletepost.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9137ae19b85921cada872a605cb459b28a9f923d", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_Deletepost : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<uygoman.Models.CrKey>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(29, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\zahid\Desktop\clean\WEBSITE_DEV\uygoman\uygoman\uygoman\Views\Product\Deletepost.cshtml"
  
    ViewData["Title"] = "Deletepost";

#line default
#line hidden
            BeginContext(77, 192, true);
            WriteLiteral("\r\n\r\n\r\n<br />\r\n\r\n<br />\r\n\r\n<div class=\"text-center\">\r\n    <h1>\r\n        Please ensure that keys on behalf of the product You want to delete or not and check the KEYS tab:\r\n        <br />Keys:: ");
            EndContext();
            BeginContext(270, 10, false);
#line 16 "C:\Users\zahid\Desktop\clean\WEBSITE_DEV\uygoman\uygoman\uygoman\Views\Product\Deletepost.cshtml"
                Write(Model.Keys);

#line default
#line hidden
            EndContext();
            BeginContext(280, 33, true);
            WriteLiteral("\r\n    </h1> \r\n\r\n\r\n   \r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<uygoman.Models.CrKey> Html { get; private set; }
    }
}
#pragma warning restore 1591
