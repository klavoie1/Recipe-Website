using Microsoft.AspNetCore.Mvc;

namespace RecipeWebsite.Models
{
    public class RecipeViewModel : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


    }
}
