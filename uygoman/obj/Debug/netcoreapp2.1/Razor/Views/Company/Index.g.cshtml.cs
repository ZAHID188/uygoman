#pragma checksum "C:\Users\zahid\Desktop\clean\WEBSITE_DEV\uygoman\uygoman\uygoman\Views\Company\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "009c76043e1ceba197ddb5c0d0f889c2947239fe"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Company_Index), @"mvc.1.0.view", @"/Views/Company/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Company/Index.cshtml", typeof(AspNetCore.Views_Company_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"009c76043e1ceba197ddb5c0d0f889c2947239fe", @"/Views/Company/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9137ae19b85921cada872a605cb459b28a9f923d", @"/Views/_ViewImports.cshtml")]
    public class Views_Company_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<uygoman.Models.CompanyReg>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Company", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(9, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(60, 38, true);
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n<br /><br />\r\n\r\n\r\n\r\n\r\n");
            EndContext();
            BeginContext(2283, 418, true);
            WriteLiteral(@"


      <section class=""content"">
          <div class=""container-fluid"">
              <div class=""row"">
                  <div class=""col-12"">
                      <div class=""card"">
                          <div class=""card-header"">
                              <h3 class=""card-title"">Company Informations</h3>
                              <div class=""card-tools"">
                                  ");
            EndContext();
            BeginContext(2701, 743, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4131b69df3ff41c38291fbc758733a0c", async() => {
                BeginContext(2708, 237, true);
                WriteLiteral("\r\n                                      <div class=\"input-group input-group-sm\" style=\"width: 150px;\">\r\n                                          <input type=\"text\" class=\"form-control float-right\" placeholder=\"Search company Name/Email\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 2945, "\"", 2980, 1);
#line 100 "C:\Users\zahid\Desktop\clean\WEBSITE_DEV\uygoman\uygoman\uygoman\Views\Company\Index.cshtml"
WriteAttributeValue("", 2953, ViewData["CompanyDetails"], 2953, 27, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2981, 456, true);
                WriteLiteral(@"name=""search""  >
                                          <div class=""input-group-append"">
                                              <button type=""submit"" class=""btn btn-default"">
                                                  <i class=""fas fa-search""></i>
                                              </button>
                                          </div>
                                      </div>
                                  ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3444, 198, true);
            WriteLiteral("\r\n                              </div>\r\n                          </div>\r\n                          <!-- /.card-header -->\r\n                          <div class=\"card-body table-responsive p-0\">\r\n\r\n");
            EndContext();
#line 113 "C:\Users\zahid\Desktop\clean\WEBSITE_DEV\uygoman\uygoman\uygoman\Views\Company\Index.cshtml"
                               if (Model.Count() > 0)
                              {

#line default
#line hidden
            BeginContext(3730, 949, true);
            WriteLiteral(@"                                  <table class=""table table-bordered  table-striped "" style=""width100%"">
                                      <thead>
                                          <tr>

                                              <th>Company Name</th>
                                              <th>Company Arabic name</th>
                                              <th>Company Brand name</th>
                                              <th>Email</th>
                                              <th>Phone number</th>
                                              <th>Contact person</th>
                                              <th>Upload Documents</th>
                                              <th>

                                              </th>
                                          </tr>
                                      </thead>
                                      <tbody>
");
            EndContext();
#line 132 "C:\Users\zahid\Desktop\clean\WEBSITE_DEV\uygoman\uygoman\uygoman\Views\Company\Index.cshtml"
                                           foreach (var obj in Model)
                                          {

#line default
#line hidden
            BeginContext(4795, 106, true);
            WriteLiteral("                                              <tr>\r\n                                                  <td>");
            EndContext();
            BeginContext(4902, 11, false);
#line 135 "C:\Users\zahid\Desktop\clean\WEBSITE_DEV\uygoman\uygoman\uygoman\Views\Company\Index.cshtml"
                                                 Write(obj.CmpName);

#line default
#line hidden
            EndContext();
            BeginContext(4913, 61, true);
            WriteLiteral("</td>\r\n                                                  <td>");
            EndContext();
            BeginContext(4975, 17, false);
#line 136 "C:\Users\zahid\Desktop\clean\WEBSITE_DEV\uygoman\uygoman\uygoman\Views\Company\Index.cshtml"
                                                 Write(obj.CmpArabicName);

#line default
#line hidden
            EndContext();
            BeginContext(4992, 61, true);
            WriteLiteral("</td>\r\n                                                  <td>");
            EndContext();
            BeginContext(5054, 16, false);
#line 137 "C:\Users\zahid\Desktop\clean\WEBSITE_DEV\uygoman\uygoman\uygoman\Views\Company\Index.cshtml"
                                                 Write(obj.CmpBrandName);

#line default
#line hidden
            EndContext();
            BeginContext(5070, 61, true);
            WriteLiteral("</td>\r\n                                                  <td>");
            EndContext();
            BeginContext(5132, 9, false);
#line 138 "C:\Users\zahid\Desktop\clean\WEBSITE_DEV\uygoman\uygoman\uygoman\Views\Company\Index.cshtml"
                                                 Write(obj.Email);

#line default
#line hidden
            EndContext();
            BeginContext(5141, 61, true);
            WriteLiteral("</td>\r\n                                                  <td>");
            EndContext();
            BeginContext(5203, 9, false);
#line 139 "C:\Users\zahid\Desktop\clean\WEBSITE_DEV\uygoman\uygoman\uygoman\Views\Company\Index.cshtml"
                                                 Write(obj.Phone);

#line default
#line hidden
            EndContext();
            BeginContext(5212, 61, true);
            WriteLiteral("</td>\r\n                                                  <td>");
            EndContext();
            BeginContext(5274, 17, false);
#line 140 "C:\Users\zahid\Desktop\clean\WEBSITE_DEV\uygoman\uygoman\uygoman\Views\Company\Index.cshtml"
                                                 Write(obj.ContactPerson);

#line default
#line hidden
            EndContext();
            BeginContext(5291, 61, true);
            WriteLiteral("</td>\r\n                                                  <td>");
            EndContext();
            BeginContext(5353, 10, false);
#line 141 "C:\Users\zahid\Desktop\clean\WEBSITE_DEV\uygoman\uygoman\uygoman\Views\Company\Index.cshtml"
                                                 Write(obj.Upload);

#line default
#line hidden
            EndContext();
            BeginContext(5363, 237, true);
            WriteLiteral("</td>\r\n\r\n\r\n                                                  <td class=\"text-center\">\r\n                                                      <div class=\"btn-group\" role=\"group\">\r\n                                                          ");
            EndContext();
            BeginContext(5600, 228, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c2a333a67d4d4d358b074778368aa022", async() => {
                BeginContext(5696, 128, true);
                WriteLiteral("\r\n                                                              Edit\r\n                                                          ");
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
#line 146 "C:\Users\zahid\Desktop\clean\WEBSITE_DEV\uygoman\uygoman\uygoman\Views\Company\Index.cshtml"
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
            BeginContext(5828, 60, true);
            WriteLiteral("\r\n                                                          ");
            EndContext();
            BeginContext(5888, 231, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "86cf8ca4e1ea422b8c41c145a784cb8a", async() => {
                BeginContext(5985, 130, true);
                WriteLiteral("\r\n                                                              Delete\r\n                                                          ");
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
#line 149 "C:\Users\zahid\Desktop\clean\WEBSITE_DEV\uygoman\uygoman\uygoman\Views\Company\Index.cshtml"
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
            BeginContext(6119, 176, true);
            WriteLiteral("\r\n                                                      </div>\r\n\r\n                                                  </td>\r\n                                              </tr>\r\n");
            EndContext();
#line 156 "C:\Users\zahid\Desktop\clean\WEBSITE_DEV\uygoman\uygoman\uygoman\Views\Company\Index.cshtml"
                                          }

#line default
#line hidden
            BeginContext(6340, 92, true);
            WriteLiteral("                                      </tbody>\r\n                                  </table>\r\n");
            EndContext();
#line 159 "C:\Users\zahid\Desktop\clean\WEBSITE_DEV\uygoman\uygoman\uygoman\Views\Company\Index.cshtml"
                              }
                              else
                              {

#line default
#line hidden
            BeginContext(6534, 54, true);
            WriteLiteral("                                  <p>No category</p>\r\n");
            EndContext();
#line 163 "C:\Users\zahid\Desktop\clean\WEBSITE_DEV\uygoman\uygoman\uygoman\Views\Company\Index.cshtml"
                              }

#line default
#line hidden
            BeginContext(6621, 237, true);
            WriteLiteral("                          </div>\r\n                          <!-- /.card-body -->\r\n                      </div>\r\n                      <!-- /.card -->\r\n                  </div>\r\n              </div>\r\n          </div>\r\n      </section>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<uygoman.Models.CompanyReg>> Html { get; private set; }
    }
}
#pragma warning restore 1591
