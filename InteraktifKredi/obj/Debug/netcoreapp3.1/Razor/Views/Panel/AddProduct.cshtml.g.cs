#pragma checksum "C:\Users\Bilgisayar\source\repos\InteraktifKredi\InteraktifKredi\Views\Panel\AddProduct.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f5ae8a6fb1b779309cda1d3b41d0562ebee4d4b6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Panel_AddProduct), @"mvc.1.0.view", @"/Views/Panel/AddProduct.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f5ae8a6fb1b779309cda1d3b41d0562ebee4d4b6", @"/Views/Panel/AddProduct.cshtml")]
    public class Views_Panel_AddProduct : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<InteraktifKredi.Data.AddProduct>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Bilgisayar\source\repos\InteraktifKredi\InteraktifKredi\Views\Panel\AddProduct.cshtml"
  
    ViewData["Title"] = "AddProduct";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Product Add Page</h1>\r\n<br />\r\n<form class=\"form-group\" action=\"AddProduct\" asp-controller=\"Product\" method=\"post\" enctype=\"multipart/form-data\">\r\n\r\n    ");
#nullable restore
#line 11 "C:\Users\Bilgisayar\source\repos\InteraktifKredi\InteraktifKredi\Views\Panel\AddProduct.cshtml"
Write(Html.Label("Product Name"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    ");
#nullable restore
#line 12 "C:\Users\Bilgisayar\source\repos\InteraktifKredi\InteraktifKredi\Views\Panel\AddProduct.cshtml"
Write(Html.TextBoxFor(x => x.ProductName, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <br />\r\n    ");
#nullable restore
#line 14 "C:\Users\Bilgisayar\source\repos\InteraktifKredi\InteraktifKredi\Views\Panel\AddProduct.cshtml"
Write(Html.Label("Stock"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    ");
#nullable restore
#line 15 "C:\Users\Bilgisayar\source\repos\InteraktifKredi\InteraktifKredi\Views\Panel\AddProduct.cshtml"
Write(Html.TextBoxFor(x => x.Stock, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <br />\r\n    ");
#nullable restore
#line 17 "C:\Users\Bilgisayar\source\repos\InteraktifKredi\InteraktifKredi\Views\Panel\AddProduct.cshtml"
Write(Html.Label("Price"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    ");
#nullable restore
#line 18 "C:\Users\Bilgisayar\source\repos\InteraktifKredi\InteraktifKredi\Views\Panel\AddProduct.cshtml"
Write(Html.TextBoxFor(x => x.Price, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <br />\r\n    ");
#nullable restore
#line 20 "C:\Users\Bilgisayar\source\repos\InteraktifKredi\InteraktifKredi\Views\Panel\AddProduct.cshtml"
Write(Html.Label("Choose Image"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <br />\r\n    <input type=\"file\" name=\"ImageUrl\" />\r\n    <br />\r\n    \r\n    ");
#nullable restore
#line 25 "C:\Users\Bilgisayar\source\repos\InteraktifKredi\InteraktifKredi\Views\Panel\AddProduct.cshtml"
Write(Html.Label("Description"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    ");
#nullable restore
#line 26 "C:\Users\Bilgisayar\source\repos\InteraktifKredi\InteraktifKredi\Views\Panel\AddProduct.cshtml"
Write(Html.TextAreaFor(x => x.Description, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <br />\r\n    <button class=\"btn btn-info\">Save</button>\r\n\r\n</form>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<InteraktifKredi.Data.AddProduct> Html { get; private set; }
    }
}
#pragma warning restore 1591
