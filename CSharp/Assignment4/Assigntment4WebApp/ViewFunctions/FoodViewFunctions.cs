using Assigntment4WebApp.Models.Data;
using Assigntment4WebApp.Models.View;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace Assigntment4WebApp.ViewFunctions
{

    // Create, retrieve, update, and delete
    public class FoodViewFunctions
    {
        private List<SelectListItem> GetFoodItemList(string category)
        {
            List<SelectListItem> foodSelectList = new List<SelectListItem>();

            var foodEntityList = DataLists.FoodList.Where(mbox => mbox.Category == category).ToList();

            foreach (FoodItemEntity foodItemEntity in foodEntityList)
            {
                foodSelectList.Add(new SelectListItem
                {
                    Text = foodItemEntity.Item,
                    Value = foodItemEntity.Item,
                });
            }

            return foodSelectList;
        }

        public List<SelectListItem> GetBeverageList()
        {
            return GetFoodItemList("Beverage");
        }
        public List<SelectListItem> GetAppetizerList()
        {
            return GetFoodItemList("Appetizer");
        }
        public List<SelectListItem> GetSandWichList()
        {
            return GetFoodItemList("Sandwich");
        }
        public List<SelectListItem> GetDessertList()
        {
            return GetFoodItemList("Dessert");
        }
    }
}
