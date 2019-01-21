using CrossvertiseCalendar.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CrossvertiseCalendar.Controllers
{
    public class CalendarController : Controller
    {
        // GET: Calendar
        public ActionResult Index(string id)
        {
            ViewBag.check = false;
            int month;
            int.TryParse(id, out month);
            if (month > 0 && month < 13)
            {
                CalendarService calendarService = new CalendarService();
                var result = calendarService.GetCalendarEntriesByMonth(month);
                HighlightMonth(month);
                if (result.Count > 0)
                {
                    ViewBag.check = true;
                    return View(result);
                }
            }
            return View();
        }

        [NonAction]
        private void HighlightMonth(int month)
        {
            switch (month)
            {
                case 1:
                    ViewBag.selectJan = "active";
                    break;
                case 2:
                    ViewBag.selectFeb = "active";
                    break;
                case 3:
                    ViewBag.selectMar = "active";
                    break;
                case 4:
                    ViewBag.selectApr = "active";
                    break;
                case 5:
                    ViewBag.selectMay = "active";
                    break;
                case 6:
                    ViewBag.selectJun = "active";
                    break;
                case 7:
                    ViewBag.selectJul = "active";
                    break;
                case 8:
                    ViewBag.selectAug = "active";
                    break;
                case 9:
                    ViewBag.selectSep = "active";
                    break;
                case 10:
                    ViewBag.selectOct = "active";
                    break;
                case 11:
                    ViewBag.selectNov = "active";
                    break;
                case 12:
                    ViewBag.selectDec = "active";
                    break;
            }
        }
        }
    }