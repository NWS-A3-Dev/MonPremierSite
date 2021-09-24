using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MonPremierSite.Models;

namespace MonPremierSite.Controllers
{
    [Route("[Controller]/")]
    public class CarabistouilleController : Controller
    {
        public IActionResult Index(WebsiteContext ctx)
        {
            return View("Index", ctx.Users.First());
        }

        [HttpGet("{id}/{machin}")]
        public IActionResult Banane(int id, string machin)
        {
            return (View("Blog", new TestModel
            {
                Id = id,
                User = machin
            }));
        }
    }
}
