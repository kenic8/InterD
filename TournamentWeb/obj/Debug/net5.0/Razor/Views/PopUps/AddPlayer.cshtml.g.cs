#pragma checksum "C:\Users\carl-\OneDrive\Skrivebord\local repos\newes\Tournamanta\interdisciplinary\TournamentWeb\Views\PopUps\AddPlayer.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0c8f7e8a0ca6892a25416d040f80dda7c5a56c49"
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
#line 1 "C:\Users\carl-\OneDrive\Skrivebord\local repos\newes\Tournamanta\interdisciplinary\TournamentWeb\Views\_ViewImports.cshtml"
using TournamentWeb;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\carl-\OneDrive\Skrivebord\local repos\newes\Tournamanta\interdisciplinary\TournamentWeb\Views\_ViewImports.cshtml"
using TournamentWeb.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0c8f7e8a0ca6892a25416d040f80dda7c5a56c49", @"/Views/PopUps/AddPlayer.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dd30be310ed5315e55eb7435d275890d09ecdbc7", @"/Views/_ViewImports.cshtml")]
    public class Views_PopUps_AddPlayer : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n<div class=\"PopupBox\">\n    <p>");
#nullable restore
#line 3 "C:\Users\carl-\OneDrive\Skrivebord\local repos\newes\Tournamanta\interdisciplinary\TournamentWeb\Views\PopUps\AddPlayer.cshtml"
   Write("http://localhost:44881/Tournaments/AddPlayer/" + TempData["id1"] + "?TeamId=" + TempData["id2"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
</div>

<style>
    .PopupBox {
        height: 300px;
        width: 700px;
        border-radius: 24px;
        background: white;
        position: absolute;
        transform: translate(-50%, -50%);
        left: 50%;
        top: 50%;
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
