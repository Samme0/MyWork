
using Assigntment4WebApp.Models.View;
using Assigntment5WebApp.Data;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Linq;



namespace Assigntment4WebApp.ViewFunctions
{

    // Create, retrieve, update, and delete
    public class FoodViewFunctions
    {
        private readonly OrderEntityFunctions _orderEntityFunctions;

        public FoodViewFunctions(OrderEntityFunctions orderEntityFunctions)
        {
            _orderEntityFunctions = orderEntityFunctions;
        }

        public List<SelectListItem> GetBeverageList()
        {
            return DataLists.FoodList
            .Where(f => f.Category == "Beverage")
            .Select(f => new SelectListItem
            {
                Text = f.Item,
                Value = f.Item
            }).ToList();
        }

        public List<SelectListItem> GetAppetizerList()
        {
            return DataLists.FoodList
            .Where(f => f.Category == "Appetizer")
            .Select(f => new SelectListItem
            {
                Text = f.Item,
                Value = f.Item
            }).ToList();
        }

        public List<SelectListItem> GetSandwichList()
        {
            return DataLists.FoodList
            .Where(f => f.Category == "Sandwich")
            .Select(f => new SelectListItem
            {
                Text = f.Item,
                Value = f.Item
            }).ToList();
        }

        public List<SelectListItem> GetDessertList()
        {
            return DataLists.FoodList
            .Where(f => f.Category == "Dessert")
            .Select(f => new SelectListItem
            {
                Text = f.Item,
                Value = f.Item
            }).ToList();
        }
    }
}

