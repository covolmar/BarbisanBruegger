using BarbisanBruegger.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BarbisanBruegger.Controllers
{
    public class RentController : Controller
    {
		private ApplicationDbContext db = new ApplicationDbContext();

		// GET: Rent
		public ActionResult Index()
        {
            return View(db.Formworks.ToList());
        }
    }
}