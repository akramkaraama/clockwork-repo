using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;
//using Clockwork.API;
//using Clockwork.API.Models;

namespace Clockwork.Web.Controllers
{
    public class HomeController : Controller
    {
        //private ClockworkContext Clockwork = new ClockworkContext();
        public ActionResult Index()
        {
            var mvcName = typeof(Controller).Assembly.GetName();
            var isMono = Type.GetType("Mono.Runtime") != null;

            ViewData["Version"] = mvcName.Version.Major + "." + mvcName.Version.Minor;
            ViewData["Runtime"] = isMono ? "Mono" : ".NET";

            // Using the TimeZoneInfo class to get the System TimeZones
            ReadOnlyCollection<TimeZoneInfo> timeZones = TimeZoneInfo.GetSystemTimeZones();
            List<SelectListItem> timeZoneList = new List<SelectListItem>();

            // Loop through the timezones and add each to the timeZoneList
            foreach (TimeZoneInfo timeZoneInfo in timeZones)
            {
                timeZoneList.Add(new SelectListItem { Text = timeZoneInfo.DisplayName, Value = timeZoneInfo.Id.ToString() });
            }

            return View(timeZones);
        }
    }
}
