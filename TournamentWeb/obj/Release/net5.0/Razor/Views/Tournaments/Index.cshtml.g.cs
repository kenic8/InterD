#pragma checksum "C:\Users\carl-\OneDrive\Skrivebord\repos\newTorunament\InterD\TournamentWeb\Views\Tournaments\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "82508c953cec88a449285cb332f8a8db24f4d8d8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Tournaments_Index), @"mvc.1.0.view", @"/Views/Tournaments/Index.cshtml")]
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
#line 1 "C:\Users\carl-\OneDrive\Skrivebord\repos\newTorunament\InterD\TournamentWeb\Views\_ViewImports.cshtml"
using TournamentWeb;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\carl-\OneDrive\Skrivebord\repos\newTorunament\InterD\TournamentWeb\Views\_ViewImports.cshtml"
using TournamentWeb.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"82508c953cec88a449285cb332f8a8db24f4d8d8", @"/Views/Tournaments/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dd30be310ed5315e55eb7435d275890d09ecdbc7", @"/Views/_ViewImports.cshtml")]
    public class Views_Tournaments_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<TournamentWeb.Models.Tournament>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-search"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Tournaments", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("Icon"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/assets/Landing/att.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/assets/Landing/teams.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/assets/Landing/dateicon.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("T_element"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "OverView", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\carl-\OneDrive\Skrivebord\repos\newTorunament\InterD\TournamentWeb\Views\Tournaments\Index.cshtml"
   
    ViewData["Title"] = "Tournaments"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"TorunamentsPage Page Page-Container\">\r\n    <h1>Tournaments</h1>\r\n\r\n    <div class=\"SearchBar-Wrap\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "82508c953cec88a449285cb332f8a8db24f4d8d87117", async() => {
                WriteLiteral("\r\n            <div class=\"SearchWrap\">\r\n                <input type=\"text\" name=\"SearchString\" />\r\n                <label for=\"SearchString\">Search</label>\r\n                <button type=\"submit\">Filter</button>\r\n            </div>\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n\r\n    <div class=\"Tournaments-Container\">\r\n");
#nullable restore
#line 21 "C:\Users\carl-\OneDrive\Skrivebord\repos\newTorunament\InterD\TournamentWeb\Views\Tournaments\Index.cshtml"
         foreach (var T in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "82508c953cec88a449285cb332f8a8db24f4d8d89429", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 24 "C:\Users\carl-\OneDrive\Skrivebord\repos\newTorunament\InterD\TournamentWeb\Views\Tournaments\Index.cshtml"
             if (T.TournamentImage != null)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <div class=\"T_element-backdrop\"");
                BeginWriteAttribute("style", " style=\"", 850, "\"", 912, 3);
                WriteAttributeValue("", 858, "background:url(/images/tournaments/", 858, 35, true);
#nullable restore
#line 26 "C:\Users\carl-\OneDrive\Skrivebord\repos\newTorunament\InterD\TournamentWeb\Views\Tournaments\Index.cshtml"
WriteAttributeValue("", 893, T.TournamentImage, 893, 18, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 911, ")", 911, 1, true);
                EndWriteAttribute();
                WriteLiteral(">\r\n                        <span>");
#nullable restore
#line 27 "C:\Users\carl-\OneDrive\Skrivebord\repos\newTorunament\InterD\TournamentWeb\Views\Tournaments\Index.cshtml"
                         Write(T.TournamentName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\r\n                    </div>\r\n");
#nullable restore
#line 29 "C:\Users\carl-\OneDrive\Skrivebord\repos\newTorunament\InterD\TournamentWeb\Views\Tournaments\Index.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <div class=\"T_element-backdrop\" style=\"background:url(/images/assets/placeholder.jpg)\">\r\n                        <span>");
#nullable restore
#line 33 "C:\Users\carl-\OneDrive\Skrivebord\repos\newTorunament\InterD\TournamentWeb\Views\Tournaments\Index.cshtml"
                         Write(T.TournamentName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\r\n                    </div>\r\n");
#nullable restore
#line 35 "C:\Users\carl-\OneDrive\Skrivebord\repos\newTorunament\InterD\TournamentWeb\Views\Tournaments\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            <div class=\"T_element-info\">\r\n                <div><span> ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "82508c953cec88a449285cb332f8a8db24f4d8d812010", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
#nullable restore
#line 38 "C:\Users\carl-\OneDrive\Skrivebord\repos\newTorunament\InterD\TournamentWeb\Views\Tournaments\Index.cshtml"
                                                                                 Write(T.ParticipantsAmount);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span></div>\r\n                <div><span> ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "82508c953cec88a449285cb332f8a8db24f4d8d813524", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(" ");
#nullable restore
#line 39 "C:\Users\carl-\OneDrive\Skrivebord\repos\newTorunament\InterD\TournamentWeb\Views\Tournaments\Index.cshtml"
                                                                                    Write(T.Teams.Count);

#line default
#line hidden
#nullable disable
                WriteLiteral(" / ");
#nullable restore
#line 39 "C:\Users\carl-\OneDrive\Skrivebord\repos\newTorunament\InterD\TournamentWeb\Views\Tournaments\Index.cshtml"
                                                                                                     Write(T.Bracketsize);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span></div>\r\n                <div><span>");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "82508c953cec88a449285cb332f8a8db24f4d8d815419", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(" ");
#nullable restore
#line 40 "C:\Users\carl-\OneDrive\Skrivebord\repos\newTorunament\InterD\TournamentWeb\Views\Tournaments\Index.cshtml"
                                                                                      Write(T.TimeFrame.ToString("dd/MM HH:mm"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</span></div>\r\n            </div>\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 23 "C:\Users\carl-\OneDrive\Skrivebord\repos\newTorunament\InterD\TournamentWeb\Views\Tournaments\Index.cshtml"
                                                     WriteLiteral(T.TournamentId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 43 "C:\Users\carl-\OneDrive\Skrivebord\repos\newTorunament\InterD\TournamentWeb\Views\Tournaments\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 44 "C:\Users\carl-\OneDrive\Skrivebord\repos\newTorunament\InterD\TournamentWeb\Views\Tournaments\Index.cshtml"
         for (int i = 0; i < 6; i++)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"search-placeholder\"></div>\r\n");
#nullable restore
#line 47 "C:\Users\carl-\OneDrive\Skrivebord\repos\newTorunament\InterD\TournamentWeb\Views\Tournaments\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    </div>
</div>

<style>

    .Icon {
        float: left;
        width: 10%;
    }

    .SearchBar-Wrap {
        padding: 14px;
        background: #1c2123;
        border-radius: 4px;
    }

    .form-search input {
        width: 212px;
        height: 32px;
        border-radius: 4px;
        border: 0;
        padding: 0 12px;
    }

    .SearchWrap {
        position: relative;
        width: max-content;
        display: flex;
    }

    .form-search label {
        position: absolute;
        padding: 0 12px;
        color: white;
        top: 0;
        opacity: 0.7;
    }

    .form-search input:focus + label {
        opacity: 0;
    }

    .form-search button {
        width: 112px;
        height: 34px;
        margin: 0 8px;
        background: #2a9670;
        border: none;
        border-radius: 4px;
        color: white;
        font-size: 16px;
        cursor: pointer;
    }

    .form-search [type=text] {
        background: #151c1f");
            WriteLiteral(@";
        border: 1px solid #d6d6d6;
        color: white;
    }

        .form-search [type=text]:focus {
            background: #151c1f;
            border: 1px solid #2fe8a7;
            color: white;
            outline: none;
        }

    .Tournaments-Container {
        display: flex;
        width: 100%;
        flex-wrap: wrap;
        margin: 12px 0 120px 0;
    }

    .search-placeholder {
        height: 0px;
        margin: 12px;
        flex-basis: 200px;
        flex-grow: 1;
    }

    .T_element {
        transition: transform ease-in-out 0.2s;
        height: 300px;
        border-radius: 12px;
        text-align: center;
        margin: 12px;
        flex-basis: 200px;
        flex-grow: 1;
        background: #1c2123;
        overflow: hidden;
        box-shadow: 2px 2px 4px 0px #00000061;
    }


        .T_element:hover {
            transform: scale(1.1)
        }

    .T_element-backdrop {
        width: 100%;
        height: 50%;
      ");
            WriteLiteral(@"  background: #1b1b1b;
        background-size: cover !important;
        background-position: center !important;
        position: relative;
    }

        .T_element-backdrop span {
            width: 100%;
            height: max-content;
            position: absolute;
            bottom: 0;
            padding: 8px 0;
            left: 0;
            background: #0a0909ed;
        }

    .T_element-info {
        width: 100%;
        height: 50%;
    }

        .T_element-info div:nth-child(odd) {
            background: #22282a;
        }

        .T_element-info div {
            width: 100%;
            height: 33%;
            display: flex;
            align-items: center;
        }

            .T_element-info div span {
                color: #d6d6d6;
                position: relative;
                width: 100%;
            }

            .T_element-info div span img{
                color: #d6d6d6;
                position: absolute;
                lef");
            WriteLiteral("t: 10px;\r\n                height: 20px;\r\n            }\r\n</style>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<TournamentWeb.Models.Tournament>> Html { get; private set; }
    }
}
#pragma warning restore 1591
