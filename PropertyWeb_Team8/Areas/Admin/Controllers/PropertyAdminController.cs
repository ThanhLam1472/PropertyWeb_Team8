using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PropertyWeb_Team8.Models;

namespace PropertyWeb_Team8.Areas.Admin.Controllers
{
    public class PropertyAdminController : Controller
    {
        PropertyWeb_Team8Entities model = new PropertyWeb_Team8Entities();
        // GET: Admin/PropertyAdmin
        public ActionResult Index()
        {
            var property = model.Properties.OrderByDescending(x => x.ID).ToList();
            return View(property);
        }
    }
}