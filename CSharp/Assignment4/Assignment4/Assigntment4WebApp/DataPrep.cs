using Assigntment4WebApp.Models.Data;

namespace Assigntment4WebApp
{
    public class DataPrep
    {
        public void LoadFoodEntities()
        {
            List<FoodItemEntity> foodList = new List<FoodItemEntity>()
            {
                new FoodItemEntity() { Item = "Cheeseburger", Category = "Entree", ItemCost = 8.95M },
                new FoodItemEntity() { Item = "Soda", Category = "Beverage", ItemCost = 1.95M },
                new FoodItemEntity() { Item = "Mazzzo Sticks", Category = "Side", ItemCost = 2.95M },
                new FoodItemEntity() { Item = "Hamburger", Category = "Entree", ItemCost = 6.95M },
                new FoodItemEntity() { Item = "Hot Dog", Category = "Entree", ItemCost = 6.95M },
                new FoodItemEntity() { Item = "French Fries", Category = "Side", ItemCost = 3.95M },
                new FoodItemEntity() { Item = "CheeseSteak", Category = "Entree", ItemCost = 9.95M },
                new FoodItemEntity() { Item = "Iced Tea", Category = "Beverage", ItemCost = 1.95M }
            };

            DataLists.FoodList = foodList;


        }
    }

   
}

