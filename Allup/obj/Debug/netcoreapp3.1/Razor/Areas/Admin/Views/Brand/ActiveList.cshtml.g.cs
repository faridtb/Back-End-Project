#pragma checksum "C:\Users\User\Desktop\Back-End Project\Back-End-Project\Allup\Areas\Admin\Views\Brand\ActiveList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8a33efb7d817ae6c0a04e9202c6d58274404de3d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Brand_ActiveList), @"mvc.1.0.view", @"/Areas/Admin/Views/Brand/ActiveList.cshtml")]
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
#line 1 "C:\Users\User\Desktop\Back-End Project\Back-End-Project\Allup\Areas\Admin\Views\_ViewImports.cshtml"
using Allup;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User\Desktop\Back-End Project\Back-End-Project\Allup\Areas\Admin\Views\_ViewImports.cshtml"
using Allup.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\User\Desktop\Back-End Project\Back-End-Project\Allup\Areas\Admin\Views\_ViewImports.cshtml"
using Allup.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\User\Desktop\Back-End Project\Back-End-Project\Allup\Areas\Admin\Views\_ViewImports.cshtml"
using Allup.Helpers;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8a33efb7d817ae6c0a04e9202c6d58274404de3d", @"/Areas/Admin/Views/Brand/ActiveList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4acf5e4c7b3c697d982d9828277632184e3e171d", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Brand_ActiveList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Brand>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("100"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("100"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("border-radius:50%; border:3px solid #5A54DA"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("dropdown-item"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "brand", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "update", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<main role=""main"" class=""main-content"">
    <div class=""container-fluid"">
        <div class=""row justify-content-center"">
            <div class=""col-12"">
                <h2 class=""mb-2 page-title"" style=""text-align :center"">Active Brands</h2>
                <div class=""row my-4"">
                    <!-- Small table -->
                    <div class=""col-md-12"">
                        <div class=""card shadow"">
                            <div class=""card-body"">
                                <!-- table -->
                                <table class=""table datatables"" id=""dataTable-1"">
                                    <thead>
                                        <tr>
                                            <th>ID</th>
                                            <th>Name</th>
                                            <th>Photo</th>
                                            <th>Created Date</th>
                                            <th>Updated Date</th>
          ");
            WriteLiteral("                                  <th>Action</th>\r\n                                        </tr>\r\n                                    </thead>\r\n                                    <tbody>\r\n");
#nullable restore
#line 25 "C:\Users\User\Desktop\Back-End Project\Back-End-Project\Allup\Areas\Admin\Views\Brand\ActiveList.cshtml"
                                         foreach (var item in Model)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <tr>\r\n                                                <td>");
#nullable restore
#line 28 "C:\Users\User\Desktop\Back-End Project\Back-End-Project\Allup\Areas\Admin\Views\Brand\ActiveList.cshtml"
                                               Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                <td>");
#nullable restore
#line 29 "C:\Users\User\Desktop\Back-End Project\Back-End-Project\Allup\Areas\Admin\Views\Brand\ActiveList.cshtml"
                                               Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                <td>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "8a33efb7d817ae6c0a04e9202c6d58274404de3d8491", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1619, "~/assets/", 1619, 9, true);
#nullable restore
#line 30 "C:\Users\User\Desktop\Back-End Project\Back-End-Project\Allup\Areas\Admin\Views\Brand\ActiveList.cshtml"
AddHtmlAttributeValue("", 1628, item.ImageUrl, 1628, 14, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</td>\r\n                                                <td style=\"color:greenyellow\">");
#nullable restore
#line 31 "C:\Users\User\Desktop\Back-End Project\Back-End-Project\Allup\Areas\Admin\Views\Brand\ActiveList.cshtml"
                                                                         Write(item.CreatedAt.Value.Date.ToLongDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 32 "C:\Users\User\Desktop\Back-End Project\Back-End-Project\Allup\Areas\Admin\Views\Brand\ActiveList.cshtml"
                                                 if (@item.UptadetAt != null)
                                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    <td style=\"color:yellow\">");
#nullable restore
#line 34 "C:\Users\User\Desktop\Back-End Project\Back-End-Project\Allup\Areas\Admin\Views\Brand\ActiveList.cshtml"
                                                                        Write(item.UptadetAt.Value.Date.ToLongDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 35 "C:\Users\User\Desktop\Back-End Project\Back-End-Project\Allup\Areas\Admin\Views\Brand\ActiveList.cshtml"
                                                }
                                                else
                                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    <td style=\"color:dodgerblue\">Empty</td>\r\n");
#nullable restore
#line 39 "C:\Users\User\Desktop\Back-End Project\Back-End-Project\Allup\Areas\Admin\Views\Brand\ActiveList.cshtml"
                                                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                                <td>
                                                    <button class=""btn btn-sm dropdown-toggle more-horizontal"" type=""button"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
                                                        <span class=""text-muted sr-only"">Action</span>
                                                    </button>
                                                    <div class=""dropdown-menu dropdown-menu-right"">
                                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8a33efb7d817ae6c0a04e9202c6d58274404de3d12781", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 45 "C:\Users\User\Desktop\Back-End Project\Back-End-Project\Allup\Areas\Admin\Views\Brand\ActiveList.cshtml"
                                                                                                                              WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 46 "C:\Users\User\Desktop\Back-End Project\Back-End-Project\Allup\Areas\Admin\Views\Brand\ActiveList.cshtml"
                                                         if (item.IsDeleted == false)
                                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8a33efb7d817ae6c0a04e9202c6d58274404de3d15751", async() => {
                WriteLiteral("Delete");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 48 "C:\Users\User\Desktop\Back-End Project\Back-End-Project\Allup\Areas\Admin\Views\Brand\ActiveList.cshtml"
                                                                                                                                  WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 49 "C:\Users\User\Desktop\Back-End Project\Back-End-Project\Allup\Areas\Admin\Views\Brand\ActiveList.cshtml"
                                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    </div>\r\n                                                </td>\r\n                                            </tr>\r\n");
#nullable restore
#line 53 "C:\Users\User\Desktop\Back-End Project\Back-End-Project\Allup\Areas\Admin\Views\Brand\ActiveList.cshtml"
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                    </tbody>
                                </table>
                            </div>
                        </div>
                    </div> <!-- simple table -->
                </div> <!-- end section -->
            </div> <!-- .col-12 -->
        </div> <!-- .row -->
    </div> <!-- .container-fluid -->
</main> <!-- main -->

");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Brand>> Html { get; private set; }
    }
}
#pragma warning restore 1591
