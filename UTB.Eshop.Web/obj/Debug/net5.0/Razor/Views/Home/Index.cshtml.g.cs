#pragma checksum "C:\Users\matyv\OneDrive\Plocha\UTB.Eshop.ctvrtek12\UTB.Eshop.Web\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bb096047e1abbe7e1e0bab5d8590740a9f4592ad"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\matyv\OneDrive\Plocha\UTB.Eshop.ctvrtek12\UTB.Eshop.Web\Views\_ViewImports.cshtml"
using UTB.Eshop.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\matyv\OneDrive\Plocha\UTB.Eshop.ctvrtek12\UTB.Eshop.Web\Views\_ViewImports.cshtml"
using UTB.Eshop.Web.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\matyv\OneDrive\Plocha\UTB.Eshop.ctvrtek12\UTB.Eshop.Web\Views\_ViewImports.cshtml"
using UTB.Eshop.Web.Models.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\matyv\OneDrive\Plocha\UTB.Eshop.ctvrtek12\UTB.Eshop.Web\Views\_ViewImports.cshtml"
using UTB.Eshop.Web.Models.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\matyv\OneDrive\Plocha\UTB.Eshop.ctvrtek12\UTB.Eshop.Web\Views\_ViewImports.cshtml"
using UTB.Eshop.Web.Models.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bb096047e1abbe7e1e0bab5d8590740a9f4592ad", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ca13943ad23bcc8748623cbff3a6f53a3295aca7", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HomeIndexViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/Product.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("include", "Development", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/Product.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("exclude", "Development", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.EnvironmentTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\matyv\OneDrive\Plocha\UTB.Eshop.ctvrtek12\UTB.Eshop.Web\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";
    var sale = 0;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"text-center\">\r\n   \r\n</div>\r\n<script src=\"https://kit.fontawesome.com/a076d05399.js\" crossorigin=\"anonymous\"></script>\r\n\r\n");
#nullable restore
#line 14 "C:\Users\matyv\OneDrive\Plocha\UTB.Eshop.ctvrtek12\UTB.Eshop.Web\Views\Home\Index.cshtml"
  

    if (Model != null && Model.CarouselItems.Count > 0)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div id=\"carouselExampleIndicators\" class=\"carousel slide\" data-ride=\"carousel\">\r\n            <ol class=\"carousel-indicators\">\r\n");
#nullable restore
#line 20 "C:\Users\matyv\OneDrive\Plocha\UTB.Eshop.ctvrtek12\UTB.Eshop.Web\Views\Home\Index.cshtml"
                  
                    for (int i = 0; i < Model.CarouselItems.Count; ++i)
                    {
                        string ActiveClass = String.Empty;
                        if (i == 0)
                        {
                            ActiveClass = "class=active";
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <li data-target=\"#carouselExampleIndicators\" data-slide-to=\"");
#nullable restore
#line 28 "C:\Users\matyv\OneDrive\Plocha\UTB.Eshop.ctvrtek12\UTB.Eshop.Web\Views\Home\Index.cshtml"
                                                                               Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" ");
#nullable restore
#line 28 "C:\Users\matyv\OneDrive\Plocha\UTB.Eshop.ctvrtek12\UTB.Eshop.Web\Views\Home\Index.cshtml"
                                                                                   Write(ActiveClass);

#line default
#line hidden
#nullable disable
            WriteLiteral("></li>\r\n");
#nullable restore
#line 29 "C:\Users\matyv\OneDrive\Plocha\UTB.Eshop.ctvrtek12\UTB.Eshop.Web\Views\Home\Index.cshtml"
                    }
                

#line default
#line hidden
#nullable disable
            WriteLiteral("            </ol>\r\n            <div class=\"carousel-inner\">\r\n");
#nullable restore
#line 33 "C:\Users\matyv\OneDrive\Plocha\UTB.Eshop.ctvrtek12\UTB.Eshop.Web\Views\Home\Index.cshtml"
                  
                    for (int i = 0; i < Model.CarouselItems.Count; ++i)
                    {
                        string ActiveClass = String.Empty;
                        if (i == 0)
                        {
                            ActiveClass = "active";
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div");
            BeginWriteAttribute("class", " class=\"", 1321, "\"", 1355, 2);
            WriteAttributeValue("", 1329, "carousel-item", 1329, 13, true);
#nullable restore
#line 41 "C:\Users\matyv\OneDrive\Plocha\UTB.Eshop.ctvrtek12\UTB.Eshop.Web\Views\Home\Index.cshtml"
WriteAttributeValue(" ", 1342, ActiveClass, 1343, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                            <img class=\"d-block w-100\"");
            BeginWriteAttribute("src", " src=\"", 1413, "\"", 1451, 1);
#nullable restore
#line 42 "C:\Users\matyv\OneDrive\Plocha\UTB.Eshop.ctvrtek12\UTB.Eshop.Web\Views\Home\Index.cshtml"
WriteAttributeValue("", 1419, Model.CarouselItems[i].ImageSrc, 1419, 32, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 1452, "\"", 1490, 1);
#nullable restore
#line 42 "C:\Users\matyv\OneDrive\Plocha\UTB.Eshop.ctvrtek12\UTB.Eshop.Web\Views\Home\Index.cshtml"
WriteAttributeValue("", 1458, Model.CarouselItems[i].ImageAlt, 1458, 32, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                        </div>\r\n");
#nullable restore
#line 44 "C:\Users\matyv\OneDrive\Plocha\UTB.Eshop.ctvrtek12\UTB.Eshop.Web\Views\Home\Index.cshtml"
                    }
                

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            </div>
            <a class=""carousel-control-prev"" href=""#carouselExampleIndicators"" role=""button"" data-slide=""prev"">
                <span class=""carousel-control-prev-icon"" aria-hidden=""true""></span>
                <span class=""sr-only"">Previous</span>
            </a>
            <a class=""carousel-control-next"" href=""#carouselExampleIndicators"" role=""button"" data-slide=""next"">
                <span class=""carousel-control-next-icon"" aria-hidden=""true""></span>
                <span class=""sr-only"">Next</span>
            </a>
        </div>
");
#nullable restore
#line 56 "C:\Users\matyv\OneDrive\Plocha\UTB.Eshop.ctvrtek12\UTB.Eshop.Web\Views\Home\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"benefits\">\r\n    <h1>Special offer today</h1>\r\n");
#nullable restore
#line 61 "C:\Users\matyv\OneDrive\Plocha\UTB.Eshop.ctvrtek12\UTB.Eshop.Web\Views\Home\Index.cshtml"
          
     
            foreach (var coupon in Model.Coupons)
            {
                if (@coupon.Status == "1") {
                   

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <p>There is <i>");
#nullable restore
#line 67 "C:\Users\matyv\OneDrive\Plocha\UTB.Eshop.ctvrtek12\UTB.Eshop.Web\Views\Home\Index.cshtml"
                              Write(coupon.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</i> with ");
#nullable restore
#line 67 "C:\Users\matyv\OneDrive\Plocha\UTB.Eshop.ctvrtek12\UTB.Eshop.Web\Views\Home\Index.cshtml"
                                                    Write(coupon.Sale);

#line default
#line hidden
#nullable disable
            WriteLiteral(" % off!</p>\r\n");
#nullable restore
#line 68 "C:\Users\matyv\OneDrive\Plocha\UTB.Eshop.ctvrtek12\UTB.Eshop.Web\Views\Home\Index.cshtml"
                  
                }
            
            
            }

         

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n    \r\n\r\n   \r\n\r\n</div>\r\n\r\n");
#nullable restore
#line 83 "C:\Users\matyv\OneDrive\Plocha\UTB.Eshop.ctvrtek12\UTB.Eshop.Web\Views\Home\Index.cshtml"
  
    if (Model != null && Model.Products != null && Model.Products.Count > 0)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <table class=""table products"">
            <thead>
                <tr class=""menu"">
                    <th scope=""col"">
                        <h1>Products</h1>
                    </th>
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 95 "C:\Users\matyv\OneDrive\Plocha\UTB.Eshop.ctvrtek12\UTB.Eshop.Web\Views\Home\Index.cshtml"
                  
                    foreach (var product in Model.Products)
                    {

                    var originPrice = @product.Price;
                    sale = 0;

                        

#line default
#line hidden
#nullable disable
            WriteLiteral("<tr>\r\n                      \r\n                            <td class=\"p-name\">");
#nullable restore
#line 104 "C:\Users\matyv\OneDrive\Plocha\UTB.Eshop.ctvrtek12\UTB.Eshop.Web\Views\Home\Index.cshtml"
                                          Write(product.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td><img style=\"width: 15rem;\"");
            BeginWriteAttribute("src", " src=\"", 3303, "\"", 3326, 1);
#nullable restore
#line 105 "C:\Users\matyv\OneDrive\Plocha\UTB.Eshop.ctvrtek12\UTB.Eshop.Web\Views\Home\Index.cshtml"
WriteAttributeValue("", 3309, product.ImageSrc, 3309, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"icon\" /></td>\r\n                            <td class=\"p-price\" ><span id=\"originprice\">");
#nullable restore
#line 106 "C:\Users\matyv\OneDrive\Plocha\UTB.Eshop.ctvrtek12\UTB.Eshop.Web\Views\Home\Index.cshtml"
                                                                   Write(product.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(" K??</span>\r\n\r\n");
#nullable restore
#line 108 "C:\Users\matyv\OneDrive\Plocha\UTB.Eshop.ctvrtek12\UTB.Eshop.Web\Views\Home\Index.cshtml"
                           
                            foreach (var user in Model.Users)
                            {

                                        if(@User.Identity.Name == @user.UserName) {
                                    
                                                foreach (var group in Model.Groups)
                                                {

                                                    if(@user.Groupname == "Student" && @group.Name == "Student") {
                                                        sale += @group.Sale;
                                              
                                                        

#line default
#line hidden
#nullable disable
            WriteLiteral("<!--  <span>/ ");
#nullable restore
#line 120 "C:\Users\matyv\OneDrive\Plocha\UTB.Eshop.ctvrtek12\UTB.Eshop.Web\Views\Home\Index.cshtml"
                                                                 Write(group.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 120 "C:\Users\matyv\OneDrive\Plocha\UTB.Eshop.ctvrtek12\UTB.Eshop.Web\Views\Home\Index.cshtml"
                                                                               Write(group.Sale);

#line default
#line hidden
#nullable disable
            WriteLiteral(" %</span> -->\r\n");
#nullable restore
#line 121 "C:\Users\matyv\OneDrive\Plocha\UTB.Eshop.ctvrtek12\UTB.Eshop.Web\Views\Home\Index.cshtml"
                                                
                                                    }

                                                    if(@user.Groupname == "VIP" && @group.Name == "VIP") {
                                                        sale += @group.Sale;
                                              
                                                        

#line default
#line hidden
#nullable disable
            WriteLiteral("<!--  <span>/ ");
#nullable restore
#line 127 "C:\Users\matyv\OneDrive\Plocha\UTB.Eshop.ctvrtek12\UTB.Eshop.Web\Views\Home\Index.cshtml"
                                                                 Write(group.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 127 "C:\Users\matyv\OneDrive\Plocha\UTB.Eshop.ctvrtek12\UTB.Eshop.Web\Views\Home\Index.cshtml"
                                                                               Write(group.Sale);

#line default
#line hidden
#nullable disable
            WriteLiteral(" %</span>\r\n                                                     <span>");
#nullable restore
#line 128 "C:\Users\matyv\OneDrive\Plocha\UTB.Eshop.ctvrtek12\UTB.Eshop.Web\Views\Home\Index.cshtml"
                                                      Write(group.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" price  ");
#nullable restore
#line 128 "C:\Users\matyv\OneDrive\Plocha\UTB.Eshop.ctvrtek12\UTB.Eshop.Web\Views\Home\Index.cshtml"
                                                                          Write(@product.Price - ((@product.Price*@group.Sale)/100));

#line default
#line hidden
#nullable disable
            WriteLiteral(" K??</span> -->\r\n");
#nullable restore
#line 129 "C:\Users\matyv\OneDrive\Plocha\UTB.Eshop.ctvrtek12\UTB.Eshop.Web\Views\Home\Index.cshtml"
                                                
                                                    }
                                
                                                }
                                    
                                        }

                                        }
                                        foreach (var coupon in Model.Coupons)
                                        {
                                            if (@coupon.Status == "1") {
                                                sale += @coupon.Sale;
                                               

#line default
#line hidden
#nullable disable
            WriteLiteral("<!-- <span>/ ");
#nullable restore
#line 141 "C:\Users\matyv\OneDrive\Plocha\UTB.Eshop.ctvrtek12\UTB.Eshop.Web\Views\Home\Index.cshtml"
                                                       Write(coupon.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 141 "C:\Users\matyv\OneDrive\Plocha\UTB.Eshop.ctvrtek12\UTB.Eshop.Web\Views\Home\Index.cshtml"
                                                                      Write(coupon.Sale);

#line default
#line hidden
#nullable disable
            WriteLiteral(" %</span> -->\r\n");
#nullable restore
#line 142 "C:\Users\matyv\OneDrive\Plocha\UTB.Eshop.ctvrtek12\UTB.Eshop.Web\Views\Home\Index.cshtml"
                  
                                            }
            
            
                                        }

                                
                             

#line default
#line hidden
#nullable disable
            WriteLiteral("                        \r\n                             ");
#nullable restore
#line 151 "C:\Users\matyv\OneDrive\Plocha\UTB.Eshop.ctvrtek12\UTB.Eshop.Web\Views\Home\Index.cshtml"
                         Write(@product.Price - ((@product.Price * @sale)/100));

#line default
#line hidden
#nullable disable
            WriteLiteral(" K??</td>\r\n\r\n                            <td class=\"p-btn column-butten-custom\">\r\n                            <div class=\"sales\">\r\n");
#nullable restore
#line 155 "C:\Users\matyv\OneDrive\Plocha\UTB.Eshop.ctvrtek12\UTB.Eshop.Web\Views\Home\Index.cshtml"
                                
                                    foreach (var user in Model.Users)
                                    {
                                        if(@User.Identity.Name == @user.UserName) 
                                        {

                                            foreach (var group in Model.Groups)
                                            {

                                                    if(@user.Groupname == "Student" && @group.Name == "Student") {
                                              

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                         <span><i class=\"fas fa-user-graduate\"></i> ");
#nullable restore
#line 166 "C:\Users\matyv\OneDrive\Plocha\UTB.Eshop.ctvrtek12\UTB.Eshop.Web\Views\Home\Index.cshtml"
                                                                                               Write(group.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 166 "C:\Users\matyv\OneDrive\Plocha\UTB.Eshop.ctvrtek12\UTB.Eshop.Web\Views\Home\Index.cshtml"
                                                                                                             Write(group.Sale);

#line default
#line hidden
#nullable disable
            WriteLiteral(" %</span>\r\n");
#nullable restore
#line 167 "C:\Users\matyv\OneDrive\Plocha\UTB.Eshop.ctvrtek12\UTB.Eshop.Web\Views\Home\Index.cshtml"
                                                
                                                    }

                                                    if(@user.Groupname == "VIP" && @group.Name == "VIP") {
                                   
                                              

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                        <span><i class=\"fas fa-award\"></i> ");
#nullable restore
#line 173 "C:\Users\matyv\OneDrive\Plocha\UTB.Eshop.ctvrtek12\UTB.Eshop.Web\Views\Home\Index.cshtml"
                                                                                      Write(group.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 173 "C:\Users\matyv\OneDrive\Plocha\UTB.Eshop.ctvrtek12\UTB.Eshop.Web\Views\Home\Index.cshtml"
                                                                                                    Write(group.Sale);

#line default
#line hidden
#nullable disable
            WriteLiteral(" %</span>\r\n");
#nullable restore
#line 174 "C:\Users\matyv\OneDrive\Plocha\UTB.Eshop.ctvrtek12\UTB.Eshop.Web\Views\Home\Index.cshtml"
                                                
                                                    }
                                            }

                                        }

                                    }


                                    foreach (var coupon in Model.Coupons)
                                        {
                                            if (@coupon.Status == "1") {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                               <span><i class=\"fas fa-gift\"></i> ");
#nullable restore
#line 186 "C:\Users\matyv\OneDrive\Plocha\UTB.Eshop.ctvrtek12\UTB.Eshop.Web\Views\Home\Index.cshtml"
                                                                            Write(coupon.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 186 "C:\Users\matyv\OneDrive\Plocha\UTB.Eshop.ctvrtek12\UTB.Eshop.Web\Views\Home\Index.cshtml"
                                                                                           Write(coupon.Sale);

#line default
#line hidden
#nullable disable
            WriteLiteral(" %</span>\r\n");
#nullable restore
#line 187 "C:\Users\matyv\OneDrive\Plocha\UTB.Eshop.ctvrtek12\UTB.Eshop.Web\Views\Home\Index.cshtml"
                                            }
            
            
                                        }

                            

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                              \r\n                                    </div>\r\n");
#nullable restore
#line 197 "C:\Users\matyv\OneDrive\Plocha\UTB.Eshop.ctvrtek12\UTB.Eshop.Web\Views\Home\Index.cshtml"
                                         if (User.Identity.IsAuthenticated == true) {
                                    

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <button type=\"button\" id=\"product-btn\" class=\"btn btn-danger\"");
            BeginWriteAttribute("onclick", " onclick=\"", 8089, "\"", 8286, 11);
            WriteAttributeValue("", 8099, "Buy(", 8099, 4, true);
#nullable restore
#line 199 "C:\Users\matyv\OneDrive\Plocha\UTB.Eshop.ctvrtek12\UTB.Eshop.Web\Views\Home\Index.cshtml"
WriteAttributeValue("", 8103, product.ID, 8103, 11, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 8114, ",\'", 8114, 2, true);
#nullable restore
#line 199 "C:\Users\matyv\OneDrive\Plocha\UTB.Eshop.ctvrtek12\UTB.Eshop.Web\Views\Home\Index.cshtml"
WriteAttributeValue("", 8116, Url.Action("AddOrderItemsToSession", "CustomerOrderNotCart", new { Area = "Customer" }), 8116, 88, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 8204, "\',", 8204, 2, true);
            WriteAttributeValue(" ", 8206, "\'#total_price\',", 8207, 16, true);
            WriteAttributeValue(" ", 8222, "\'", 8223, 2, true);
#nullable restore
#line 199 "C:\Users\matyv\OneDrive\Plocha\UTB.Eshop.ctvrtek12\UTB.Eshop.Web\Views\Home\Index.cshtml"
WriteAttributeValue("", 8224, System.Globalization.CultureInfo.CurrentCulture.Name, 8224, 53, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 8277, "\',", 8277, 2, true);
#nullable restore
#line 199 "C:\Users\matyv\OneDrive\Plocha\UTB.Eshop.ctvrtek12\UTB.Eshop.Web\Views\Home\Index.cshtml"
WriteAttributeValue(" ", 8279, sale, 8280, 5, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 8285, ")", 8285, 1, true);
            EndWriteAttribute();
            WriteLiteral(">Add to cart</button>\r\n");
#nullable restore
#line 200 "C:\Users\matyv\OneDrive\Plocha\UTB.Eshop.ctvrtek12\UTB.Eshop.Web\Views\Home\Index.cshtml"
                                        } else {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <button type=\"button\" id=\"product-btn\" class=\"btn btn-danger\" style=\"opacity: 0.5 !important; cursor: not-allowed !important;\" disabled");
            BeginWriteAttribute("onclick", " onclick=\"", 8539, "\"", 8736, 11);
            WriteAttributeValue("", 8549, "Buy(", 8549, 4, true);
#nullable restore
#line 201 "C:\Users\matyv\OneDrive\Plocha\UTB.Eshop.ctvrtek12\UTB.Eshop.Web\Views\Home\Index.cshtml"
WriteAttributeValue("", 8553, product.ID, 8553, 11, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 8564, ",\'", 8564, 2, true);
#nullable restore
#line 201 "C:\Users\matyv\OneDrive\Plocha\UTB.Eshop.ctvrtek12\UTB.Eshop.Web\Views\Home\Index.cshtml"
WriteAttributeValue("", 8566, Url.Action("AddOrderItemsToSession", "CustomerOrderNotCart", new { Area = "Customer" }), 8566, 88, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 8654, "\',", 8654, 2, true);
            WriteAttributeValue(" ", 8656, "\'#total_price\',", 8657, 16, true);
            WriteAttributeValue(" ", 8672, "\'", 8673, 2, true);
#nullable restore
#line 201 "C:\Users\matyv\OneDrive\Plocha\UTB.Eshop.ctvrtek12\UTB.Eshop.Web\Views\Home\Index.cshtml"
WriteAttributeValue("", 8674, System.Globalization.CultureInfo.CurrentCulture.Name, 8674, 53, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 8727, "\',", 8727, 2, true);
#nullable restore
#line 201 "C:\Users\matyv\OneDrive\Plocha\UTB.Eshop.ctvrtek12\UTB.Eshop.Web\Views\Home\Index.cshtml"
WriteAttributeValue(" ", 8729, sale, 8730, 5, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 8735, ")", 8735, 1, true);
            EndWriteAttribute();
            WriteLiteral(">Add to cart</button>\r\n");
#nullable restore
#line 202 "C:\Users\matyv\OneDrive\Plocha\UTB.Eshop.ctvrtek12\UTB.Eshop.Web\Views\Home\Index.cshtml"
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    </td>\r\n                                 \r\n\r\n                        </tr>\r\n");
#nullable restore
#line 209 "C:\Users\matyv\OneDrive\Plocha\UTB.Eshop.ctvrtek12\UTB.Eshop.Web\Views\Home\Index.cshtml"
                    }
                

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n");
#nullable restore
#line 213 "C:\Users\matyv\OneDrive\Plocha\UTB.Eshop.ctvrtek12\UTB.Eshop.Web\Views\Home\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("environment", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bb096047e1abbe7e1e0bab5d8590740a9f4592ad29602", async() => {
                    WriteLiteral("\r\n        ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bb096047e1abbe7e1e0bab5d8590740a9f4592ad29884", async() => {
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("\r\n    ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.EnvironmentTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper.Include = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("environment", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bb096047e1abbe7e1e0bab5d8590740a9f4592ad32019", async() => {
                    WriteLiteral("\r\n        ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bb096047e1abbe7e1e0bab5d8590740a9f4592ad32301", async() => {
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("\r\n    ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.EnvironmentTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper.Exclude = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HomeIndexViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
