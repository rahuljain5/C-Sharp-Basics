using PartyInviteWebApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace PartyInviteWebApplication.Controllers
{
    
    public class PartyInviteController : Controller
    {
        static public int Count { get; set; }
        // GET: PartyInvite
        [HttpGet]
        public ActionResult RSVP()
        {
            return View();
        }
        [HttpPost]
        public ActionResult RSVP(Guest guest)
        {
            if(!this.ModelState.IsValid)
                return View();
            //string gname = Request["name"];
            //string mobile = Request["mobile"];
            //string email = Request["email"];
            //int count = int.Parse(Request["count"]);
            ViewBag.Name = guest.Name;
            ViewBag.total = Count;
            Count += guest.Count;
            return View("Thanks");
        }
    }
}