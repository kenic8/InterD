using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TournamentWeb.Models.ViewModels;

namespace TournamentWeb.Controllers
{
    public class PopupController : Controller
    {

        public string Get()
        {
            var url = this.Url.Link("Default", new { Controller = "Tournament", Action = "AddPlayer", param1 = 1, param2 = "somestring" });
            return url;
        }

        [HttpPost]
        public ActionResult InitPopUp(int id1, int id2, int id3, string PopupView)
        {
            TempData["id1"] = id1;
            TempData["id2"] = id2;
            TempData["id3"] = id3;

            //TempData["domain"] = HttpContextAccessor.HttpContext.Request.Host.Value;
            //TempData["scheme"] = HttpContextAccessor.HttpContext.Request.Scheme;

            //var etnamve = TempData["scheme"];

            if (PopupView.Contains("Error")) {
                string[] tmp = PopupView.Split('-');
                TempData["PopupView"] = tmp[0];
                TempData["ErrorMsg"] = tmp[1];
            } else
            {
                TempData["PopupView"] = PopupView;

            }


            

            string url = this.Url.ActionLink("AddPlayer", "Tournaments", new { id = id1, TeamId = id2 });
            TempData["id4"] = url;
            return PartialView("PopUp");
        }

        //add return action intead of frontend
    }
}
