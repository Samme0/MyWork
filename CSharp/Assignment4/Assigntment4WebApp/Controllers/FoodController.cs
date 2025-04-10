using Assigntment4WebApp.Models.Data;
using Assigntment4WebApp.Models.View;
using Assigntment4WebApp.ViewFunctions;
using Assigntment4WebApp.ViewModels.Food;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Drawing.Text;
using System.Linq;

namespace Assigntment4WebApp.Controllers
{
    public class FoodController : Controller
    {
        private readonly FoodViewFunctions _foodViewFunctions = new FoodViewFunctions();
        // code to return the view model to the index view
        // get: food
        public IActionResult Index()
        {
            try
            {
                var viewModel = new IndexViewModel
                {
                    Orders = DataLists.OrderList,
                    Message = "Here are your food orders"
                };
                return View(viewModel);
            }
            catch (Exception ex)
            {
                ViewBag.ErrorMessage = "An error occurred while retrieving orders: " + ex.Message;
                return View("Error");
            }
           
        }

        // get: food/create

    public IActionResult Create()
        {
            try
            {
                var viewModel = new OrderNewViewModel
                {
                    BeverageList = _foodViewFunctions.GetBeverageList(),
                    AppetizerList = _foodViewFunctions.GetAppetizerList(),
                    SandwichList = _foodViewFunctions.GetSandWichList(),
                    DessertList = _foodViewFunctions.GetDessertList()
                };
                return View("New",viewModel);
            }
            catch (Exception ex)
            {
                ViewBag.ErrorMessage = "An error occurred while preparing the create form: " + ex.Message;
                return View("Error");
            }
        }
        // POST: food/Create
        [HttpPost]
        public IActionResult Create(OrderNewViewModel model)
        {
            try
            {
                if (model == null || model.Order == null)
                {
                    return BadRequest("Model or Order cannot be null.");
                }

                if (ModelState.IsValid)
                {


                    var order = new OrderEntity
                    {
                        BeverageItem = model.Order.BeverageItem,
                        AppetizerItem = model.Order.AppetizerItem,
                        DessertItem = model.Order.DessertItem,
                        OrderTotal = CalculateOrderTotal(model.Order)
                    };

                    DataLists.OrderList.Add(order);
                    return RedirectToAction("Index");
                }
                model.BeverageList = _foodViewFunctions.GetBeverageList();
                model.AppetizerList = _foodViewFunctions.GetAppetizerList();
                model.SandwichList = _foodViewFunctions.GetSandWichList();
                model.DessertList = _foodViewFunctions.GetDessertList();
                return View("New",model);
            }
            catch (Exception ex)
            {
                ViewBag.ErrorMessage = "An error occurred while creating the order: " + ex.Message;
                return View("Error",model);
            }
        }
        // Get: food/edit/{id}
        public IActionResult Delete(string id)
        {
            try
            {
                var order = DataLists.OrderList.FirstOrDefault(o => o.OrderId == id);
                if (order == null)
                {
                    return NotFound();
                }
                return View(order);
            }
            catch (Exception ex)
            {
                ViewBag.ErrorMessage = "An error occurred while preparing to delete the order: " + ex.Message;
                return View("Error");
            }
        }
        // post: food/Delete/{id}
        [HttpPost, ActionName("Delete")] 

        public IActionResult DeleteConfirmed(string id)
        {
            try
            {
                var order = DataLists.OrderList.FirstOrDefault(o => o.OrderId == id);
                if (order != null)
                {
                    DataLists.OrderList.Remove(order); 
                }
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                ViewBag.ErrorMessage = "An error occurred while deleting the order: " + ex.Message;
                return View("Error");
            }
          
        }
        // Method to calculate the total order cost 
        private decimal CalculateOrderTotal(Order order)
        {
            decimal total = 0;

            total += DataLists.FoodList.FirstOrDefault(f => f.Item == order.BeverageItem)?.ItemCost ?? 0;

            total += DataLists.FoodList.FirstOrDefault(f => f.Item == order.AppetizerItem)?.ItemCost ?? 0;

            total += DataLists.FoodList.FirstOrDefault(f => f.Item == order.SandwichItem)?.ItemCost ?? 0;

            total += DataLists.FoodList.FirstOrDefault(f => f.Item == order.DessertItem)?.ItemCost ?? 0;

            return total;
        }
    }
}
