#pragma checksum "C:\Users\bgonzalez\Desktop\ModusCreateTest\ModusCreateNewsFeed\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3bc00ee96a6b96c972611d41df3c64e2dafb3f13"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "C:\Users\bgonzalez\Desktop\ModusCreateTest\ModusCreateNewsFeed\Views\_ViewImports.cshtml"
using ModusCreateNewsFeed;

#line default
#line hidden
#line 2 "C:\Users\bgonzalez\Desktop\ModusCreateTest\ModusCreateNewsFeed\Views\_ViewImports.cshtml"
using ModusCreateNewsFeed.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3bc00ee96a6b96c972611d41df3c64e2dafb3f13", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"329c4f8b8f32df9b94d5bb4f041f9bde5c8ef1f4", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "0", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("selected", new global::Microsoft.AspNetCore.Html.HtmlString("selected"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\bgonzalez\Desktop\ModusCreateTest\ModusCreateNewsFeed\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "BryanGonzalezNewsFeedApp";

#line default
#line hidden
            BeginContext(60, 54, true);
            WriteLiteral("\r\n<br />\r\n<h2>News Feed App</h2>\r\n<hr />\r\n<br />\r\n\r\n\r\n");
            EndContext();
#line 11 "C:\Users\bgonzalez\Desktop\ModusCreateTest\ModusCreateNewsFeed\Views\Home\Index.cshtml"
 using (Html.BeginForm("Index", "Home", new { searchString = 0 }, FormMethod.Post))
{

#line default
#line hidden
            BeginContext(202, 251, true);
            WriteLiteral("    <fieldset>\r\n        <p>\r\n            <div class=\"form-group\">\r\n                <label for =\"selectedCategoryId\">Category</label>\r\n                <select class=\"form-control\" id=\"selectedCategoryId\" name=\"selectedCategoryId\">\r\n                    ");
            EndContext();
            BeginContext(453, 30, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fcf98d6fc8fb4da8a15b475d23fe4f2d", async() => {
                BeginContext(471, 3, true);
                WriteLiteral("All");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(483, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 19 "C:\Users\bgonzalez\Desktop\ModusCreateTest\ModusCreateNewsFeed\Views\Home\Index.cshtml"
                     foreach (var item in ViewBag.Categories)
                    {

                        if (item.categoryId.Equals(ViewBag.selectedCategoryId))
                        {

#line default
#line hidden
            BeginContext(681, 28, true);
            WriteLiteral("                            ");
            EndContext();
            BeginContext(709, 80, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d84b98ca4b584266a471a596748dd22f", async() => {
                BeginContext(763, 17, false);
#line 24 "C:\Users\bgonzalez\Desktop\ModusCreateTest\ModusCreateNewsFeed\Views\Home\Index.cshtml"
                                                                            Write(item.categoryName);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            BeginWriteTagHelperAttribute();
#line 24 "C:\Users\bgonzalez\Desktop\ModusCreateTest\ModusCreateNewsFeed\Views\Home\Index.cshtml"
                                                   WriteLiteral(item.categoryId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(789, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 25 "C:\Users\bgonzalez\Desktop\ModusCreateTest\ModusCreateNewsFeed\Views\Home\Index.cshtml"
                        }
                        else
                        {

#line default
#line hidden
            BeginContext(875, 28, true);
            WriteLiteral("                            ");
            EndContext();
            BeginContext(903, 60, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9fec6307f6b64b649bec6f52a5a32b46", async() => {
                BeginContext(937, 17, false);
#line 28 "C:\Users\bgonzalez\Desktop\ModusCreateTest\ModusCreateNewsFeed\Views\Home\Index.cshtml"
                                                        Write(item.categoryName);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
#line 28 "C:\Users\bgonzalez\Desktop\ModusCreateTest\ModusCreateNewsFeed\Views\Home\Index.cshtml"
                               WriteLiteral(item.categoryId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(963, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 29 "C:\Users\bgonzalez\Desktop\ModusCreateTest\ModusCreateNewsFeed\Views\Home\Index.cshtml"
                        }

                    }

#line default
#line hidden
            BeginContext(1017, 78, true);
            WriteLiteral("                </select>\r\n            </div>\r\n        </p>\r\n    </fieldset>\r\n");
            EndContext();
            BeginContext(1097, 109, true);
            WriteLiteral("    <input type=\"text\" name=\"searchString\" placeholder=\"Search...\" class=\"form-control\" style=\"min-width:80%\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1206, "\"", 1229, 1);
#line 37 "C:\Users\bgonzalez\Desktop\ModusCreateTest\ModusCreateNewsFeed\Views\Home\Index.cshtml"
WriteAttributeValue("", 1214, ViewBag.Search, 1214, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1230, 129, true);
            WriteLiteral("/>\r\n    <br />\r\n    <button type=\"submit\" class=\"btn btn-success\" style=\"min-width:20%\">Search</button>\r\n    <br />\r\n    <br />\r\n");
            EndContext();
#line 42 "C:\Users\bgonzalez\Desktop\ModusCreateTest\ModusCreateNewsFeed\Views\Home\Index.cshtml"
}

#line default
#line hidden
            BeginContext(1362, 197, true);
            WriteLiteral("\r\n\r\n<table class=\"table table-hover\">\r\n    <thead>\r\n        <tr>\r\n            <th>Date</th>\r\n            <th>Title</th>\r\n            <th>Description</th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 54 "C:\Users\bgonzalez\Desktop\ModusCreateTest\ModusCreateNewsFeed\Views\Home\Index.cshtml"
         if (ViewBag.RSSFeed != null)
        {
            foreach (var item in ViewBag.RSSFeed)
            {

#line default
#line hidden
            BeginContext(1675, 46, true);
            WriteLiteral("                <tr>\r\n                    <td>");
            EndContext();
            BeginContext(1722, 9, false);
#line 59 "C:\Users\bgonzalez\Desktop\ModusCreateTest\ModusCreateNewsFeed\Views\Home\Index.cshtml"
                   Write(item.Date);

#line default
#line hidden
            EndContext();
            BeginContext(1731, 33, true);
            WriteLiteral("</td>\r\n                    <td><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1764, "\"", 1780, 1);
#line 60 "C:\Users\bgonzalez\Desktop\ModusCreateTest\ModusCreateNewsFeed\Views\Home\Index.cshtml"
WriteAttributeValue("", 1771, item.URL, 1771, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1781, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(1783, 10, false);
#line 60 "C:\Users\bgonzalez\Desktop\ModusCreateTest\ModusCreateNewsFeed\Views\Home\Index.cshtml"
                                       Write(item.Title);

#line default
#line hidden
            EndContext();
            BeginContext(1793, 38, true);
            WriteLiteral("...</a></td>\r\n                    <td>");
            EndContext();
            BeginContext(1832, 26, false);
#line 61 "C:\Users\bgonzalez\Desktop\ModusCreateTest\ModusCreateNewsFeed\Views\Home\Index.cshtml"
                   Write(Html.Raw(item.Description));

#line default
#line hidden
            EndContext();
            BeginContext(1858, 30, true);
            WriteLiteral("</td>\r\n                </tr>\r\n");
            EndContext();
#line 63 "C:\Users\bgonzalez\Desktop\ModusCreateTest\ModusCreateNewsFeed\Views\Home\Index.cshtml"

            }
        }

#line default
#line hidden
            BeginContext(1916, 24, true);
            WriteLiteral("    </tbody>\r\n</table>  ");
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