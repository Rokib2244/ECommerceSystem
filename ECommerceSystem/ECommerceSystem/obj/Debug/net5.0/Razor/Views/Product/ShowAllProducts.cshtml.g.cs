#pragma checksum "E:\Practice of Full CRUD\ECommerceSystem\ECommerceSystem\Views\Product\ShowAllProducts.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "aae16be59935f59f53c26146ff7898f46cc3c9d8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_ShowAllProducts), @"mvc.1.0.view", @"/Views/Product/ShowAllProducts.cshtml")]
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
#line 1 "E:\Practice of Full CRUD\ECommerceSystem\ECommerceSystem\Views\_ViewImports.cshtml"
using ECommerceSystem;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Practice of Full CRUD\ECommerceSystem\ECommerceSystem\Views\_ViewImports.cshtml"
using ECommerceSystem.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aae16be59935f59f53c26146ff7898f46cc3c9d8", @"/Views/Product/ShowAllProducts.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"46169eb9a800799dea293b098656bd0db993d1cd", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_ShowAllProducts : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProductListModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "E:\Practice of Full CRUD\ECommerceSystem\ECommerceSystem\Views\Product\ShowAllProducts.cshtml"
  
    ViewData["Title"] = "ShowAllProducts";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>ShowAllProducts</h1>\r\n");
#nullable restore
#line 7 "E:\Practice of Full CRUD\ECommerceSystem\ECommerceSystem\Views\Product\ShowAllProducts.cshtml"
  
    foreach (var product in Model.Products)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <h1>");
#nullable restore
#line 10 "E:\Practice of Full CRUD\ECommerceSystem\ECommerceSystem\Views\Product\ShowAllProducts.cshtml"
       Write(product.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n        <h1>");
#nullable restore
#line 11 "E:\Practice of Full CRUD\ECommerceSystem\ECommerceSystem\Views\Product\ShowAllProducts.cshtml"
       Write(product.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n");
#nullable restore
#line 12 "E:\Practice of Full CRUD\ECommerceSystem\ECommerceSystem\Views\Product\ShowAllProducts.cshtml"

    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProductListModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
