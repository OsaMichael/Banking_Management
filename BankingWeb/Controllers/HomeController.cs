using BankingRepository.Repositries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BankingWeb.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            UserRepository urepo = new UserRepository();
            var result = urepo.GetAll().ToList();
            return View(result);
        }

    }
}