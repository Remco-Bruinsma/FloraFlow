#pragma checksum "C:\Users\Torem\Documents\semester 2\groeps project\FloraFlow\FloraFlow\Views\Plants\Plants.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3a3895cbf8c8ab13825912104ae846f7877fe8be"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Plants_Plants), @"mvc.1.0.view", @"/Views/Plants/Plants.cshtml")]
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
#line 1 "C:\Users\Torem\Documents\semester 2\groeps project\FloraFlow\FloraFlow\Views\Plants\Plants.cshtml"
using System.Collections.Generic;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Torem\Documents\semester 2\groeps project\FloraFlow\FloraFlow\Views\Plants\Plants.cshtml"
using System.ComponentModel.DataAnnotations;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Torem\Documents\semester 2\groeps project\FloraFlow\FloraFlow\Views\Plants\Plants.cshtml"
using System.Net;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Torem\Documents\semester 2\groeps project\FloraFlow\FloraFlow\Views\Plants\Plants.cshtml"
using FloraFlow.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3a3895cbf8c8ab13825912104ae846f7877fe8be", @"/Views/Plants/Plants.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dad7934e448b9f15fb60d03771aadb018c7623c6", @"/Views/_ViewImports.cshtml")]
    public class Views_Plants_Plants : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-bs-spy", new global::Microsoft.AspNetCore.Html.HtmlString("scroll"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-bs-offset", new global::Microsoft.AspNetCore.Html.HtmlString("200"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 6 "C:\Users\Torem\Documents\semester 2\groeps project\FloraFlow\FloraFlow\Views\Plants\Plants.cshtml"
  
    ViewBag.Title = "SelectCategory";
    Layout = "~/Views/Shared/_Layout.cshtml";
    List<int> plants = ViewData["plants"] as List<int>;
    var plantsJsons = (PlantJson_QuickType.PlantsJson[])ViewData["plantJson"];

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

        .card {
            box-shadow: 0 4px 8px 0 rgba(0,0,0,0.2);
            transition: 0.3s;
            width: 40%;
        }

        body {
            font-family: Arial, Helvetica, sans-serif;
        }



        .flip-card {
            background-color: transparent;
            width: 300px;
            height: 500px;
            perspective: 1000px;
        }



        .flip-card-inner {
            position: relative;
            width: 100%;
            height: 100%;
            text-align: center;
            transition: transform 0.6s;
            transform-style: preserve-3d;
            box-shadow: 0 4px 8px 0 rgba(0,0,0,0.2);
        }



        .flip-card:hover .flip-card-inner {
            transform: rotat");
            WriteLiteral(@"eY(180deg);
        }



        .flip-card-front, .flip-card-back {
            position: absolute;
            width: 100%;
            height: 100%;
            -webkit-backface-visibility: hidden;
            backface-visibility: hidden;
        }



        .flip-card-front {
            background-color: #bbb;
            color: black;
        }



        .flip-card-back {
            background-color: #2980b9;
            color: white;
            transform: rotateY(180deg);
        }
    </style>



</header>

<main>
    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3a3895cbf8c8ab13825912104ae846f7877fe8be6496", async() => {
                WriteLiteral(@"
        <section class=""py-5 text-center container"">
            <div class=""row py-lg-4"">
                <div class=""col-lg-6 col-md-8 mx-auto"">
                    <h1 class=""fw-light"">Plants</h1>
                    <p class=""lead text-muted"">pick you new flower  </p>

                </div>
            </div>
        </section>
        <div class=""container"">
            <div class=""row row-cols-1 row-cols-sm-2 row-cols-md-3 g-3"">
");
#nullable restore
#line 123 "C:\Users\Torem\Documents\semester 2\groeps project\FloraFlow\FloraFlow\Views\Plants\Plants.cshtml"
                 foreach(PlantJson_QuickType.PlantsJson plantsJson in plantsJsons)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <div class=\"flip-card\">\r\n                    <div class=\"flip-card-inner\">\r\n                        <div class=\"flip-card-front\">\r\n                            <img");
                BeginWriteAttribute("src", " src=\"", 3843, "\"", 3864, 1);
#nullable restore
#line 128 "C:\Users\Torem\Documents\semester 2\groeps project\FloraFlow\FloraFlow\Views\Plants\Plants.cshtml"
WriteAttributeValue("", 3849, plantsJson.Url, 3849, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("alt", " alt=\"", 3865, "\"", 3892, 1);
#nullable restore
#line 128 "C:\Users\Torem\Documents\semester 2\groeps project\FloraFlow\FloraFlow\Views\Plants\Plants.cshtml"
WriteAttributeValue("", 3871, plantsJson.PlantName, 3871, 21, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" style=\"width:300px;height:500px;\" />\r\n                        </div>\r\n                        <div class=\"flip-card-back\">\r\n                            <h1>\"");
#nullable restore
#line 131 "C:\Users\Torem\Documents\semester 2\groeps project\FloraFlow\FloraFlow\Views\Plants\Plants.cshtml"
                            Write(plantsJson.PlantName);

#line default
#line hidden
#nullable disable
                WriteLiteral("\"</h1>\r\n                            <p>");
#nullable restore
#line 132 "C:\Users\Torem\Documents\semester 2\groeps project\FloraFlow\FloraFlow\Views\Plants\Plants.cshtml"
                          Write(plantsJson.PlantDescription);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                            <p>We love that plant</p>\r\n                            <div class=\"btn-group\">\r\n                                <a");
                BeginWriteAttribute("href", " href=\"", 4287, "\"", 4363, 1);
#nullable restore
#line 135 "C:\Users\Torem\Documents\semester 2\groeps project\FloraFlow\FloraFlow\Views\Plants\Plants.cshtml"
WriteAttributeValue("", 4294, Url.Action("Changeplants", "Plants", new { plant = plantsJson.Id, }), 4294, 69, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"btn btn-success\">Add to pot</a>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 140 "C:\Users\Torem\Documents\semester 2\groeps project\FloraFlow\FloraFlow\Views\Plants\Plants.cshtml"
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("            </div>\r\n        </div>\r\n        <footer>\r\n          © 2021 - FloraFlow - Privacy\r\n        </footer>\r\n        \r\n        \r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</main>\r\n\r\n\r\n\r\n\r\n\r\n<link href=\"https://cdn.jsdelivr.net/npm/bootstrap@5.1.2/dist/css/bootstrap.min.css\" rel=\"stylesheet\">\r\n<script src=\"https://cdn.jsdelivr.net/npm/bootstrap@5.1.2/dist/js/bootstrap.bundle.min.js\"></script>\r\n\r\n");
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
