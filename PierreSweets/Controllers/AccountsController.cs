using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;
using RecipeBox.Models;
using PierreSweets.ViewModels;

namespace PierreSweets.Controllers

{
  public class AccountController : Controller
  {
    private readonly PierreSweetContext _db;
    private readonly UserManager<Account> _userManager;
    private readonly SignInManager<Account> _signInManager;

    public AccountController (UserManager<Account> userManager, SignInManager<Account> signInManager, PierreSweetContext db)
    {
      _userManager = userManager;
      _signInManager = signInManager;
      _db = db;
    }
  }
}    