#pragma checksum "C:\Users\lille\Desktop\New Repo\InterD\TournamentWeb\Views\Shared\Components\UserTournaments\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0beed1688dbf1e914bc0e99a88fd1ea6072f5971"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_UserTournaments_Default), @"mvc.1.0.view", @"/Views/Shared/Components/UserTournaments/Default.cshtml")]
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
#line 1 "C:\Users\lille\Desktop\New Repo\InterD\TournamentWeb\Views\_ViewImports.cshtml"
using TournamentWeb;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\lille\Desktop\New Repo\InterD\TournamentWeb\Views\_ViewImports.cshtml"
using TournamentWeb.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0beed1688dbf1e914bc0e99a88fd1ea6072f5971", @"/Views/Shared/Components/UserTournaments/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b8cbd7db290a5ed2a2e70301dadeeaf346ef9804", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_UserTournaments_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\lille\Desktop\New Repo\InterD\TournamentWeb\Views\Shared\Components\UserTournaments\Default.cshtml"
  
    ViewData["Title"] = "View";

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\lille\Desktop\New Repo\InterD\TournamentWeb\Views\Shared\Components\UserTournaments\Default.cshtml"
  
    if (ViewBag.CreatedTournaments.Count != 0)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <p>Your Tournaments created</p>\r\n");
#nullable restore
#line 10 "C:\Users\lille\Desktop\New Repo\InterD\TournamentWeb\Views\Shared\Components\UserTournaments\Default.cshtml"
             foreach (var T in ViewBag.CreatedTournaments)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <a class=\"flex-inner\" href=\"#\" style=\"text-decoration:none\">\r\n                    <div class=\"side1\">\r\n");
#nullable restore
#line 14 "C:\Users\lille\Desktop\New Repo\InterD\TournamentWeb\Views\Shared\Components\UserTournaments\Default.cshtml"
                         if (T.TournamentImage != null)
                        {
                            

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <img");
            BeginWriteAttribute("src", " src=\"", 492, "\"", 536, 2);
            WriteAttributeValue("", 498, "/images/tournaments/", 498, 20, true);
#nullable restore
#line 17 "C:\Users\lille\Desktop\New Repo\InterD\TournamentWeb\Views\Shared\Components\UserTournaments\Default.cshtml"
WriteAttributeValue("", 518, T.TournamentImage, 518, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n");
#nullable restore
#line 18 "C:\Users\lille\Desktop\New Repo\InterD\TournamentWeb\Views\Shared\Components\UserTournaments\Default.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </div>\r\n                    <div class=\"side2\">\r\n                        <div class=\"inner-2\">\r\n                            \r\n                            <h2>");
#nullable restore
#line 23 "C:\Users\lille\Desktop\New Repo\InterD\TournamentWeb\Views\Shared\Components\UserTournaments\Default.cshtml"
                           Write(T.TournamentName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                            <p>");
#nullable restore
#line 24 "C:\Users\lille\Desktop\New Repo\InterD\TournamentWeb\Views\Shared\Components\UserTournaments\Default.cshtml"
                          Write(T.TimeFrame);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        </div>\r\n                        \r\n                    </div>\r\n                </a>\r\n");
#nullable restore
#line 29 "C:\Users\lille\Desktop\New Repo\InterD\TournamentWeb\Views\Shared\Components\UserTournaments\Default.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 29 "C:\Users\lille\Desktop\New Repo\InterD\TournamentWeb\Views\Shared\Components\UserTournaments\Default.cshtml"
             
        }

    

#line default
#line hidden
#nullable disable
            WriteLiteral(@"




<style>
    .flex-inner {
     display:inline-block;
      width:100%;
      position:absolute;
      float:left;
      right:0;
    }

        .flex-inner > .side1 {
            width: 50%;
            position:relative;
            right:0;
        }


    .flex-inner > .side1 > img {
             width: 30%;
            }

        .flex-inner > .side2 {
            width: 100%;
            position: relative;
            right: 0;
        }
    .inner-2 {
        margin-top: 100%;
        right: 0;
        width: 100%;
    }
    .inner-2 > h1,p {
        padding:10%;
        
    }

     
</style>

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
