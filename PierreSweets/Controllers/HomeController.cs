using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using PierreSweets.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Security.Claims;

namespace PierreSweets.Controllers;

public class HomeController : Controller
{
    private readonly PierreSweetContext _db;
        private readonly UserManager<Account> _userManager;

        public HomeController(UserManager<Account> userManager, PierreSweetContext db)
        {
            _userManager = userManager;
            _db = db;
        }

        [HttpGet("/")]
        public async Task<ActionResult> Index()
        {
          if (User.Identity.IsAuthenticated){
        Flavor[] flavors = _db.Flavors.ToArray();
        Dictionary<string,object[]> model = new Dictionary<string, object[]>();
        model.Add("flavors", flavors);
        string userId = this.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
        Account currentUser = await _userManager.FindByIdAsync(userId);
        if (currentUser != null)
        {
          Treat[] treats = _db.Treats
                      .Where(entry => entry.User.Id == currentUser.Id)
                      .ToArray();
          model.Add("treats", treats);
        }
        return View(model);
        }
        else{
          return View(_db.Treats.ToList());
        }
        }  
}
