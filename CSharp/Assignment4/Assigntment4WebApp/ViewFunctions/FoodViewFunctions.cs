using Assigntment4WebApp.Models.Data;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Assigntment4WebApp.ViewFunctions
{
    public class FoodViewFunctions
    {
        // Private reusable method to return proper type of food list for view models
        public List<SelectListItem> GetFoodItemList(string category)
        {
            List<SelectListItem> foodSelectList = new List<SelectListItem>();
            var foodEntityList = DataLists.FoodList.Where(m => m.Category == category).ToList();
            foreach (FoodItemEntity foodItemEntity in foodEntityList)
            {
                foodSelectList.Add(new SelectListItem()
                {
                    Text = foodItemEntity.Item,
                    Value = foodItemEntity.Item
                });
            }
            return foodSelectList;

        }
    }
}