#pragma checksum "C:\Users\carl-\OneDrive\Skrivebord\repos\newTorunament\InterD\TournamentWeb\Views\Bracket\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bcc22b85d9db0e7e0a3cad07643a5c279bf548ec"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Bracket_Index), @"mvc.1.0.view", @"/Views/Bracket/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bcc22b85d9db0e7e0a3cad07643a5c279bf548ec", @"/Views/Bracket/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dd30be310ed5315e55eb7435d275890d09ecdbc7", @"/Views/_ViewImports.cshtml")]
    public class Views_Bracket_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\carl-\OneDrive\Skrivebord\repos\newTorunament\InterD\TournamentWeb\Views\Bracket\Index.cshtml"
  
    Layout = "";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<div id=""Tcontainer"" onmousedown=""mouseDownHandler(event)"">
    <div id=""BracketContainer"">

    </div>
</div>

<script src=""https://ajax.googleapis.com/ajax/libs/jquery/3.2.1/jquery.min.js""></script>
<script>
    let bracketTemplate = { ""Temp1"": [{ ""x"": 0, ""y"": 0, ""h"": 120, ""w"": -110, ""dir"": ""END"", ""Next"": 0 }], ""Temp2"": [{ ""x"": 0, ""y"": 0, ""h"": 120, ""w"": 110, ""dir"": ""R"", ""Next"": 2 }, { ""x"": 220, ""y"": 0, ""h"": 120, ""w"": 110, ""dir"": ""L"", ""Next"": 2 }, { ""x"": 110, ""y"": 120, ""h"": 120, ""w"": """", ""dir"": ""END"", ""Next"": 0 }], ""Temp3"": [{ ""x"": 0, ""y"": 0, ""h"": 120, ""w"": 110, ""dir"": ""R"", ""Next"": 3 }, { ""x"": 220, ""y"": 0, ""h"": 120, ""w"": 110, ""dir"": ""L"", ""Next"": 3 }, { ""x"": 440, ""y"": 0, ""h"": 240, ""w"": 165, ""dir"": ""L"", ""Next"": 4 }, { ""x"": 110, ""y"": 120, ""h"": 120, ""w"": 165, ""dir"": ""R"", ""Next"": 4 }, { ""x"": 275, ""y"": 240, ""h"": 120, ""w"": """", ""dir"": ""END"", ""Match"": 2 }], ""Temp4"": [{ ""x"": 0, ""y"": 0, ""h"": 120, ""w"": 110, ""dir"": ""R"", ""Match"": 0 }, { ""x"": 220, ""y"": 0, ""h"": 120, ""w"": 110, ""dir"": ""L"", ""Match"": 0 }, { ""x"": 440");
            WriteLiteral(@", ""y"": 0, ""h"": 120, ""w"": 110, ""dir"": ""R"", ""Match"": 0 }, { ""x"": 660, ""y"": 0, ""h"": 120, ""w"": 110, ""dir"": ""L"", ""Match"": 0 }, { ""x"": 110, ""y"": 120, ""h"": 120, ""w"": 220, ""dir"": ""R"", ""Match"": 1 }, { ""x"": 550, ""y"": 120, ""h"": 120, ""w"": 220, ""dir"": ""L"", ""Match"": 1 }, { ""x"": 330, ""y"": 240, ""h"": 0, ""w"": """", ""dir"": ""END"", ""Match"": 2 }], ""Temp5"": [{ ""x"": 0, ""y"": 0, ""h"": 120, ""w"": 110, ""dir"": ""R"", ""Match"": 0 }, { ""x"": 220, ""y"": 0, ""h"": 120, ""w"": 110, ""dir"": ""L"", ""Match"": 0 }, { ""x"": 440, ""y"": 0, ""h"": 120, ""w"": 110, ""dir"": ""R"", ""Match"": 0 }, { ""x"": 660, ""y"": 0, ""h"": 120, ""w"": 110, ""dir"": ""L"", ""Match"": 0 }, { ""x"": 880, ""y"": 0, ""h"": 240, ""w"": 165, ""dir"": ""L"", ""Match"": 0 }, { ""x"": 110, ""y"": 120, ""h"": 240, ""w"": 302.5, ""dir"": ""R"", ""Match"": 1 }, { ""x"": 550, ""y"": 120, ""h"": 120, ""w"": 165, ""dir"": ""R"", ""Match"": 1 }, { ""x"": 715, ""y"": 240, ""h"": 120, ""w"": 302.5, ""dir"": ""L"", ""Match"": 2 }, { ""x"": 412.5, ""y"": 360, ""h"": 120, ""w"": """", ""dir"": ""END"", ""Match"": 3 }], ""Temp6"": [{ ""x"": 0, ""y"": 0, ""h"": 120, ""w"": 110, ""dir"": ""R"" }, { ""x"": 220, ""y"": 0");
            WriteLiteral(@", ""h"": 120, ""w"": 110, ""dir"": ""L"" }, { ""x"": 440, ""y"": 0, ""h"": 120, ""w"": 110, ""dir"": ""R"" }, { ""x"": 660, ""y"": 0, ""h"": 120, ""w"": 110, ""dir"": ""L"" }, { ""x"": 880, ""y"": 0, ""h"": 120, ""w"": 110, ""dir"": ""R"" }, { ""x"": 1100, ""y"": 0, ""h"": 120, ""w"": 110, ""dir"": ""L"" }, { ""x"": 110, ""y"": 120, ""h"": 120, ""w"": 220, ""dir"": ""R"" }, { ""x"": 550, ""y"": 120, ""h"": 120, ""w"": 220, ""dir"": ""L"" }, { ""x"": 990, ""y"": 120, ""h"": 240, ""w"": 330, ""dir"": ""L"" }, { ""x"": 330, ""y"": 240, ""h"": 120, ""w"": 330, ""dir"": ""R"" }, { ""x"": 660, ""y"": 360, ""h"": 120, ""w"": """", ""dir"": ""END"" }], ""Temp7"": [{ ""x"": 0, ""y"": 0, ""h"": 120, ""w"": 110, ""dir"": ""R"" }, { ""x"": 220, ""y"": 0, ""h"": 120, ""w"": 110, ""dir"": ""L"" }, { ""x"": 440, ""y"": 0, ""h"": 120, ""w"": 110, ""dir"": ""R"" }, { ""x"": 660, ""y"": 0, ""h"": 120, ""w"": 110, ""dir"": ""L"" }, { ""x"": 880, ""y"": 0, ""h"": 120, ""w"": 110, ""dir"": ""R"" }, { ""x"": 1100, ""y"": 0, ""h"": 120, ""w"": 110, ""dir"": ""L"" }, { ""x"": 1320, ""y"": 0, ""h"": 240, ""w"": 165, ""dir"": ""L"" }, { ""x"": 110, ""y"": 120, ""h"": 120, ""w"": 220, ""dir"": ""R"" }, { ""x"": 550, ""y"": 120, ""h"": 120, ""w"": 220, ""di");
            WriteLiteral(@"r"": ""L"" }, { ""x"": 990, ""y"": 120, ""h"": 120, ""w"": 165, ""dir"": ""R"" }, { ""x"": 330, ""y"": 240, ""h"": 120, ""w"": 412.5, ""dir"": ""R"" }, { ""x"": 1155, ""y"": 240, ""h"": 120, ""w"": 412.5, ""dir"": ""L"" }, { ""x"": 742.5, ""y"": 360, ""h"": 120, ""w"": """", ""dir"": ""END"" }], ""Temp8"": [{ ""x"": 0, ""y"": 0, ""h"": 120, ""w"": 110, ""dir"": ""R"" }, { ""x"": 220, ""y"": 0, ""h"": 120, ""w"": 110, ""dir"": ""L"" }, { ""x"": 440, ""y"": 0, ""h"": 120, ""w"": 110, ""dir"": ""R"" }, { ""x"": 660, ""y"": 0, ""h"": 120, ""w"": 110, ""dir"": ""L"" }, { ""x"": 880, ""y"": 0, ""h"": 120, ""w"": 110, ""dir"": ""R"" }, { ""x"": 1100, ""y"": 0, ""h"": 120, ""w"": 110, ""dir"": ""L"" }, { ""x"": 1320, ""y"": 0, ""h"": 120, ""w"": 110, ""dir"": ""R"" }, { ""x"": 1540, ""y"": 0, ""h"": 120, ""w"": 110, ""dir"": ""L"" }, { ""x"": 110, ""y"": 120, ""h"": 120, ""w"": 330, ""dir"": ""R"" }, { ""x"": 550, ""y"": 120, ""h"": 120, ""w"": 330, ""dir"": ""L"" }, { ""x"": 990, ""y"": 120, ""h"": 120, ""w"": 220, ""dir"": ""R"" }, { ""x"": 1430, ""y"": 120, ""h"": 120, ""w"": 220, ""dir"": ""L"" }, { ""x"": 330, ""y"": 240, ""h"": 120, ""w"": 440, ""dir"": ""R"" }, { ""x"": 1210, ""y"": 240, ""h"": 120, ""w"": 440, ""dir"": ""L"" },");
            WriteLiteral(" { \"x\": 770, \"y\": 360, \"h\": 120, \"w\": \"\", \"dir\": \"END\" }] }\r\n\r\n    let userIDString = \'");
#nullable restore
#line 17 "C:\Users\carl-\OneDrive\Skrivebord\repos\newTorunament\InterD\TournamentWeb\Views\Bracket\Index.cshtml"
                   Write(ViewBag.User);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"';

    let Updates = new Object()

    let patternTemplate = {
        ""temp1"": [
            ""0""
        ],
        ""temp2"": [
            ""0,2"",
            ""1,2""
        ],
        ""temp3"": [
            ""0,3,4"",
            ""1,3,4"",
            ""2,4""
        ],
        ""temp4"": [
            ""0,4,6"",
            ""1,4,6"",
            ""2,5,6"",
            ""3,5,6""
        ],
        ""temp5"": [
            ""0,5,8"",
            ""1,5,8"",
            ""2,6,7,8"",
            ""3,6,7,8"",
            ""4,7,8""
        ],
        ""temp6"": [
            ""0,6,9,10"",
            ""1,6,9,10"",
            ""2,7,9,10"",
            ""3,7,9,10"",
            ""4,8,10"",
            ""5,8,10"",
        ],
        ""temp7"": [
            ""0,7,10,12"",
            ""1,7,10,12"",
            ""2,8,10,12"",
            ""3,8,10,12"",
            ""4,9,11,12"",
            ""5,9,11,12"",
            ""6,11,12"",
        ],
        ""temp8"": [
            ""0,8,12,14"",
            ""1,8,12,14"",
            ""2");
            WriteLiteral(@",9,12,14"",
            ""3,9,12,14"",
            ""4,10,13,14"",
            ""5,10,13,14"",
            ""6,11,13,14"",
            ""7,11,13,14"",
        ]
    }


    let Tournament;
    let TeamsArray = []
    if ($('#Tcontainer').length) {
        $(""#Tcontainer"").ready(function () {
            $.ajax({
                url: """);
#nullable restore
#line 82 "C:\Users\carl-\OneDrive\Skrivebord\repos\newTorunament\InterD\TournamentWeb\Views\Bracket\Index.cshtml"
                 Write(Url.Action("GetTournamentJson", "Bracket"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\",\r\n                type: \'POST\',\r\n                data: {\r\n                    \'id1\': ");
#nullable restore
#line 85 "C:\Users\carl-\OneDrive\Skrivebord\repos\newTorunament\InterD\TournamentWeb\Views\Bracket\Index.cshtml"
                      Write(ViewBag.id);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                },
                error: function (xhr) {
                    alert('Error: ' + xhr.statusText);
                },
                success: function (result) {
                    if (userIDString == result.userId) {
                        document.querySelector(""#Tcontainer"").innerHTML += `
                        <div onclick=""UpdateBrackets()"" class=""update-wrap"">
                            <div id=""Update-MessageWrap""><p>Update</p></div>
                            <div><img src=""/images/assets/icons/Update.png"" /></div>
                        </div>
                        `
                    }
                    TeamsArray = result.teams
                    Tournament = result;
                    drawStuff(result.bracketsize)
                },
            });
        })
    }

    let tranfx;
    let tranfy;


    function drawStuff(players) {
        let content = """";
        let rows = [1,2,3,3,4,4,4,4]
        for (let i = 0; i < bracketTemplate");
            WriteLiteral(@"[`Temp${players}`].length; i++) {
            content += `
            <div class=""player""
            id=""M${i}""
            style=""
            left: ${bracketTemplate[`Temp${players}`][i].x}px;
            bottom: ${bracketTemplate[`Temp${players}`][i].y}px;
            "">
            <p class=""teamNameText""></p>
            <div class=""hline""
            style=""
            height: ${bracketTemplate[`Temp${players}`][i].h - 30}px;
            "">

            <div class=""wline${bracketTemplate[`Temp${players}`][i].dir}""
            style=""
            width: ${bracketTemplate[`Temp${players}`][i].w -100}px;
            "">

            </div>
            </div>
            </div>
            `
        }
        let containerWidth = 220 * players;
        document.getElementById(""BracketContainer"").style.width = `${containerWidth - 220}px`

        let Crows = rows[players-1]-1
        let containerheight = 120 * Crows;
        document.getElementById(""BracketContainer"").style.he");
            WriteLiteral(@"ight = `${containerheight + 40}px`

        document.getElementById(""BracketContainer"").innerHTML = content;




        tranfx = -($(""#BracketContainer"").width() / 2)
        tranfy = -($(""#BracketContainer"").height() / 2)


        //let scrolltopos = ($(""#Tcontainer"").width() / 2)
        //let scrollMinus = (scrolltopos - (window.innerWidth / 2))
        //$(window).scrollLeft(scrollMinus)

        //let scrolltoposW = ($(""#Tcontainer"").height() / 2)
        //let scrollMinusW = (scrolltoposW - (window.innerHeight / 2))
        //$(window).scrollTop(scrollMinusW)

        console.log(TeamsArray)
        GeneratePlacements(players)
    }

    function GeneratePlacements(players) {
        for (let u = 0; u < TeamsArray.length; u++) {
            let MatchPattern = patternTemplate[`temp${players}`][u].split(',');

            let Teams = GetContestants(MatchPattern[TeamsArray[u].matchWins], players);
            if (Teams.player2) {
                document.getElementById(`M${Te");
            WriteLiteral(@"ams.player1.Index}`).classList.add(""ActiveP"")
            }

            if (MatchPattern[TeamsArray[u].matchWins] == MatchPattern[MatchPattern.length - 1]) {
                document.getElementById(`M${Teams.player1.Index}`).classList.add(""Winner"")
            }

            for (let i = 0; i <= TeamsArray[u].matchWins; i++) {

                document.getElementById(`M${MatchPattern[i]}`).children[0].innerHTML = `${TeamsArray[u].teamName}`

                if (i < TeamsArray[u].matchWins) {
                    document.getElementById(`M${MatchPattern[i]}`).classList.add(""Won"")
                }
                if (TeamsArray[u].lostGame) {
                    document.getElementById(`M${MatchPattern[i]}`).classList.add(""Out"")
                }
            }
        }
    }

    function GetContestants(PlayerOneIndex, players) {

        let test = new Object()
        for (let u = 0; u < TeamsArray.length; u++) {
            let MatchPattern = patternTemplate[`temp${players}`][u].sp");
            WriteLiteral(@"lit(',');
            if (MatchPattern[TeamsArray[u].matchWins] == PlayerOneIndex) {
                test.player1 = { ""teamId"": TeamsArray[u].teamId, ""Index"": MatchPattern[TeamsArray[u].matchWins], ""teamName"": TeamsArray[u].teamName }

                for (let i = 0; i < TeamsArray.length; i++) {
                    let MatchPatternNew = patternTemplate[`temp${Tournament.bracketsize}`][i].split(',');


                    if (TeamsArray[u].matchWins < MatchPattern.length && TeamsArray[i].matchWins < MatchPatternNew.length) {
                        if (MatchPattern[TeamsArray[u].matchWins + 1] == MatchPatternNew[TeamsArray[i].matchWins + 1]
                            && MatchPattern[0] != MatchPatternNew[0]) {
                            test.player2 = { ""teamId"": TeamsArray[i].teamId, ""Index"": MatchPatternNew[TeamsArray[i].matchWins], ""teamName"": TeamsArray[i].teamName }
                        }
                    }
                }
            }
        }
        return test;
    }

");
            WriteLiteral(@"    document.getElementById(""Tcontainer"").addEventListener(""click"", function (e) {
        if (Tournament.userId == userIDString) {
            if (e.target.classList.contains(""ActiveP"")) {
                console.log(""yes"", e.target.classList.contains(""ActiveP""))
                let Index = e.target.id.substring(1)
                SetPlacements(Index)
            }
        }
    })

    function SetPlacements(value) {

        let Teams = GetContestants(value, Tournament.bracketsize)

        document.getElementById(`M${Teams.player1.Index}`).classList.toggle(""Winteam"")
        if (Updates[Teams.player1.teamId]) {
            delete Updates[Teams.player1.teamId]
        } else {
            Updates[Teams.player1.teamId] = { ""Matchwins"": 1 }
        }

        document.getElementById(`M${Teams.player2.Index}`).classList.toggle(""Out"")
        if (Updates[Teams.player2.teamId]) {
            delete Updates[Teams.player2.teamId]
        } else {
            Updates[Teams.player2.teamId] ");
            WriteLiteral(@"= { ""Out"": true };
        }
        checkForUpdates()
    }

    function checkForUpdates() {
        if (isEmpty()) {
            document.getElementById(""Update-MessageWrap"").innerHTML = `<p>Update</p>`
        } else {
            document.getElementById(""Update-MessageWrap"").innerHTML = `<p>NEEDS UPDATE</p>`
        }
    }

    function isEmpty() {
        return Object.keys(Updates).length === 0;
    }

    function UpdateBrackets() {
        console.log(""yes"")
            $.ajax({
                url: """);
#nullable restore
#line 262 "C:\Users\carl-\OneDrive\Skrivebord\repos\newTorunament\InterD\TournamentWeb\Views\Bracket\Index.cshtml"
                 Write(Url.Action("UpdateTeams", "Bracket"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\",\r\n                type: \'POST\',\r\n                data: {\r\n                    \'id1\': ");
#nullable restore
#line 265 "C:\Users\carl-\OneDrive\Skrivebord\repos\newTorunament\InterD\TournamentWeb\Views\Bracket\Index.cshtml"
                      Write(ViewBag.id);

#line default
#line hidden
#nullable disable
            WriteLiteral(@",
                    'jsonstring': JSON.stringify(Updates)
                },
                error: function (xhr) {
                    alert('Error: ' + xhr.statusText);
                },
                success: function (result) {
                    window.location.href = result;
                },
            });
    }



    //$(window).resize(function () {
    //    let scrolltopos = ($(""#Tcontainer"").width() / 2)
    //    let scrollMinus = (scrolltopos - (window.innerWidth / 2))
    //    $(window).scrollLeft(scrollMinus)

    //    let scrolltoposW = ($(""#Tcontainer"").height() / 2)
    //    let scrollMinusW = (scrolltoposW - (window.innerHeight / 2))
    //    $(window).scrollLeft(scrollMinusW)
    //});

    let zoomamount = 1;
    let enableZoom = false;
    $(window).bind(""keydown"", function (e) {
        enableZoom = e.shiftKey;
    });

    $(window).bind(""keyup"", function (e) {
        enableZoom = e.shiftKey;
    });
        // Zoom controls
    $(window");
            WriteLiteral(@").bind('mousewheel DOMMouseScroll', function (event) {
        if (enableZoom) {
            if (event.originalEvent.wheelDelta > 0 || event.originalEvent.detail < 0) {
                if (zoomamount < 3) {
                    zoomamount += 0.1;
                }
            }
            else {
                if (zoomamount > 0.6) {
                    zoomamount -= 0.1;
                }
            }
            $('#BracketContainer').css(""transform"", ""translate("" + tranfx + ""px, "" + tranfy + ""px) scale("" + zoomamount + "")"");
        }
    });

        // drag controls
    const ele = document.getElementById(""Tcontainer"")

    let pos = { top: 0, left: 0, x: 0, y: 0 };


    const mouseDownHandler = function (e) {
        ele.style.cursor = 'grabbing';
        ele.style.userSelect = 'none';
        pos = {
            // The current scroll
            //left: $(window).scrollLeft(),
            //top: $(window).scrollTop(),

            left: (tranfx),
            top: (tran");
            WriteLiteral(@"fy),
            // Get the current mouse position

            x: e.clientX,
            y: e.clientY,
        };

        document.addEventListener('mousemove', mouseMoveHandler);
        document.addEventListener('mouseup', mouseUpHandler);
    };

    const mouseMoveHandler = function (e) {
        ele.style.cursor = 'grabbing';

        // How far the mouse has been moved
        const dx = (e.clientX - pos.x);
        const dy = (e.clientY - pos.y);

        // Scroll the element
        if ((pos.top + dy) > -1000 && (pos.top + dy) < 400) {
            tranfy = (pos.top + dy);
        }

        if ((pos.left + dx) > -1700 && (pos.left + dx) < 1000) {
            tranfx = (pos.left + dx);
        }


        $('#BracketContainer').css(""transform"", ""translate("" + tranfx + ""px, "" + tranfy + ""px) scale("" + zoomamount + "")"");
        $('#BracketContainer').css(""transform"", ""translate("" + tranfx + ""px, "" + tranfy + ""px) scale("" + zoomamount + "")"");
        //$(window).scrollTop(");
            WriteLiteral(@"pos.top - dy);
        //$(window).scrollLeft(pos.left - dx);
    };

    const mouseUpHandler = function () {
        ele.style.cursor = 'grab';
        ele.style.removeProperty('user-select');
        document.removeEventListener('mousemove', mouseMoveHandler);
    };

</script>

<style>
    .update-wrap {
        position: absolute;
        right: 12px;
        top: 14px;
        display: flex;
        width: max-content;
        align-items: center;
        z-index: 5;
        cursor: pointer;
    }

    .update-wrap p{
        font-size: 20px;
        margin: 0;
        color: white;
    }

    .update-wrap img{
        height: 28px;
        margin: 0 8px;
    }

    button {
        position: fixed;
        top: 20px;
        right: 20px;
    }

/*    body::-webkit-scrollbar {
        display: none;
    }

    body {
        -ms-overflow-style: none;
        scrollbar-width: none;
    }
*/
    body, html {
        margin: 0;
        padding: 0;
    }");
            WriteLiteral(@"

    #Tcontainer {
        cursor: grab;
        height: 100%;
        width: 100%;
        transform: translate(-50%, -50%);
        position: relative;
        left: 50%;
        top: 50%
    }

    #BracketContainer {
        transform: translate(-50%, -50%);
        position: absolute;
        left: 50%;
        top: 50%;
    }

    .player {
        background-image: url(""/images/assets/brackets/standard_container.jpg"");
        background-size: 180px 40px;
        pointer-events: none;
        transform: translateX(-50%);
        height: 40px;
        width: 180px;
        position: absolute;
        bottom: 20px;
        box-shadow: 2px 2px 6px 0px #000000a6;
    }

        .player:hover {
            cursor: pointer;
        }

        .player p {
            position: absolute;
            transform: translate(-50%, -0%);
            left: 50%;
            margin: 0;
            top: 100%;
            font-weight: bold;
            font-size: 20px;
        }");
            WriteLiteral(@"

    .hline {
        width: 2px;
        transform: translate(-50%, -100%);
        position: relative;
        left: 50%;
        /*        top: 50%;*/
        top: -10px;
        background: #215f49;
        opacity: 0.8;
    }

    .wlineR {
        height: 2px;
        position: relative;
        background: #215f49;
        opacity: 0.8;
    }

    .wlineL {
        height: 2px;
        transform: translateX(-100%);
        position: relative;
        background: #215f49;
        opacity: 0.8;
    }


    .ActiveP {
        pointer-events: initial;
        background-color: #2edfe238;
        background-blend-mode: color-burn;
        box-shadow: 0px 0px 0px 1px #2edfe2, 4px 4px 8px 0px #000000a6;
    }

        .ActiveP div {
            background: #1596ab !important;
        }

    .Winteam div {
        background: #2fe8a7 !important;
        box-shadow: 0px 0px 12px 1px #2fe8a7ba;
    }

    .Winteam {
        background-color: #ffffff00;
        box-");
            WriteLiteral(@"shadow: 0px 0px 0px 1px #2fe8a7, 0px 0px 18px 1px #2fe8a747, 4px 4px 8px 0px #000000a6 !important;
    }

    .teamNameText {
        top: 10px !important;
        color: white;
        pointer-events: none;
    }

    .Out {
        opacity: 0.7;
        pointer-events: none;
        background-color: none;
        box-shadow: 2px 2px 6px 0px #000000a6;
        background-blend-mode: unset;
    }

        .Out div {
        }

    .Won {
        background-color: #ffffff00;
        box-shadow: 0px 0px 0px 1px #2fe8a7, 4px 4px 8px 0px #000000a6 !important;
    }

        .Won div {
            background: #2fe8a7 !important;
        }

    .Winner {
        background: yellow !important;
    }

        .Winner div {
            background: yellow !important;
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
