#pragma checksum "C:\Users\greed\source\repos\desarrolloweb\desarrolloweb\Views\Producto\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6c367a735e44218b77491cda7611d2395ff88999"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Producto_Index), @"mvc.1.0.view", @"/Views/Producto/Index.cshtml")]
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
#line 1 "C:\Users\greed\source\repos\desarrolloweb\desarrolloweb\Views\_ViewImports.cshtml"
using desarrolloweb;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\greed\source\repos\desarrolloweb\desarrolloweb\Views\_ViewImports.cshtml"
using desarrolloweb.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6c367a735e44218b77491cda7611d2395ff88999", @"/Views/Producto/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b5678c6a96673004094b629d7c22a40a890cdd1c", @"/Views/_ViewImports.cshtml")]
    public class Views_Producto_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<desarrolloweb.Models.TbProducto>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\greed\source\repos\desarrolloweb\desarrolloweb\Views\Producto\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_MasterProduct.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<section id=\"home-section\" class=\"hero\">\r\n    <div class=\"home-slider owl-carousel\">\r\n        <div class=\"slider-item\"");
            BeginWriteAttribute("style", " style=\"", 266, "\"", 338, 4);
            WriteAttributeValue("", 274, "background-image:", 274, 17, true);
            WriteAttributeValue(" ", 291, "url(", 292, 5, true);
#nullable restore
#line 8 "C:\Users\greed\source\repos\desarrolloweb\desarrolloweb\Views\Producto\Index.cshtml"
WriteAttributeValue("", 296, Url.Content("~/assets/images/bg_1.jpg"), 296, 40, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 336, ");", 336, 2, true);
            EndWriteAttribute();
            WriteLiteral(@">
            <div class=""overlay""></div>
            <div class=""container"">
                <div class=""row slider-text justify-content-center align-items-center"" data-scrollax-parent=""true"">

                    <div class=""col-md-12 ftco-animate text-center"">
                        <h1 class=""mb-2"">We serve Fresh Vegestables &amp; Fruits</h1>
                        <h2 class=""subheading mb-4"">We deliver organic vegetables &amp; fruits</h2>
                        <p><a href=""#"" class=""btn btn-primary"">View Details</a></p>
                    </div>

                </div>
            </div>
        </div>

        <div class=""slider-item""");
            BeginWriteAttribute("style", " style=\"", 1006, "\"", 1078, 4);
            WriteAttributeValue("", 1014, "background-image:", 1014, 17, true);
            WriteAttributeValue(" ", 1031, "url(", 1032, 5, true);
#nullable restore
#line 23 "C:\Users\greed\source\repos\desarrolloweb\desarrolloweb\Views\Producto\Index.cshtml"
WriteAttributeValue("", 1036, Url.Content("~/assets/images/bg_2.jpg"), 1036, 40, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1076, ");", 1076, 2, true);
            EndWriteAttribute();
            WriteLiteral(@">
            <div class=""overlay""></div>
            <div class=""container"">
                <div class=""row slider-text justify-content-center align-items-center"" data-scrollax-parent=""true"">

                    <div class=""col-sm-12 ftco-animate text-center"">
                        <h1 class=""mb-2"">100% Fresh &amp; Organic Foods</h1>
                        <h2 class=""subheading mb-4"">We deliver organic vegetables &amp; fruits</h2>
                        <p><a href=""#"" class=""btn btn-primary"">View Details</a></p>
                    </div>

                </div>
            </div>
        </div>
    </div>
</section>
<section class=""ftco-section"">
    <div class=""container"">
        <div class=""row justify-content-center"">
            <div class=""col-md-10 mb-5 text-center"">
                <ul class=""product-category"">
                    <li><a href=""#"" class=""active"">All</a></li>
                    <li><a href=""#"">Vegetables</a></li>
                    <li><a href=""#"">Fruits");
            WriteLiteral("</a></li>\r\n                    <li><a href=\"#\">Juice</a></li>\r\n                    <li><a href=\"#\">Dried</a></li>\r\n                </ul>\r\n            </div>\r\n        </div>\r\n        <div class=\"row\">\r\n");
#nullable restore
#line 53 "C:\Users\greed\source\repos\desarrolloweb\desarrolloweb\Views\Producto\Index.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"col-md-6 col-lg-3 ftco-animate fadeInUp ftco-animated\">\r\n                    <div class=\"product\">\r\n                        <a href=\"#\" class=\"img-prod\">\r\n                            <img class=\"img-fluid\"");
            BeginWriteAttribute("src", " src=\"", 2594, "\"", 2622, 1);
#nullable restore
#line 58 "C:\Users\greed\source\repos\desarrolloweb\desarrolloweb\Views\Producto\Index.cshtml"
WriteAttributeValue("", 2600, Url.Content(item.Img), 2600, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" alt=""Colorlib Template"" style=""width:252px;height:202px;"">
                            <div class=""overlay""></div>
                        </a>
                        <div class=""text py-3 pb-4 px-3 text-center"">
                            <h3><a href=""#"">");
#nullable restore
#line 62 "C:\Users\greed\source\repos\desarrolloweb\desarrolloweb\Views\Producto\Index.cshtml"
                                       Write(Html.DisplayFor(modelItem => item.Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h3>\r\n                            <div class=\"d-flex\">\r\n                                <div class=\"pricing\">\r\n                                    <p class=\"price\">$");
#nullable restore
#line 65 "C:\Users\greed\source\repos\desarrolloweb\desarrolloweb\Views\Producto\Index.cshtml"
                                                 Write(Html.DisplayFor(modelItem => item.Precio));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                                </div>
                            </div>
                            <div class=""bottom-area d-flex px-3"">
                                <div class=""m-auto d-flex"">
                                    <a href=""#"" class=""add-to-cart d-flex justify-content-center align-items-center text-center"">
                                        <span><i class=""ion-ios-menu""></i></span>
                                    </a>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
");
#nullable restore
#line 78 "C:\Users\greed\source\repos\desarrolloweb\desarrolloweb\Views\Producto\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            </div>
        <div class=""row mt-5"">
            <div class=""col text-center"">
                <div class=""block-27"">
                    <ul>
                        <li><a href=""#"">&lt;</a></li>
                        <li class=""active""><span>1</span></li>
                        <li><a href=""#"">2</a></li>
                        <li><a href=""#"">3</a></li>
                        <li><a href=""#"">4</a></li>
                        <li><a href=""#"">5</a></li>
                        <li><a href=""#"">&gt;</a></li>
                    </ul>
                </div>
            </div>
        </div>
    </div>
</section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<desarrolloweb.Models.TbProducto>> Html { get; private set; }
    }
}
#pragma warning restore 1591
