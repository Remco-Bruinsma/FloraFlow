#pragma checksum "C:\Users\Torem\Documents\semester 2\groeps project\FloraFlow\FloraFlow\Views\LoginEnRegister\Inlog.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "caab48a198f13879feaf9c373ff17dd6eedeaa42"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_LoginEnRegister_Inlog), @"mvc.1.0.view", @"/Views/LoginEnRegister/Inlog.cshtml")]
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
#line 1 "C:\Users\Torem\Documents\semester 2\groeps project\FloraFlow\FloraFlow\Views\LoginEnRegister\Inlog.cshtml"
using System.Collections.Generic;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Torem\Documents\semester 2\groeps project\FloraFlow\FloraFlow\Views\LoginEnRegister\Inlog.cshtml"
using System.ComponentModel.DataAnnotations;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Torem\Documents\semester 2\groeps project\FloraFlow\FloraFlow\Views\LoginEnRegister\Inlog.cshtml"
using System.Net;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Torem\Documents\semester 2\groeps project\FloraFlow\FloraFlow\Views\LoginEnRegister\Inlog.cshtml"
using FloraFlow.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"caab48a198f13879feaf9c373ff17dd6eedeaa42", @"/Views/LoginEnRegister/Inlog.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dad7934e448b9f15fb60d03771aadb018c7623c6", @"/Views/_ViewImports.cshtml")]
    public class Views_LoginEnRegister_Inlog : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<User>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 7 "C:\Users\Torem\Documents\semester 2\groeps project\FloraFlow\FloraFlow\Views\LoginEnRegister\Inlog.cshtml"
  
    ViewBag.Title = "SelectCategory";
    Layout = "~/Views/Shared/_Layout.cshtml";



#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 16 "C:\Users\Torem\Documents\semester 2\groeps project\FloraFlow\FloraFlow\Views\LoginEnRegister\Inlog.cshtml"
 using (Html.BeginForm("Cookies", "LoginEnRegister", FormMethod.Post, new { id = "form1" }))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <table>\r\n        <tr>\r\n            <td>\r\n                UserName:\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 24 "C:\Users\Torem\Documents\semester 2\groeps project\FloraFlow\FloraFlow\Views\LoginEnRegister\Inlog.cshtml"
           Write(Html.TextBox("UserId"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n        <tr>\r\n            <td>\r\n                Password\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 32 "C:\Users\Torem\Documents\semester 2\groeps project\FloraFlow\FloraFlow\Views\LoginEnRegister\Inlog.cshtml"
           Write(Html.Password("Password"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n        <tr>\r\n            <td colspan=\"2\">\r\n                <input type=\"submit\" value=\"login\" name=\"login\" />\r\n            </td>\r\n        </tr>\r\n    </table>\r\n");
#nullable restore
#line 41 "C:\Users\Torem\Documents\semester 2\groeps project\FloraFlow\FloraFlow\Views\LoginEnRegister\Inlog.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<!--<link rel=""stylesheet"" href=""/css/login.css"">
<script src=""~/js/login.js""></script>

<div class=""login-box"">
    <div class=""lb-header"">
        <a href=""#"" class=""active"" id=""login-box-link"">Login</a>
        <a href=""#"" id=""signup-box-link"">Sign Up</a>
    </div>

    <form method=""POST"" action=""page.aspx"">
        <div class=""u-form-group"">-->
");
            WriteLiteral("<!--");
#nullable restore
#line 54 "C:\Users\Torem\Documents\semester 2\groeps project\FloraFlow\FloraFlow\Views\LoginEnRegister\Inlog.cshtml"
Write(Html.TextBoxFor(m => m.UserId, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n<div class=\"u-form-group\">-->\r\n");
            WriteLiteral("<!--");
#nullable restore
#line 58 "C:\Users\Torem\Documents\semester 2\groeps project\FloraFlow\FloraFlow\Views\LoginEnRegister\Inlog.cshtml"
Write(Html.PasswordFor(m => m.Password));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n        </div>\r\n        <div class=\"u-form-group\">\r\n            <a href=\"");
#nullable restore
#line 62 "C:\Users\Torem\Documents\semester 2\groeps project\FloraFlow\FloraFlow\Views\LoginEnRegister\Inlog.cshtml"
                Write(Url.Action("ChangePot", "Pots", new { area = "" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\" class=\"btn btn-success\">Change</a>\r\n        </div>\r\n    </form>\r\n\r\n</div>-->\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<User> Html { get; private set; }
    }
}
#pragma warning restore 1591
