#pragma checksum "C:\Users\zahid\Desktop\clean\WEBSITE_DEV\uygoman\uygoman\uygoman\Views\Admin\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d17fb92bcc256a684abe20778ef09ae4b20dd18b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Index), @"mvc.1.0.view", @"/Views/Admin/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Admin/Index.cshtml", typeof(AspNetCore.Views_Admin_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d17fb92bcc256a684abe20778ef09ae4b20dd18b", @"/Views/Admin/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9137ae19b85921cada872a605cb459b28a9f923d", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<uygoman.Models.Admin>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(42, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(66, 222, true);
            WriteLiteral("<br /><br />\r\n\r\n\r\n<div class=\"container p-3\">\r\n    <div class=\"text-center row pt-4\">\r\n        <div class=\"col-md-12\">\r\n            <h2 class=\"text-primary\">Admin List</h2>\r\n        </div>\r\n        <div class=\"col-md-6\">\r\n");
            EndContext();
            BeginContext(421, 48, true);
            WriteLiteral("        </div>\r\n    </div>\r\n\r\n    <br /><br />\r\n");
            EndContext();
#line 21 "C:\Users\zahid\Desktop\clean\WEBSITE_DEV\uygoman\uygoman\uygoman\Views\Admin\Index.cshtml"
     if (Model.Count() > 0)
    {

#line default
#line hidden
            BeginContext(505, 391, true);
            WriteLiteral(@"        <table class=""table table-bordered table-striped"" style=""width100%"">
            <thead>
                <tr>
                    <th>
                        User ID
                    </th>
                    <th>
                        Password
                    </th>
                    <th></th>
                </tr>
            </thead>
            <tbody>
");
            EndContext();
#line 36 "C:\Users\zahid\Desktop\clean\WEBSITE_DEV\uygoman\uygoman\uygoman\Views\Admin\Index.cshtml"
                 foreach (var obj in Model)
                {

#line default
#line hidden
            BeginContext(960, 66, true);
            WriteLiteral("                    <tr>\r\n                        <td width=\"50%\">");
            EndContext();
            BeginContext(1027, 10, false);
#line 39 "C:\Users\zahid\Desktop\clean\WEBSITE_DEV\uygoman\uygoman\uygoman\Views\Admin\Index.cshtml"
                                   Write(obj.UserID);

#line default
#line hidden
            EndContext();
            BeginContext(1037, 47, true);
            WriteLiteral("</td>\r\n                        <td width=\"30%\">");
            EndContext();
            BeginContext(1085, 12, false);
#line 40 "C:\Users\zahid\Desktop\clean\WEBSITE_DEV\uygoman\uygoman\uygoman\Views\Admin\Index.cshtml"
                                   Write(obj.Password);

#line default
#line hidden
            EndContext();
            BeginContext(1097, 155, true);
            WriteLiteral("</td>\r\n                        <td class=\"text-center\">\r\n                            <div class=\"btn-group\" role=\"group\">\r\n                                ");
            EndContext();
            BeginContext(1252, 174, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d2fb9b75655b41e787c74c1e12d23595", async() => {
                BeginContext(1346, 76, true);
                WriteLiteral("\r\n                                    Edit\r\n                                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-idnum", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 43 "C:\Users\zahid\Desktop\clean\WEBSITE_DEV\uygoman\uygoman\uygoman\Views\Admin\Index.cshtml"
                                                               WriteLiteral(obj.ID);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["idnum"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-idnum", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["idnum"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1426, 34, true);
            WriteLiteral("\r\n                                ");
            EndContext();
            BeginContext(1460, 177, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2f036f8b2bdf438d880c094b5e77c0f6", async() => {
                BeginContext(1555, 78, true);
                WriteLiteral("\r\n                                    Delete\r\n                                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-idnum", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 46 "C:\Users\zahid\Desktop\clean\WEBSITE_DEV\uygoman\uygoman\uygoman\Views\Admin\Index.cshtml"
                                                               WriteLiteral(obj.ID);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["idnum"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-idnum", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["idnum"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1637, 98, true);
            WriteLiteral("\r\n                            </div>\r\n\r\n                        </td>\r\n                    </tr>\r\n");
            EndContext();
#line 53 "C:\Users\zahid\Desktop\clean\WEBSITE_DEV\uygoman\uygoman\uygoman\Views\Admin\Index.cshtml"
                }

#line default
#line hidden
            BeginContext(1754, 42, true);
            WriteLiteral("            </tbody>\r\n\r\n        </table>\r\n");
            EndContext();
#line 57 "C:\Users\zahid\Desktop\clean\WEBSITE_DEV\uygoman\uygoman\uygoman\Views\Admin\Index.cshtml"
    }
    else
    {

#line default
#line hidden
            BeginContext(1820, 28, true);
            WriteLiteral("        <p>No category</p>\r\n");
            EndContext();
#line 61 "C:\Users\zahid\Desktop\clean\WEBSITE_DEV\uygoman\uygoman\uygoman\Views\Admin\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(1855, 16, true);
            WriteLiteral("\r\n</div>\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<uygoman.Models.Admin>> Html { get; private set; }
    }
}
#pragma warning restore 1591
