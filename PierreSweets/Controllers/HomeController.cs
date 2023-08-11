using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using PierreSweets.Models;

namespace PierreSweets.Controllers;

public class HomeController : Controller
{
    private readonly PierreSweetContext _db;
        private readonly UserManager<Account> _userManager;

        public HomeController(UserManager<Account> userManager, RecipeBoxContext db)
        {
            _userManager = userManager;
            _db = db;
        }
}
