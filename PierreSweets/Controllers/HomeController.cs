using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using PierreSweets.Models;
using System.Collections.Generic;
using System.Linq;

namespace PierreSweets.Controllers
{
    public class HomeController : Controller
    {
        private readonly PierreSweetContext _db;
        private readonly UserManager<ApplicationUser> _userManager;

        public HomeController(UserManager<ApplicationUser> userManager, PierreSweetContext db)
        {
            _userManager = userManager;
            _db = db;
        }

        [HttpGet("/")]
        public IActionResult Index()
        {
            Treat[] treats = _db.Treats.ToArray();
            Flavor[] flavors = _db.Flavors.ToArray();
            Dictionary<string, object[]> model = new Dictionary<string, object[]>();
            model.Add("treats", treats);
            model.Add("flavors", flavors);
            return View(model);
        }
    }
}
