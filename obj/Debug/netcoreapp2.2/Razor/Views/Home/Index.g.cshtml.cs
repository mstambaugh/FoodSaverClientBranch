#pragma checksum "/Users/Guest/Desktop/FoodSaverClient/Views/Home/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0956094c0602113b80c3e72dad959d93930c6e87"
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
#line 1 "/Users/Guest/Desktop/FoodSaverClient/Views/_ViewImports.cshtml"
using FoodSaverClient;

#line default
#line hidden
#line 2 "/Users/Guest/Desktop/FoodSaverClient/Views/_ViewImports.cshtml"
using FoodSaverClient.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0956094c0602113b80c3e72dad959d93930c6e87", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"94863bbcd32d8c82821662163f73ea5811c8cc44", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/Guest/Desktop/FoodSaverClient/Views/Home/Index.cshtml"
  
    ViewData["Title"] = "Home";

#line default
#line hidden
            BeginContext(37, 5, true);
            WriteLiteral("\n<h1>");
            EndContext();
            BeginContext(43, 17, false);
#line 5 "/Users/Guest/Desktop/FoodSaverClient/Views/Home/Index.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(60, 196, true);
            WriteLiteral("</h1>\n\n<h1>Welcome to Food Saver webpage.  To get a food schedule please navigate to the shopping list, to browse our recipes please navigate to that section</h1>\n\n<button class=\"btn btn-default\">");
            EndContext();
            BeginContext(257, 65, false);
#line 9 "/Users/Guest/Desktop/FoodSaverClient/Views/Home/Index.cshtml"
                           Write(Html.ActionLink("Take a look at Our Recipes", "Index", "Recipes"));

#line default
#line hidden
            EndContext();
            BeginContext(322, 42, true);
            WriteLiteral("</button>\n<button class=\"btn btn-default\">");
            EndContext();
            BeginContext(365, 81, false);
#line 10 "/Users/Guest/Desktop/FoodSaverClient/Views/Home/Index.cshtml"
                           Write(Html.ActionLink("Add recipes to create a shopping list", "Index", "ShoppingList"));

#line default
#line hidden
            EndContext();
            BeginContext(446, 9, true);
            WriteLiteral("</button>");
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
