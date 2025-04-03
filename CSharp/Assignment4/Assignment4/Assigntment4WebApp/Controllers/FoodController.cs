using Assigntment4WebApp.Models.Data;
using Assigntment4WebApp.ViewModels.Food;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Assigntment4WebApp.Controllers
{
    public class FoodController : Controller
    {
        public IActionResult Index()
        {
            return View(DataLists.OrderList);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        private List<SelectListItem> GetFoodItemList(string v)
        {
            switch (v)
            {

                default:
                    break;
            }

            return new List<SelectListItem>
            {
                new SelectListItem { Value = "", Text = "Select" }
            };
        }

        [HttpPost]
        public IActionResult Create(OrderNewViewModel model)
        {
            if (ModelState.IsValid)
            {
                var order = new OrderEntity
                {
                    BeverageItem = model.Order.BeverageItem,
                    AppetizerItem = model.Order.AppetizerItem,
                    SandwichItem = model.Order.SandwichItem,
                    DessertItem = model.Order.DessertItem,

                };

                order.OrderTotal = DataLists.FoodList.Where
                    (f => f.Item == order.BeverageItem ||
                    f.Item == order.AppetizerItem ||
                    f.Item == order.SandwichItem || 
                    f.Item == order.DessertItem)
                    .Sum(f => f.ItemCost);

                DataLists.OrderList.Add(order);
                return RedirectToAction("Index");
            }
            model.BeverageList = GetFoodItemList("Bevergare");
            model.AppetizerList = GetFoodItemList("Appetizer");
            model.SandwichList = GetFoodItemList("Sandwich");
            model.DessertList = GetFoodItemList("Dessets");

            return View(model);
        }

    }
}
