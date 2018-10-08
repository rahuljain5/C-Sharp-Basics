using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PartyInviteWebApplication.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ViewResult Index()
        {
            string message =  "Welcome to my Partyyyy!";
            //ViewData["msg"] = message; 
            ViewBag.Msg = message;
            return View();
        }
    }
}