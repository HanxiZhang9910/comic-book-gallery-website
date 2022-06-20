using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Controllers
{
    public class ComicBooksController : Controller
    {
        public ActionResult Detail()
        {
            return View();
        }   
    }
}
