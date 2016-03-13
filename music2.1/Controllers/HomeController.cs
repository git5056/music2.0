using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace music2._1.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult m_tab02_s02()
        {
            var context = Spring.Context.Support.ContextRegistry.GetContext();
            var iof = context;
            var ss = iof.GetObject("SongService") as Service.inte.ISongService;
            return View(ss.LatestSongs(12));
        }

    }
}
