#pragma checksum "C:\Users\User\Desktop\Back-End Project\Back-End-Project\Allup\Views\Shared\Components\Footer\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7758fea6e17e33fddfd7efae14489924e291ccae"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Footer_Default), @"mvc.1.0.view", @"/Views/Shared/Components/Footer/Default.cshtml")]
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
#line 1 "C:\Users\User\Desktop\Back-End Project\Back-End-Project\Allup\Views\_ViewImports.cshtml"
using Allup;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User\Desktop\Back-End Project\Back-End-Project\Allup\Views\_ViewImports.cshtml"
using Allup.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\User\Desktop\Back-End Project\Back-End-Project\Allup\Views\_ViewImports.cshtml"
using Allup.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\User\Desktop\Back-End Project\Back-End-Project\Allup\Views\_ViewImports.cshtml"
using Allup.Helpers;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7758fea6e17e33fddfd7efae14489924e291ccae", @"/Views/Shared/Components/Footer/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4acf5e4c7b3c697d982d9828277632184e3e171d", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_Footer_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Bio>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/images/payment.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("payment"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"    
<section class=""newsletter-area pt-100 pb-100 bg_cover"" style=""background-image: url(/assets/images/bg-newletter.jpg)"">
    <div class=""container"">
        <div class=""row justify-content-end"">
            <div class=""col-lg-8"">
                <div class=""newsletter-content"">
                    <h2 class=""newsletter-title"">Subscribe our newsletter</h2>
                    <p>allup is a powerful eCommerce HTML Template</p>

                    <div class=""newsletter-forn"">
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7758fea6e17e33fddfd7efae14489924e291ccae5455", async() => {
                WriteLiteral("\r\n                            <input type=\"text\" placeholder=\"Your Email address\">\r\n                            <button class=\"main-btn\">Subscribe</button>\r\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                    </div>
                </div> <!-- newsletter content -->
            </div>
        </div> <!-- row -->
    </div> <!-- container -->
</section>

<section class=""footer-area bg_cover"" style=""background-image: url(/assets/images/bg-footer.jpg)"">
        <div class=""footer-widget pt-30 pb-70"">
            <div class=""container"">
                <div class=""row"">
                    <div class=""col-lg-4"">
                        <div class=""footer-contact mt-50"">
                            <h4 class=""footer-title"">Contact Details</h4>
                            <ul>
                                <li><i class=""fas fa-map-marker-alt""></i> ");
#nullable restore
#line 31 "C:\Users\User\Desktop\Back-End Project\Back-End-Project\Allup\Views\Shared\Components\Footer\Default.cshtml"
                                                                     Write(Model.Location);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                                <li><i class=\"fas fa-phone\"></i> <a href=\"tell:123-456-789\">");
#nullable restore
#line 32 "C:\Users\User\Desktop\Back-End Project\Back-End-Project\Allup\Views\Shared\Components\Footer\Default.cshtml"
                                                                                       Write(Model.Contact);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n                                <li><i class=\"fas fa-envelope\"></i><a href=\"mailto://email@yourwebsitename.com\">");
#nullable restore
#line 33 "C:\Users\User\Desktop\Back-End Project\Back-End-Project\Allup\Views\Shared\Components\Footer\Default.cshtml"
                                                                                                           Write(Model.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n                                <li><i class=\"far fa-clock\"></i> ");
#nullable restore
#line 34 "C:\Users\User\Desktop\Back-End Project\Back-End-Project\Allup\Views\Shared\Components\Footer\Default.cshtml"
                                                            Write(Model.WorkTime);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</li>
                            </ul>
                        </div> <!-- footer contact -->
                    </div>
                    <div class=""col-lg-8"">
                        <div class=""footer-link-wrapper d-flex flex-wrap justify-content-between"">
                            <div class=""footer-link mt-50"">
                                <h4 class=""footer-title"">Information</h4>

                                <ul class=""link"">
                                    <li><a href=""#"">Delivery</a></li>
                                    <li><a href=""#"">Legal Notice</a></li>
                                    <li><a href=""about.html"">About us</a></li>
                                    <li><a href=""#"">Secure payment</a></li>
                                    <li><a href=""contact.html"">Contact us</a></li>
                                </ul>
                            </div> <!-- footer link -->
                            <div class=""footer-link mt-50"">
                     ");
            WriteLiteral(@"           <h4 class=""footer-title"">Customer</h4>

                                <ul class=""link"">
                                    <li><a href=""shop-4-column.html"">Prices drop</a></li>
                                    <li><a href=""shop-4-column.html"">New Product</a></li>
                                    <li><a href=""shop-3-column.html"">Best Sales</a></li>
                                    <li><a href=""#"">Sitemap</a></li>
                                    <li><a href=""login.html"">Login</a></li>
                                </ul>
                            </div> <!-- footer link -->
                            <div class=""footer-link mt-50"">
                                <h4 class=""footer-title"">About Us</h4>

                                <ul class=""link"">
                                    <li><a href=""#"">About Our Shop</a></li>
                                    <li><a href=""#"">Secure Shopping </a></li>
                                    <li><a href=""#"">Delivery in");
            WriteLiteral(@"fomation </a></li>
                                    <li><a href=""#"">Store Locations </a></li>
                                    <li><a href=""#"">Affiliates </a></li>
                                </ul>
                            </div> <!-- footer link -->
                            <div class=""footer-link mt-50"">
                                <h4 class=""footer-title"">My account</h4>

                                <ul class=""link"">
                                    <li><a href=""#"">Personal info</a></li>
                                    <li><a href=""#"">Order</a></li>
                                    <li><a href=""#"">Credit Slips</a></li>
                                    <li><a href=""#"">Address</a></li>
                                </ul>
                            </div> <!-- footer link -->
                        </div> <!-- footer link wrapper -->
                    </div>
                </div> <!-- row -->
            </div> <!-- container -->
        </div> <!");
            WriteLiteral(@"-- footer widget -->

        <div class=""footer-copyright"">
            <div class=""container"">
                <div class=""footer-copyright-payment text-center d-lg-flex justify-content-between align-items-center"">
                    <div class=""copyright-text"">
                        <p>Copyright 2022 &copy; <a href=""https://facebook.com/"">Farid Baliyev</a></p>
                    </div>
                    <div class=""payment"">
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "7758fea6e17e33fddfd7efae14489924e291ccae12984", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </div>\r\n                </div> <!-- footer copyright payment -->\r\n            </div> <!-- container -->\r\n        </div> <!-- footer copyright -->\r\n    </section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Bio> Html { get; private set; }
    }
}
#pragma warning restore 1591
