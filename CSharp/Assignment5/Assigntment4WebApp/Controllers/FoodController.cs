using Assigntment4WebApp.Models.Data;
using Assigntment4WebApp.Models.View;
using Assigntment4WebApp.ViewFunctions;
using Assigntment4WebApp.ViewModels.Food;
using Assigntment5WebApp.Data;
using Assigntment5WebApp.Models.View;
using Assigntment5WebApp.ViewModels.Food;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Assigntment5WebApp.Controllers
{
    public class FoodController : Controller
    {
        private readonly OrderEntityFunctions _orderEntityFunctions;
        private readonly FoodViewFunctions _foodViewFunctions;

        public FoodController(OrderEntityFunctions orderEntityFunctions, FoodViewFunctions foodViewFunctions)
        {
            _orderEntityFunctions = orderEntityFunctions;
            _foodViewFunctions = foodViewFunctions;
        }

        // GET: food
        public IActionResult Index()
        {
            var viewModel = new SearchViewModel
            {
                Orders = _orderEntityFunctions.GetOrders(),
                Message = "Here are your food orders",
                BeverageList = _foodViewFunctions.GetBeverageList(),
                AppetizerList = _foodViewFunctions.GetAppetizerList(),
                SandwichList = _foodViewFunctions.GetSandwichList(),
                DessertList = _foodViewFunctions.GetDessertList()
            };

            return View(viewModel);
        }

        // POST: food/search
        [HttpPost]
        public IActionResult Search(OrderSearch orderSearch)
        {
            var searchViewModel = new SearchViewModel
            {
                BeverageList = _foodViewFunctions.GetBeverageList(),
                AppetizerList = _foodViewFunctions.GetAppetizerList(),
                SandwichList = _foodViewFunctions.GetSandwichList(),
                DessertList = _foodViewFunctions.GetDessertList(),
                Orders = _orderEntityFunctions.SearchOrders(
            orderSearch.SelectedBeverage,
            orderSearch.SelectedAppetizer,
            orderSearch.SelectedSandwich,
            orderSearch.SelectedDessert
            )
            };

            return View("Search", searchViewModel);
        }
    }
}