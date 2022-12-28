using Polizia.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Polizia.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            List<Anagrafe> anagrafeList = new List<Anagrafe>();
            anagrafeList = Anagrafe.GetAllAnagrafie();
            return View(anagrafeList);
        }

        
       
    }
}