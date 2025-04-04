using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Assigntment4WebApp.Models.Data;
using Assigntment4WebApp.ViewModels.Food;
using System.Linq;
using Assigntment4WebApp.View;
using Assigntment4WebApp.ViewModels;
using Assigntment4WebApp.Models;
using Assigntment4WebApp.ViewModels.Order;

public class FoodController : Controller
{
    // GET: Food/Create
    public IActionResult Create()
    {
        var viewModel = new OrderNewViewModel
        {
            BeverageList = GetFoodItemList("Beverage"),
            AppetizerList = GetFoodItemList("Appetizer"),
            SandwichList = GetFoodItemList("Sandwich"),
            DessertList = GetFoodItemList("Dessert"),
            Order = new FooOrder() // Initialize the Order object
        };

        return View(viewModel);
    }

    // POST: Food/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Create(OrderNewViewModel viewModel)
    {
        if (ModelState.IsValid)
        {
            // Calculate order total based on selected items
            viewModel.Order.OrderTotal =
            DataLists.FoodList.FirstOrDefault(f => f.Item == viewModel.Order.BeverageItem)?.ItemCost ?? 0 +
            DataLists.FoodList.FirstOrDefault(f => f.Item == viewModel.Order.AppetizerItem)?.ItemCost ?? 0 +
            DataLists.FoodList.FirstOrDefault(f => f.Item == viewModel.Order.SandwichItem)?.ItemCost ?? 0 +
            DataLists.FoodList.FirstOrDefault(f => f.Item == viewModel.Order.DessertItem)?.ItemCost ?? 0;

            DataLists.OrderList.Add(new OrderEntity
            {
                OrderId = viewModel.Order.OrderId,
                OrderTotal = viewModel.Order.OrderTotal,
                BeverageItem = viewModel.Order.BeverageItem,
                AppetizerItem = viewModel.Order.AppetizerItem,
                SandwichItem = viewModel.Order.SandwichItem,
                DessertItem = viewModel.Order.DessertItem
            });

            return RedirectToAction("Index"); // Redirect to a list of orders or another action
        }

        // Repopulate dropdowns if model state is invalid
        viewModel.BeverageList = GetFoodItemList("Beverage");
        viewModel.AppetizerList = GetFoodItemList("Appetizer");
        viewModel.SandwichList = GetFoodItemList("Sandwich");
        viewModel.DessertList = GetFoodItemList("Dessert");

        return View(viewModel);
    }

    // GET: Food/Edit/{id}
    public IActionResult Edit(string id)
    {
        var order = DataLists.OrderList.FirstOrDefault(o => o.OrderId == id);
        if (order == null)
        {
            return NotFound();
        }

        var viewModel = new OrderNewViewModel
        {
            Order = new FooOrder
            {
                OrderId = order.OrderId,
                BeverageItem = order.BeverageItem,
                AppetizerItem = order.AppetizerItem,
                SandwichItem = order.SandwichItem,
                DessertItem = order.DessertItem,
                OrderTotal = order.OrderTotal
            },
            BeverageList = GetFoodItemList("Beverage"),
            AppetizerList = GetFoodItemList("Appetizer"),
            SandwichList = GetFoodItemList("Sandwich"),
            DessertList = GetFoodItemList("Dessert")
        };

        return View(viewModel);
    }

    // POST: Food/Edit/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Edit(string id, OrderNewViewModel viewModel)
    {
        if (ModelState.IsValid)
        {
            var order = DataLists.OrderList.FirstOrDefault(o => o.OrderId == id);
            if (order == null)
            {
                return NotFound();
            }

            // Update order details
            order.BeverageItem = viewModel.Order.BeverageItem;
            order.AppetizerItem = viewModel.Order.AppetizerItem;
            order.SandwichItem = viewModel.Order.SandwichItem;
            order.DessertItem = viewModel.Order.DessertItem;

            // Recalculate total
            order.OrderTotal =
            DataLists.FoodList.FirstOrDefault(f => f.Item == order.BeverageItem)?.ItemCost ?? 0 +
            DataLists.FoodList.FirstOrDefault(f => f.Item == order.AppetizerItem)?.ItemCost ?? 0 +
            DataLists.FoodList.FirstOrDefault(f => f.Item == order.SandwichItem)?.ItemCost ?? 0 +
            DataLists.FoodList.FirstOrDefault(f => f.Item == order.DessertItem)?.ItemCost ?? 0;

            return RedirectToAction("Index"); // Redirect to the order list
        }

        // Repopulate dropdowns if model state is invalid
        viewModel.BeverageList = GetFoodItemList("Beverage");
        viewModel.AppetizerList = GetFoodItemList("Appetizer");
        viewModel.SandwichList = GetFoodItemList("Sandwich");
        viewModel.DessertList = GetFoodItemList("Dessert");

        return View(viewModel);
    }

    // GET: Food/Delete/{id}
    public IActionResult Delete(string id)
    {
        var order = DataLists.OrderList.FirstOrDefault(o => o.OrderId == id);
        if (order == null)
        {
            return NotFound();
        }

        return View(order);
    }

    // POST: Food/Delete/{id}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public IActionResult DeleteConfirmed(string id)
    {
        var order = DataLists.OrderList.FirstOrDefault(o => o.OrderId == id);
        if (order != null)
        {
            DataLists.OrderList.Remove(order);
        }
        return RedirectToAction("Index"); // Redirect to the order list
    }

    // Helper method to get food items by category for dropdowns
    private List<SelectListItem> GetFoodItemList(string category)
    {
        return DataLists.FoodList
        .Where(f => f.Category == category)
        .Select(f => new SelectListItem
        {
            Text = f.Item,
            Value = f.Item
        }).ToList();
    }

    // GET: Food/Index
    public IActionResult Index()
    {
        return View(DataLists.OrderList); // Display list of orders
    }
}