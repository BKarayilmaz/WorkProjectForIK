#pragma checksum "C:\Users\Bilgisayar\source\repos\InteraktifKredi\InteraktifKredi\Views\Product\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "339bde98df6b9d01a515cf7ceb387f935ae2f019"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Index), @"mvc.1.0.view", @"/Views/Product/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"339bde98df6b9d01a515cf7ceb387f935ae2f019", @"/Views/Product/Index.cshtml")]
    public class Views_Product_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<InteraktifKredi.Data.Models.Product>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("card-img-top"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Bilgisayar\source\repos\InteraktifKredi\InteraktifKredi\Views\Product\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 9 "C:\Users\Bilgisayar\source\repos\InteraktifKredi\InteraktifKredi\Views\Product\Index.cshtml"
 foreach (var x in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"card\" style=\"width: 250px; height: 400px; margin-right:10px; margin-bottom:15px; float: left;\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "339bde98df6b9d01a515cf7ceb387f935ae2f0193626", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 326, "~/Images/", 326, 9, true);
#nullable restore
#line 12 "C:\Users\Bilgisayar\source\repos\InteraktifKredi\InteraktifKredi\Views\Product\Index.cshtml"
AddHtmlAttributeValue("", 335, x.ImageUrl, 335, 11, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        <div class=\"card-body\">\r\n            <h5 class=\"card-title\">");
#nullable restore
#line 14 "C:\Users\Bilgisayar\source\repos\InteraktifKredi\InteraktifKredi\Views\Product\Index.cshtml"
                              Write(x.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n            <p class=\"card-text\">");
#nullable restore
#line 15 "C:\Users\Bilgisayar\source\repos\InteraktifKredi\InteraktifKredi\Views\Product\Index.cshtml"
                            Write(x.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral(".</p>\r\n        </div>\r\n        <div class=\"card-footer\">\r\n            <a");
            BeginWriteAttribute("href", " href=\"", 558, "\"", 598, 2);
            WriteAttributeValue("", 565, "/Product/LikeProduct/", 565, 21, true);
#nullable restore
#line 18 "C:\Users\Bilgisayar\source\repos\InteraktifKredi\InteraktifKredi\Views\Product\Index.cshtml"
WriteAttributeValue("", 586, x.ProductID, 586, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"card-link\" style=\"color:grey;\"><i onclick=\"myFunction(this)\" class=\"fa fa-thumbs-up\">");
#nullable restore
#line 18 "C:\Users\Bilgisayar\source\repos\InteraktifKredi\InteraktifKredi\Views\Product\Index.cshtml"
                                                                                                                                               Write(x.LikeCount);

#line default
#line hidden
#nullable disable
            WriteLiteral(" Like</i></a>\r\n            <a href=\"#\" class=\"card-link\"><i class=\"fa fa-eye\"> ");
#nullable restore
#line 19 "C:\Users\Bilgisayar\source\repos\InteraktifKredi\InteraktifKredi\Views\Product\Index.cshtml"
                                                           Write(x.ShowCount);

#line default
#line hidden
#nullable disable
            WriteLiteral(" View</i></a>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 22 "C:\Users\Bilgisayar\source\repos\InteraktifKredi\InteraktifKredi\Views\Product\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n\r\n\r\n<script>\r\n    function myFunction(x) {\r\n        x.classList.toggle(\"fa-thumbs-down\");\r\n    }\r\n</script>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<InteraktifKredi.Data.Models.Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591