#pragma checksum "C:\Users\carl-\OneDrive\Skrivebord\repos\newTorunament\InterD\TournamentWeb\Views\Tournaments\View.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "38dcfcc5f6765217d2ae08557fa7173a0221d959"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Tournaments_View), @"mvc.1.0.view", @"/Views/Tournaments/View.cshtml")]
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
#nullable restore
#line 4 "C:\Users\carl-\OneDrive\Skrivebord\repos\newTorunament\InterD\TournamentWeb\Views\Tournaments\View.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"38dcfcc5f6765217d2ae08557fa7173a0221d959", @"/Views/Tournaments/View.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dd30be310ed5315e55eb7435d275890d09ecdbc7", @"/Views/_ViewImports.cshtml")]
    public class Views_Tournaments_View : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TournamentWeb.Models.Tournament>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/assets/icons/TeamLeader.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "RemovePlayer", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("dadatest"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 7 "C:\Users\carl-\OneDrive\Skrivebord\repos\newTorunament\InterD\TournamentWeb\Views\Tournaments\View.cshtml"
  
    string bracketLindk = "http://" + "localhost:44881/Bracket/Index/" + Model.TournamentId + "?User=" + UserManager.GetUserId(User);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 16 "C:\Users\carl-\OneDrive\Skrivebord\repos\newTorunament\InterD\TournamentWeb\Views\Tournaments\View.cshtml"
  
    if (ViewBag.error != null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div id=\"errorLoader\"></div>\r\n");
#nullable restore
#line 20 "C:\Users\carl-\OneDrive\Skrivebord\repos\newTorunament\InterD\TournamentWeb\Views\Tournaments\View.cshtml"
    };

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div id=\"iframwrap\">\r\n");
#nullable restore
#line 24 "C:\Users\carl-\OneDrive\Skrivebord\repos\newTorunament\InterD\TournamentWeb\Views\Tournaments\View.cshtml"
      
        if (@Model.TournamentImage != null)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div id=\"balckdropBg\"");
            BeginWriteAttribute("style", " style=\"", 584, "\"", 651, 4);
            WriteAttributeValue("", 592, "background:", 592, 11, true);
            WriteAttributeValue(" ", 603, "url(/images/tournaments/", 604, 25, true);
#nullable restore
#line 27 "C:\Users\carl-\OneDrive\Skrivebord\repos\newTorunament\InterD\TournamentWeb\Views\Tournaments\View.cshtml"
WriteAttributeValue("", 628, Model.TournamentImage, 628, 22, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 650, ")", 650, 1, true);
            EndWriteAttribute();
            WriteLiteral("></div>\r\n");
#nullable restore
#line 28 "C:\Users\carl-\OneDrive\Skrivebord\repos\newTorunament\InterD\TournamentWeb\Views\Tournaments\View.cshtml"
        } 
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div id=\"balckdropBg\" style=\"background: url(https://external-content.duckduckgo.com/iu/?u=https%3A%2F%2Fassets.gamepur.com%2Fwp-content%2Fuploads%2F2021%2F01%2F05145757%2Frocket-league-F.jpg&f=1&nofb=1);\"></div>\r\n");
#nullable restore
#line 32 "C:\Users\carl-\OneDrive\Skrivebord\repos\newTorunament\InterD\TournamentWeb\Views\Tournaments\View.cshtml"
        }

    

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div id=\"balckdropOlay\"></div>\r\n    <div id=\"balckdropTexture\"></div>\r\n    <iframe");
            BeginWriteAttribute("src", " src=\"", 1030, "\"", 1049, 1);
#nullable restore
#line 37 "C:\Users\carl-\OneDrive\Skrivebord\repos\newTorunament\InterD\TournamentWeb\Views\Tournaments\View.cshtml"
WriteAttributeValue("", 1036, bracketLindk, 1036, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" frameBorder=\"0\" scrolling=\"no\" allowTransparency=\"true\"></iframe>\r\n</div>\r\n\r\n\r\n");
            WriteLiteral("\r\n\r\n\r\n\r\n<div class=\"Pcontainer Page-Container\">\r\n    <div class=\"PHeading\">\r\n        <h2>Paricipants</h2>\r\n        <button class=\"TgoodButton\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1406, "\"", 1465, 6);
            WriteAttributeValue("", 1416, "testfuck(", 1416, 9, true);
#nullable restore
#line 53 "C:\Users\carl-\OneDrive\Skrivebord\repos\newTorunament\InterD\TournamentWeb\Views\Tournaments\View.cshtml"
WriteAttributeValue("", 1425, Model.TournamentId, 1425, 19, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1444, ",", 1444, 1, true);
            WriteAttributeValue(" ", 1445, "0,", 1446, 3, true);
            WriteAttributeValue(" ", 1448, "0,", 1449, 3, true);
            WriteAttributeValue(" ", 1451, "\'CreateTeam\')", 1452, 14, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n            Join Tournament\r\n        </button>\r\n    </div>\r\n");
#nullable restore
#line 57 "C:\Users\carl-\OneDrive\Skrivebord\repos\newTorunament\InterD\TournamentWeb\Views\Tournaments\View.cshtml"
     foreach (var team in Model.Teams)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"teamwrap\">\r\n            <div class=\"teamName\">\r\n                <p>");
#nullable restore
#line 61 "C:\Users\carl-\OneDrive\Skrivebord\repos\newTorunament\InterD\TournamentWeb\Views\Tournaments\View.cshtml"
              Write(Html.DisplayFor(modelItem => team.TeamName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 62 "C:\Users\carl-\OneDrive\Skrivebord\repos\newTorunament\InterD\TournamentWeb\Views\Tournaments\View.cshtml"
                 foreach (var Attendee in team.Attendees)
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 64 "C:\Users\carl-\OneDrive\Skrivebord\repos\newTorunament\InterD\TournamentWeb\Views\Tournaments\View.cshtml"
                     if (UserManager.GetUserId(User) == Attendee.UserID && Attendee.UserStatus == "TeamLeader")
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"Addplayer\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1973, "\"", 2042, 7);
            WriteAttributeValue("", 1983, "testfuck(", 1983, 9, true);
#nullable restore
#line 66 "C:\Users\carl-\OneDrive\Skrivebord\repos\newTorunament\InterD\TournamentWeb\Views\Tournaments\View.cshtml"
WriteAttributeValue("", 1992, Model.TournamentId, 1992, 19, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2011, ",", 2011, 1, true);
#nullable restore
#line 66 "C:\Users\carl-\OneDrive\Skrivebord\repos\newTorunament\InterD\TournamentWeb\Views\Tournaments\View.cshtml"
WriteAttributeValue(" ", 2012, team.TeamId, 2013, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2025, ",", 2025, 1, true);
            WriteAttributeValue(" ", 2026, "0,", 2027, 3, true);
            WriteAttributeValue(" ", 2029, "\'AddPlayer\')", 2030, 13, true);
            EndWriteAttribute();
            WriteLiteral(">+</div>\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "38dcfcc5f6765217d2ae08557fa7173a0221d95911494", async() => {
                WriteLiteral("\r\n                            <div class=\"T-EvilButtons\">Delete Team</div>\r\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 67 "C:\Users\carl-\OneDrive\Skrivebord\repos\newTorunament\InterD\TournamentWeb\Views\Tournaments\View.cshtml"
                                                 WriteLiteral(Model.TournamentId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 67 "C:\Users\carl-\OneDrive\Skrivebord\repos\newTorunament\InterD\TournamentWeb\Views\Tournaments\View.cshtml"
                                                                                        WriteLiteral(team.TeamId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["TeamId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-TeamId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["TeamId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 70 "C:\Users\carl-\OneDrive\Skrivebord\repos\newTorunament\InterD\TournamentWeb\Views\Tournaments\View.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 70 "C:\Users\carl-\OneDrive\Skrivebord\repos\newTorunament\InterD\TournamentWeb\Views\Tournaments\View.cshtml"
                     
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n");
#nullable restore
#line 74 "C:\Users\carl-\OneDrive\Skrivebord\repos\newTorunament\InterD\TournamentWeb\Views\Tournaments\View.cshtml"
             foreach (var Attendee in team.Attendees)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"AttendeeName\">\r\n            <p>\r\n                ");
#nullable restore
#line 78 "C:\Users\carl-\OneDrive\Skrivebord\repos\newTorunament\InterD\TournamentWeb\Views\Tournaments\View.cshtml"
           Write(Html.DisplayFor(modelItem => Attendee.UserName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </p>\r\n");
#nullable restore
#line 80 "C:\Users\carl-\OneDrive\Skrivebord\repos\newTorunament\InterD\TournamentWeb\Views\Tournaments\View.cshtml"
             if (Attendee.UserStatus == "TeamLeader")
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"TLIndicator\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "38dcfcc5f6765217d2ae08557fa7173a0221d95916103", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\r\n");
#nullable restore
#line 85 "C:\Users\carl-\OneDrive\Skrivebord\repos\newTorunament\InterD\TournamentWeb\Views\Tournaments\View.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 86 "C:\Users\carl-\OneDrive\Skrivebord\repos\newTorunament\InterD\TournamentWeb\Views\Tournaments\View.cshtml"
             if (UserManager.GetUserId(User) == Attendee.UserID)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "38dcfcc5f6765217d2ae08557fa7173a0221d95917677", async() => {
                WriteLiteral("\r\n                    <div class=\"T-EvilButtons\">Leave</div>\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 88 "C:\Users\carl-\OneDrive\Skrivebord\repos\newTorunament\InterD\TournamentWeb\Views\Tournaments\View.cshtml"
                                               WriteLiteral(Model.TournamentId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 88 "C:\Users\carl-\OneDrive\Skrivebord\repos\newTorunament\InterD\TournamentWeb\Views\Tournaments\View.cshtml"
                                                                                      WriteLiteral(team.TeamId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["TeamId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-TeamId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["TeamId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 91 "C:\Users\carl-\OneDrive\Skrivebord\repos\newTorunament\InterD\TournamentWeb\Views\Tournaments\View.cshtml"
            }
            //WRONG
            else
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 95 "C:\Users\carl-\OneDrive\Skrivebord\repos\newTorunament\InterD\TournamentWeb\Views\Tournaments\View.cshtml"
                 foreach (var AttendeeN in team.Attendees)
                {
                    if (AttendeeN.UserStatus == "TeamLeader" && UserManager.GetUserId(User) == AttendeeN.UserID)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "38dcfcc5f6765217d2ae08557fa7173a0221d95921468", async() => {
                WriteLiteral("\r\n                            <div class=\"T-EvilButtons\">Remove</div>\r\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 99 "C:\Users\carl-\OneDrive\Skrivebord\repos\newTorunament\InterD\TournamentWeb\Views\Tournaments\View.cshtml"
                                                                     WriteLiteral(Model.TournamentId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 99 "C:\Users\carl-\OneDrive\Skrivebord\repos\newTorunament\InterD\TournamentWeb\Views\Tournaments\View.cshtml"
                                                                                                            WriteLiteral(team.TeamId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["TeamId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-TeamId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["TeamId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 99 "C:\Users\carl-\OneDrive\Skrivebord\repos\newTorunament\InterD\TournamentWeb\Views\Tournaments\View.cshtml"
                                                                                                                                            WriteLiteral(Attendee.UserID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["UserID"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-UserID", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["UserID"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 102 "C:\Users\carl-\OneDrive\Skrivebord\repos\newTorunament\InterD\TournamentWeb\Views\Tournaments\View.cshtml"
                    }
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 103 "C:\Users\carl-\OneDrive\Skrivebord\repos\newTorunament\InterD\TournamentWeb\Views\Tournaments\View.cshtml"
                 
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n");
#nullable restore
#line 106 "C:\Users\carl-\OneDrive\Skrivebord\repos\newTorunament\InterD\TournamentWeb\Views\Tournaments\View.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 107 "C:\Users\carl-\OneDrive\Skrivebord\repos\newTorunament\InterD\TournamentWeb\Views\Tournaments\View.cshtml"
             for (int i = 0; i < 5 - team.Attendees.Count; i++)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"AttendeeName\">\r\n                    <div id=\"UseShipAddr\"");
            BeginWriteAttribute("onclick", " onclick=\"", 3854, "\"", 3923, 7);
            WriteAttributeValue("", 3864, "testfuck(", 3864, 9, true);
#nullable restore
#line 110 "C:\Users\carl-\OneDrive\Skrivebord\repos\newTorunament\InterD\TournamentWeb\Views\Tournaments\View.cshtml"
WriteAttributeValue("", 3873, Model.TournamentId, 3873, 19, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3892, ",", 3892, 1, true);
#nullable restore
#line 110 "C:\Users\carl-\OneDrive\Skrivebord\repos\newTorunament\InterD\TournamentWeb\Views\Tournaments\View.cshtml"
WriteAttributeValue(" ", 3893, team.TeamId, 3894, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3906, ",", 3906, 1, true);
            WriteAttributeValue(" ", 3907, "0,", 3908, 3, true);
            WriteAttributeValue(" ", 3910, "\'AddPlayer\')", 3911, 13, true);
            EndWriteAttribute();
            WriteLiteral(">Empty</div>\r\n                </div>\r\n");
#nullable restore
#line 112 "C:\Users\carl-\OneDrive\Skrivebord\repos\newTorunament\InterD\TournamentWeb\Views\Tournaments\View.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n");
#nullable restore
#line 114 "C:\Users\carl-\OneDrive\Skrivebord\repos\newTorunament\InterD\TournamentWeb\Views\Tournaments\View.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n\r\n\r\n\r\n<script src=\"https://ajax.googleapis.com/ajax/libs/jquery/3.2.1/jquery.min.js\"></script>\r\n<script>\r\n    if ($(\'#errorLoader\').length) {\r\n        $(\"#errorLoader\").ready(function () {\r\n            testfuck(0, 0, 0, \"");
#nullable restore
#line 124 "C:\Users\carl-\OneDrive\Skrivebord\repos\newTorunament\InterD\TournamentWeb\Views\Tournaments\View.cshtml"
                          Write(ViewBag.error);

#line default
#line hidden
#nullable disable
            WriteLiteral(@""");
        })
    }

</script>


<style>

    .TLIndicator {
        flex-grow: 1;
        position: relative;
    }

    .TLIndicator img {
        height: 20px;
        position: absolute;
        transform: translate(-50%, -50%);
        top: 45%;
        left: 20px;
    }

    .TgoodButton {
        width: 148px;
        margin: 0 24px;
        height: 34px;
        background: #2a9670;
        border: none;
        border-radius: 4px;
        color: white;
        font-size: 16px;
        cursor: pointer;
    }

    .PHeading {
        height: 64px;
        width: 100%;
        background: #1c2123;
        border-radius: 12px;
        display: flex;
        align-items: center;
        justify-content: space-between;
        margin-bottom: 12px;
    }

    .PHeading h2 {
        margin: 0 24px;
    }

    .Addplayer {
        position: absolute;
        color: #2fe8a7;
        right: 0;
        top: 0;
        font-size: 32px;
        font-weight: b");
            WriteLiteral(@"old;
        cursor: pointer;
        margin: 0 12px;
    }

    .T-EvilButtons {
        width: max-content;
        padding: 1px 6px;
        border-radius: 4px;
        color: #fd5151;
        color: white;
        background: #fd5151;
    }

    .Facontainer {
        background: #22282a;
    }

    #iframwrap {
        position: relative;
        width: 100%;
        height: 70vh;
    }

        #iframwrap div {
            z-index: 0;
            position: absolute;
            height: 100%;
            width: 100%;
        }

    #balckdropBg {
        opacity: 1;
        background-size: cover !important;
    }

    #balckdropOlay {
        background: rgb(22,26,28);
        background: linear-gradient(0deg, rgba(22,26,28,1) 0%, rgba(22,26,28,0.95) 40%, rgba(22,26,28,0.9) 80%, rgba(22,26,28,0.8) 100%);
    }

    #balckdropTexture {
        background: url(/images/assets/brackets/grid.jpg);
        mix-blend-mode: multiply;
        background-size: 64px;
  ");
            WriteLiteral(@"      opacity: 0.3;
    }


    iframe {
        position: absolute;
        height: 100%;
        width: 100%;
    }

    #Tcontainer {
        margin-top: 24px;
        background: grey;
        height: 40vh;
        width: 100%;
    }


    .Pcontainer {
        height: auto;
        display: flex;
        flex-wrap: wrap;
        margin: 24px 0 84px 0 ;
    }

    .teamwrap {
        width: 254px;
        height: max-content;
        margin: 12px;
        border-radius: 8px;
        overflow: hidden;
        box-shadow: 0px 0px 0px 1px #2fe8a7, 2px 2px 8px 0 black;
    }

    .AttendeeName:nth-child(odd) {
        background: #1c2123;
    }

    .teamName {
        position: relative;
        color: white;
        background: #1c2123;
        padding: 8px;
        border-bottom: 2px solid #2fe8a7;
    }

        .teamName p {
            margin: 0 0 8px 0;
            font-weight: bold;
            font-size: 18px;
        }

    .AttendeeName {
       ");
            WriteLiteral(" color: grey;\r\n        display: flex;\r\n        justify-content: space-between;\r\n        padding: 6px 8px;\r\n    }\r\n\r\n    .AttendeeName p{\r\n        margin: 0;\r\n    }\r\n</style>\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<AppUser> UserManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager<AppUser> SignInManager { get; private set; }
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
