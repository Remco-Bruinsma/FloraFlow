#pragma checksum "C:\Users\Torem\Documents\semester 2\groeps project\FloraFlow\FloraFlow\Views\Pots\Pots.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "df23f6744429cca1ba37dc4d4053da31ca65d1b3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pots_Pots), @"mvc.1.0.view", @"/Views/Pots/Pots.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\Torem\Documents\semester 2\groeps project\FloraFlow\FloraFlow\Views\_ViewImports.cshtml"
using FloraFlow;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Torem\Documents\semester 2\groeps project\FloraFlow\FloraFlow\Views\Pots\Pots.cshtml"
using System.Collections.Generic;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Torem\Documents\semester 2\groeps project\FloraFlow\FloraFlow\Views\Pots\Pots.cshtml"
using System.ComponentModel.DataAnnotations;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Torem\Documents\semester 2\groeps project\FloraFlow\FloraFlow\Views\Pots\Pots.cshtml"
using System.Net;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Torem\Documents\semester 2\groeps project\FloraFlow\FloraFlow\Views\Pots\Pots.cshtml"
using FloraFlow.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"df23f6744429cca1ba37dc4d4053da31ca65d1b3", @"/Views/Pots/Pots.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dad7934e448b9f15fb60d03771aadb018c7623c6", @"/Views/_ViewImports.cshtml")]
    public class Views_Pots_Pots : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 8 "C:\Users\Torem\Documents\semester 2\groeps project\FloraFlow\FloraFlow\Views\Pots\Pots.cshtml"
  
    ViewBag.Title = "SelectCategory";
    Layout = "~/Views/Shared/_Layout.cshtml";
    List<PotModel> Pots = ViewData["pots"] as List<PotModel>;
    //List<string> potsImage = ViewData["pots"] as List<string>;
    var potsJsons = (QuickType2.PotsJson[])ViewData["potsJson"];

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<header>

    <style>
        .bd-placeholder-img {
            font-size: 1.125rem;
            text-anchor: middle;
            -webkit-user-select: none;
            -moz-user-select: none;
            user-select: none;
        }
    </style>



</header>

<main>

    <section class=""py-5 text-center container"">
        <div class=""row py-lg-4"">
            <div class=""col-lg-6 col-md-8 mx-auto"">
                <h1 class=""fw-light"">Pots</h1>
                <p class=""lead text-muted"">here you can see your pots  </p>

            </div>
        </div>
    </section>
    <div>
        <div class=""container"">
            <div class=""row row-cols-1 row-cols-sm-2 row-cols-md-3 g-3"">
");
#nullable restore
#line 47 "C:\Users\Torem\Documents\semester 2\groeps project\FloraFlow\FloraFlow\Views\Pots\Pots.cshtml"
                 foreach (QuickType2.PotsJson potsJson in potsJsons)
                {


#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    <div class=""card-body"">
                        <div class=""d-flex justify-content-between align-items-center"">
                            <div class=""card shadow-sm"">
                                <svg class=""bd-placeholder-img card-img-top""> <img");
            BeginWriteAttribute("src", " src=\"", 1610, "\"", 1635, 1);
#nullable restore
#line 53 "C:\Users\Torem\Documents\semester 2\groeps project\FloraFlow\FloraFlow\Views\Pots\Pots.cshtml"
WriteAttributeValue("", 1616, potsJson.Plant.Url, 1616, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 1636, "\"", 1667, 1);
#nullable restore
#line 53 "C:\Users\Torem\Documents\semester 2\groeps project\FloraFlow\FloraFlow\Views\Pots\Pots.cshtml"
WriteAttributeValue("", 1642, potsJson.Plant.PlantName, 1642, 25, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"width:300px;height:300px;\" /></svg>\r\n                                <div class=\"card-body\">\r\n                                    <p class=\"card-text\">Pot ");
#nullable restore
#line 55 "C:\Users\Torem\Documents\semester 2\groeps project\FloraFlow\FloraFlow\Views\Pots\Pots.cshtml"
                                                        Write(potsJson.PotId);

#line default
#line hidden
#nullable disable
            WriteLiteral(" is filled with ");
#nullable restore
#line 55 "C:\Users\Torem\Documents\semester 2\groeps project\FloraFlow\FloraFlow\Views\Pots\Pots.cshtml"
                                                                                       Write(potsJson.Plant.PlantName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\r\n                                    <div class=\"d-flex justify-content-between align-items-center\">\r\n                                        <div class=\"btn-group\">\r\n                                            <a");
            BeginWriteAttribute("href", " href=\"", 2106, "\"", 2174, 1);
#nullable restore
#line 58 "C:\Users\Torem\Documents\semester 2\groeps project\FloraFlow\FloraFlow\Views\Pots\Pots.cshtml"
WriteAttributeValue("", 2113, Url.Action("ChangePot", "Pots", new { pot = potsJson.PotId}), 2113, 61, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""btn btn-success"">Change</a>


                                        </div>
                                        <small class=""text-muted"">9 hours ago</small>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
");
#nullable restore
#line 68 "C:\Users\Torem\Documents\semester 2\groeps project\FloraFlow\FloraFlow\Views\Pots\Pots.cshtml"

                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n        </div>\r\n    </div>\r\n  \r\n    \r\n    <footer>\r\n        <div class=\"btn-group\">\r\n            <a");
            BeginWriteAttribute("href", " href=\"", 3825, "\"", 3861, 1);
#nullable restore
#line 100 "C:\Users\Torem\Documents\semester 2\groeps project\FloraFlow\FloraFlow\Views\Pots\Pots.cshtml"
WriteAttributeValue("", 3832, Url.Action("AddPot", "Pots"), 3832, 29, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""btn btn-success"">add pot</a>
        </div>
    </footer>
</main>
<link href=""https://cdn.jsdelivr.net/npm/bootstrap@5.1.2/dist/css/bootstrap-grid.css"" rel=""stylesheet"">
<link href=""https://cdn.jsdelivr.net/npm/bootstrap@5.1.2/dist/css/bootstrap.min.css"" rel=""stylesheet"">
<script src=""https://cdn.jsdelivr.net/npm/bootstrap@5.1.2/dist/js/bootstrap.bundle.min.js""></script>
");
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
