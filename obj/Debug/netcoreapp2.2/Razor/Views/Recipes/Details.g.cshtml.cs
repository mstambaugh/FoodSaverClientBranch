#pragma checksum "/Users/Guest/Desktop/FoodSaverClient/Views/Recipes/Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ef7383ca23248b39ed8248ae58e2a190a860a759"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Recipes_Details), @"mvc.1.0.view", @"/Views/Recipes/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Recipes/Details.cshtml", typeof(AspNetCore.Views_Recipes_Details))]
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
#line 3 "/Users/Guest/Desktop/FoodSaverClient/Views/Recipes/Details.cshtml"
using FoodSaverClient.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ef7383ca23248b39ed8248ae58e2a190a860a759", @"/Views/Recipes/Details.cshtml")]
    public class Views_Recipes_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Recipe>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(71, 2, true);
            WriteLiteral("\n\n");
            EndContext();
            BeginContext(119, 5, true);
            WriteLiteral("\n<h1>");
            EndContext();
            BeginContext(125, 16, false);
#line 6 "/Users/Guest/Desktop/FoodSaverClient/Views/Recipes/Details.cshtml"
Write(Model.RecipeName);

#line default
#line hidden
            EndContext();
            BeginContext(141, 35, true);
            WriteLiteral(":</h1>\n\n<ol>\n    <ul>\n        <li> ");
            EndContext();
            BeginContext(177, 16, false);
#line 10 "/Users/Guest/Desktop/FoodSaverClient/Views/Recipes/Details.cshtml"
        Write(Model.RecipeName);

#line default
#line hidden
            EndContext();
            BeginContext(193, 30, true);
            WriteLiteral("</li>\n        <li>Directions: ");
            EndContext();
            BeginContext(224, 16, false);
#line 11 "/Users/Guest/Desktop/FoodSaverClient/Views/Recipes/Details.cshtml"
                   Write(Model.Directions);

#line default
#line hidden
            EndContext();
            BeginContext(240, 36, true);
            WriteLiteral("</li>\n        <li>Nutritional Info: ");
            EndContext();
            BeginContext(277, 19, false);
#line 12 "/Users/Guest/Desktop/FoodSaverClient/Views/Recipes/Details.cshtml"
                         Write(Model.NutritionInfo);

#line default
#line hidden
            EndContext();
            BeginContext(296, 24, true);
            WriteLiteral("</li>\n        <li>Tips: ");
            EndContext();
            BeginContext(321, 16, false);
#line 13 "/Users/Guest/Desktop/FoodSaverClient/Views/Recipes/Details.cshtml"
             Write(Model.RecipeTips);

#line default
#line hidden
            EndContext();
            BeginContext(337, 38, true);
            WriteLiteral(" </li>\n        <li>Price per serving: ");
            EndContext();
            BeginContext(376, 21, false);
#line 14 "/Users/Guest/Desktop/FoodSaverClient/Views/Recipes/Details.cshtml"
                          Write(Model.PricePerServing);

#line default
#line hidden
            EndContext();
            BeginContext(397, 56, true);
            WriteLiteral(" </li>\n    </ul>\n</ol>\n\n<button class=\"btn btn-default\">");
            EndContext();
            BeginContext(454, 40, false);
#line 18 "/Users/Guest/Desktop/FoodSaverClient/Views/Recipes/Details.cshtml"
                           Write(Html.ActionLink("Back To Home", "Index"));

#line default
#line hidden
            EndContext();
            BeginContext(494, 9, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Recipe> Html { get; private set; }
    }
}
#pragma warning restore 1591
