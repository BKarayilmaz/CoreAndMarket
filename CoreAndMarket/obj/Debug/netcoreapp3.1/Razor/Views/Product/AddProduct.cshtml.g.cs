#pragma checksum "C:\Users\Bilgisayar\source\repos\CoreAndMarket\CoreAndMarket\Views\Product\AddProduct.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d592c30c193b00b4c7a522a02750b92b8e1c1f5a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_AddProduct), @"mvc.1.0.view", @"/Views/Product/AddProduct.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d592c30c193b00b4c7a522a02750b92b8e1c1f5a", @"/Views/Product/AddProduct.cshtml")]
    public class Views_Product_AddProduct : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CoreAndMarket.Data.Models.Product>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Bilgisayar\source\repos\CoreAndMarket\CoreAndMarket\Views\Product\AddProduct.cshtml"
  
    ViewData["Title"] = "AddProduct";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Product Add Page</h1>\r\n<br />\r\n");
#nullable restore
#line 9 "C:\Users\Bilgisayar\source\repos\CoreAndMarket\CoreAndMarket\Views\Product\AddProduct.cshtml"
 using (Html.BeginForm("AddProduct", "Product", FormMethod.Post))
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Bilgisayar\source\repos\CoreAndMarket\CoreAndMarket\Views\Product\AddProduct.cshtml"
Write(Html.Label("Product Name"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Bilgisayar\source\repos\CoreAndMarket\CoreAndMarket\Views\Product\AddProduct.cshtml"
Write(Html.TextBoxFor(x => x.ProductName, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 14 "C:\Users\Bilgisayar\source\repos\CoreAndMarket\CoreAndMarket\Views\Product\AddProduct.cshtml"
Write(Html.Label("Stock"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\Bilgisayar\source\repos\CoreAndMarket\CoreAndMarket\Views\Product\AddProduct.cshtml"
Write(Html.TextBoxFor(x => x.Stock, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 17 "C:\Users\Bilgisayar\source\repos\CoreAndMarket\CoreAndMarket\Views\Product\AddProduct.cshtml"
Write(Html.Label("Price"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\Bilgisayar\source\repos\CoreAndMarket\CoreAndMarket\Views\Product\AddProduct.cshtml"
Write(Html.TextBoxFor(x => x.Price, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 20 "C:\Users\Bilgisayar\source\repos\CoreAndMarket\CoreAndMarket\Views\Product\AddProduct.cshtml"
Write(Html.Label("Image URL"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "C:\Users\Bilgisayar\source\repos\CoreAndMarket\CoreAndMarket\Views\Product\AddProduct.cshtml"
Write(Html.TextBoxFor(x => x.ImageUrl, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 23 "C:\Users\Bilgisayar\source\repos\CoreAndMarket\CoreAndMarket\Views\Product\AddProduct.cshtml"
Write(Html.Label("Category"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "C:\Users\Bilgisayar\source\repos\CoreAndMarket\CoreAndMarket\Views\Product\AddProduct.cshtml"
Write(Html.DropDownListFor(x => x.CategoryID,(List<SelectListItem>)ViewBag.vls, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 26 "C:\Users\Bilgisayar\source\repos\CoreAndMarket\CoreAndMarket\Views\Product\AddProduct.cshtml"
Write(Html.Label("Description"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 27 "C:\Users\Bilgisayar\source\repos\CoreAndMarket\CoreAndMarket\Views\Product\AddProduct.cshtml"
Write(Html.TextAreaFor(x => x.Description, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n    <button class=\"btn btn-info\">Save</button>\r\n");
#nullable restore
#line 30 "C:\Users\Bilgisayar\source\repos\CoreAndMarket\CoreAndMarket\Views\Product\AddProduct.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CoreAndMarket.Data.Models.Product> Html { get; private set; }
    }
}
#pragma warning restore 1591
