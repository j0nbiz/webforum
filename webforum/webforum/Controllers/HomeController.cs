using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using webforum.Models;

namespace webforum.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            using (var db = new WebForumDB())
            {
                var query = (from entry in db.users.Include("threads")
                             orderby entry.user_id ascending
                             select entry).ToList<user>();



                return View(query);
            }
        }
    }
}