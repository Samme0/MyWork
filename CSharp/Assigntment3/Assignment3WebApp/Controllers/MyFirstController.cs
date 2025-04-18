using Assignment3WebApp.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Assignment3WebApp.Controllers
{
    public class MyFirstController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult EditDesign()
        {
            EditDesignViewModel editDesignViewModel = new EditDesignViewModel();
            return View(editDesignViewModel);
        }
    }
}
