<<<<<<< HEAD
#pragma checksum "C:\Users\carl-\OneDrive\Skrivebord\repos\newTorunament\InterD\TournamentWeb\Views\PopUps\AddPlayer.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "711a08083ade43d855b3529e08d3863f7a0dcf41"
=======
#pragma checksum "C:\Users\lille\Desktop\New Repo\InterD\TournamentWeb\Views\PopUps\AddPlayer.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a10be9fb9e88fb2f4bf47a9d976265eaaf1d28af"
>>>>>>> main
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_PopUps_AddPlayer), @"mvc.1.0.view", @"/Views/PopUps/AddPlayer.cshtml")]
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
<<<<<<< HEAD
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"711a08083ade43d855b3529e08d3863f7a0dcf41", @"/Views/PopUps/AddPlayer.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dd30be310ed5315e55eb7435d275890d09ecdbc7", @"/Views/_ViewImports.cshtml")]
=======
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a10be9fb9e88fb2f4bf47a9d976265eaaf1d28af", @"/Views/PopUps/AddPlayer.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b8cbd7db290a5ed2a2e70301dadeeaf346ef9804", @"/Views/_ViewImports.cshtml")]
>>>>>>> main
    public class Views_PopUps_AddPlayer : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"PopupBox\">\r\n    <p class=\"Inv-Header\">Invite Link:</p>\r\n    <div class=\"Inv-Wrap\">\r\n        <div class=\"copyIcon\" onclick=\"CopyLink()\">\r\n\r\n        </div>\r\n        <div class=\"invitelink\">\r\n            <p>");
#nullable restore
<<<<<<< HEAD
#line 9 "C:\Users\carl-\OneDrive\Skrivebord\repos\newTorunament\InterD\TournamentWeb\Views\PopUps\AddPlayer.cshtml"
          Write(TempData["id4"]);
=======
#line 9 "C:\Users\lille\Desktop\New Repo\InterD\TournamentWeb\Views\PopUps\AddPlayer.cshtml"
           Write("http://localhost:44881/Tournaments/AddPlayer/" + TempData["id1"] + "?TeamId=" + TempData["id2"]);
>>>>>>> main

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
        </div>
    </div>
</div>

<script>
    function CopyLink() {
        console.log(""dada"")
        document.getElementsByClassName(""Inv-Wrap"")[0].style.background = ""#2fe8a7""
        var elem = document.createElement(""textarea"");
        document.body.appendChild(elem);
        elem.value = """);
#nullable restore
<<<<<<< HEAD
#line 20 "C:\Users\carl-\OneDrive\Skrivebord\repos\newTorunament\InterD\TournamentWeb\Views\PopUps\AddPlayer.cshtml"
                 Write(TempData["id4"]);
=======
#line 20 "C:\Users\lille\Desktop\New Repo\InterD\TournamentWeb\Views\PopUps\AddPlayer.cshtml"
                  Write("http://localhost:44881/Tournaments/AddPlayer/" + TempData["id1"] + "?TeamId=" + TempData["id2"]);
>>>>>>> main

#line default
#line hidden
#nullable disable
            WriteLiteral(@"""
        elem.select();
        document.execCommand(""copy"");
        document.body.removeChild(elem);
    }
</script>

<style>
    .invitelink {
        background: #ffffff8f;
        flex-grow: 1;
        display: flex;
        align-items: center;
    }

    .invitelink p{
        color: #000000bd;
        margin: 0 0 0 12px;
        font-size: 18px;
        font-weight: bold;
    }
    .copyIcon {
        width: 48px;
        margin-right: 8px;
        background-image: url(/images/assets/icons/copy.png);
        background-size: 34px;
        background-repeat: no-repeat;
        background-position: 11px 50%;
        cursor: pointer;
    }

    .PopupBox {
        height: 120px;
        width: 584px;
        border-radius: 24px;
        background: white;
        position: absolute;
        transform: translate(-50%, -50%);
        left: 50%;
        top: 50%;
        background: #1c2123;
        padding: 12px 42px;
    }

    .Inv-Wrap {
        width: 100%");
            WriteLiteral(@";
        height: 48px;
        background: #939798;
        display: flex;
        border-radius: 12px;
        overflow: hidden;
    }

    .Inv-Header {
        padding: 0 4px;
        font-weight: bold;
        color: #2fe8a7 !important;
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
