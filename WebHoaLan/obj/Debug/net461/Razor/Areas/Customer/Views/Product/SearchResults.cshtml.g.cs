#pragma checksum "C:\Users\vinh\source\repos\WebHoaLan\WebHoaLan\Areas\Customer\Views\Product\SearchResults.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "b1e8c9773b6d8cf82e88e77026f6e95dbd45d3f8787331cf5009c8a61c6f9e04"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Customer_Views_Product_SearchResults), @"mvc.1.0.view", @"/Areas/Customer/Views/Product/SearchResults.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Customer/Views/Product/SearchResults.cshtml", typeof(AspNetCore.Areas_Customer_Views_Product_SearchResults))]
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
#line 1 "C:\Users\vinh\source\repos\WebHoaLan\WebHoaLan\Areas\Customer\Views\_ViewImports.cshtml"
using WebHoaLan;

#line default
#line hidden
#line 2 "C:\Users\vinh\source\repos\WebHoaLan\WebHoaLan\Areas\Customer\Views\_ViewImports.cshtml"
using WebHoaLan.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"b1e8c9773b6d8cf82e88e77026f6e95dbd45d3f8787331cf5009c8a61c6f9e04", @"/Areas/Customer/Views/Product/SearchResults.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"43870735ca31a5966e96e47601c236a01516864226e306a22ffffe2d7eb7d1f2", @"/Areas/Customer/Views/_ViewImports.cshtml")]
    public class Areas_Customer_Views_Product_SearchResults : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Products>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Card Image"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("card-img-top"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("height: 300px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Detail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success pull-right btn-outline-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(0, 51, true);
            WriteLiteral("<!-- Trong Views/Product/SearchResults.cshtml -->\r\n");
            EndContext();
            BeginContext(74, 31, true);
            WriteLiteral("\r\n<h2>Kết Quả Tìm Kiếm</h2>\r\n\r\n");
            EndContext();
#line 6 "C:\Users\vinh\source\repos\WebHoaLan\WebHoaLan\Areas\Customer\Views\Product\SearchResults.cshtml"
 if (Model.Any())
{

#line default
#line hidden
            BeginContext(127, 10, true);
            WriteLiteral("    <ul>\r\n");
            EndContext();
#line 9 "C:\Users\vinh\source\repos\WebHoaLan\WebHoaLan\Areas\Customer\Views\Product\SearchResults.cshtml"
         foreach (var product in Model)
        {

#line default
#line hidden
            BeginContext(189, 86, true);
            WriteLiteral("            <div class=\"col-4\">\r\n            <div class=\"card mb-4\">\r\n                ");
            EndContext();
            BeginContext(275, 90, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "b1e8c9773b6d8cf82e88e77026f6e95dbd45d3f8787331cf5009c8a61c6f9e046572", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 285, "~/", 285, 2, true);
#line 13 "C:\Users\vinh\source\repos\WebHoaLan\WebHoaLan\Areas\Customer\Views\Product\SearchResults.cshtml"
AddHtmlAttributeValue("", 287, product.Image, 287, 14, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(365, 134, true);
            WriteLiteral("\r\n                <div class=\"card-header\">\r\n                    <h4 class=\"my-0 font-weight-normal\">\r\n                        <label>");
            EndContext();
            BeginContext(500, 20, false);
#line 16 "C:\Users\vinh\source\repos\WebHoaLan\WebHoaLan\Areas\Customer\Views\Product\SearchResults.cshtml"
                          Write(product.ProductsName);

#line default
#line hidden
            EndContext();
            BeginContext(520, 285, true);
            WriteLiteral(@"</label>
                    </h4>
                </div>
                <div class=""card-header"">
                    <div class=""d-flex justify-content-between align-items-center"">
                        <div class=""btn-group"">
                            <label ><b>Price : ");
            EndContext();
            BeginContext(806, 13, false);
#line 22 "C:\Users\vinh\source\repos\WebHoaLan\WebHoaLan\Areas\Customer\Views\Product\SearchResults.cshtml"
                                          Write(product.Price);

#line default
#line hidden
            EndContext();
            BeginContext(819, 70, true);
            WriteLiteral("</b></label>\r\n                        </div>\r\n                        ");
            EndContext();
            BeginContext(889, 143, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b1e8c9773b6d8cf82e88e77026f6e95dbd45d3f8787331cf5009c8a61c6f9e049684", async() => {
                BeginContext(1021, 7, true);
                WriteLiteral("Details");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 24 "C:\Users\vinh\source\repos\WebHoaLan\WebHoaLan\Areas\Customer\Views\Product\SearchResults.cshtml"
                                                                       WriteLiteral(product.ProductsId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1032, 90, true);
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n");
            EndContext();
#line 29 "C:\Users\vinh\source\repos\WebHoaLan\WebHoaLan\Areas\Customer\Views\Product\SearchResults.cshtml"
        }

#line default
#line hidden
            BeginContext(1133, 11, true);
            WriteLiteral("    </ul>\r\n");
            EndContext();
#line 31 "C:\Users\vinh\source\repos\WebHoaLan\WebHoaLan\Areas\Customer\Views\Product\SearchResults.cshtml"
}
else
{

#line default
#line hidden
            BeginContext(1156, 39, true);
            WriteLiteral("    <p>Không có kết quả tìm kiếm.</p>\r\n");
            EndContext();
#line 35 "C:\Users\vinh\source\repos\WebHoaLan\WebHoaLan\Areas\Customer\Views\Product\SearchResults.cshtml"
}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Products>> Html { get; private set; }
    }
}
#pragma warning restore 1591
