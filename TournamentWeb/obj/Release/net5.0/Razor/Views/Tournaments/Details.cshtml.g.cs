#pragma checksum "C:\Users\lille\Desktop\New Repo\InterD\TournamentWeb\Views\Tournaments\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b73781209dfbedcbf9b1ff6d87b1e7fa0968682b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Tournaments_Details), @"mvc.1.0.view", @"/Views/Tournaments/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b73781209dfbedcbf9b1ff6d87b1e7fa0968682b", @"/Views/Tournaments/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b8cbd7db290a5ed2a2e70301dadeeaf346ef9804", @"/Views/_ViewImports.cshtml")]
    public class Views_Tournaments_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TournamentWeb.Models.Tournament>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\lille\Desktop\New Repo\InterD\TournamentWeb\Views\Tournaments\Details.cshtml"
  
    if (@Model.TournamentImage != null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"TDetailsHero\"");
            BeginWriteAttribute("style", " style=\"", 127, "\"", 194, 4);
            WriteAttributeValue("", 135, "background:", 135, 11, true);
            WriteAttributeValue(" ", 146, "url(/images/tournaments/", 147, 25, true);
#nullable restore
#line 6 "C:\Users\lille\Desktop\New Repo\InterD\TournamentWeb\Views\Tournaments\Details.cshtml"
WriteAttributeValue("", 171, Model.TournamentImage, 171, 22, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 193, ")", 193, 1, true);
            EndWriteAttribute();
            WriteLiteral("></div>\r\n");
#nullable restore
#line 7 "C:\Users\lille\Desktop\New Repo\InterD\TournamentWeb\Views\Tournaments\Details.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"TDetailsHero\" style=\"background: url(https://external-content.duckduckgo.com/iu/?u=https%3A%2F%2Fassets.gamepur.com%2Fwp-content%2Fuploads%2F2021%2F01%2F05145757%2Frocket-league-F.jpg&f=1&nofb=1);\"></div>\r\n");
#nullable restore
#line 11 "C:\Users\lille\Desktop\New Repo\InterD\TournamentWeb\Views\Tournaments\Details.cshtml"
    }


#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"TheroOpening\"></div>\r\n<section class=\"Page-Container TinfoSection\">\r\n    <h1 class=\"TinfoHeader\">");
#nullable restore
#line 16 "C:\Users\lille\Desktop\New Repo\InterD\TournamentWeb\Views\Tournaments\Details.cshtml"
                       Write(Model.TournamentName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n    <p class=\"Tinfotime\">");
#nullable restore
#line 17 "C:\Users\lille\Desktop\New Repo\InterD\TournamentWeb\Views\Tournaments\Details.cshtml"
                    Write(Model.TimeFrame);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <p>");
#nullable restore
#line 18 "C:\Users\lille\Desktop\New Repo\InterD\TournamentWeb\Views\Tournaments\Details.cshtml"
  Write(Model.TournamentInfo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <p>Contact: <a");
            BeginWriteAttribute("href", " href=\"", 702, "\"", 709, 0);
            EndWriteAttribute();
            WriteLiteral(@">Discord</a></p>
</section>

<style>
    .TinfoHeader {
        margin: 24px 0 0 0;
        font-size: 32px;
    }

    .Tinfotime {
        color: #2ee4a4;
        margin: 0;
        font-size: 12px;
    }

    .TheroOpening {
        height: 300px;
        width: 100%;
        background: radial-gradient(circle, rgba(2,0,36,0) 0%, rgb(0 0 0 / 44%) 100%);
        position: relative;
    }
    .TDetailsHero {
        height: 354px;
        position: fixed;
        top: 0;
        width: 100%;
        background-size: cover !important;
        background-position: center !important;
    }

    .TinfoSection {
        background: #22282a;
        position: relative;
        z-index: 1;
        height: max-content;
        min-height: calc(100vh - 400px)
    }
</style>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TournamentWeb.Models.Tournament> Html { get; private set; }
    }
}
#pragma warning restore 1591