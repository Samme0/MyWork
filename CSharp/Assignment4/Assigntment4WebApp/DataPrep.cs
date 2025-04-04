using Assigntment4WebApp.Models.Data;

namespace Assigntment4WebApp
{
    public class DataPrep
    {
       
        public void LoadFoodEntities()
        {
            // List of Food
            var foodItems = new List<FoodItemEntity>
           {
                new FoodItemEntity { Item = "Soda", Category = "Beverage", ItemCost = 2.50M },
                new FoodItemEntity { Item = "Iced Tea", Category = "Beverage", ItemCost = 1.75M },
                new FoodItemEntity { Item = "Coffee", Category = "Beverage", ItemCost = 2.00M },
                new FoodItemEntity { Item = "Milk", Category = "Beverage", ItemCost = 1.50M },
                new FoodItemEntity { Item = "Orange Juice", Category = "Beverage", ItemCost = 2.25M },
                new FoodItemEntity { Item = "Lemonade", Category = "Beverage", ItemCost = 1.95M },
                new FoodItemEntity { Item = "Mozzarella Sticks", Category = "Appetizer", ItemCost = 8.00M },
                new FoodItemEntity { Item = "Buffalo Wings", Category = "Appetizer", ItemCost = 10.00M },
                new FoodItemEntity { Item = "Nachos", Category = "Appetizer", ItemCost = 7.50M },
                new FoodItemEntity { Item = "Crab Dip", Category = "Appetizer", ItemCost = 9.50M },
                new FoodItemEntity { Item = "Chips and Salsa", Category = "Appetizer", ItemCost = 5.00M },
                new FoodItemEntity { Item = "Stuffed Mushrooms", Category = "Appetizer", ItemCost = 8.50M },
                new FoodItemEntity { Item = "Cheeseburger", Category = "Sandwich", ItemCost = 10.50M },
                new FoodItemEntity { Item = "Philly Cheesesteak", Category = "Sandwich", ItemCost = 11.00M },
                new FoodItemEntity { Item = "Grilled Chicken Sandwich", Category = "Sandwich", ItemCost = 10.25M },
                new FoodItemEntity { Item = "Turkey Club Sandwich", Category = "Sandwich", ItemCost = 10.75M },
                new FoodItemEntity { Item = "Veggie Sandwich", Category = "Sandwich", ItemCost = 9.50M },
                new FoodItemEntity { Item = "Fudge Sundae", Category = "Dessert", ItemCost = 6.00M },
                new FoodItemEntity { Item = "Apple Crisp", Category = "Dessert", ItemCost = 5.50M },
                new FoodItemEntity { Item = "Chocolate Cake", Category = "Dessert", ItemCost = 4.50M },
                new FoodItemEntity { Item = "Cheesecake", Category = "Dessert", ItemCost = 6.50M },
                new FoodItemEntity { Item = "Brownie with Ice Cream", Category = "Dessert", ItemCost = 5.00M },
                new FoodItemEntity { Item = "Tiramisu", Category = "Dessert", ItemCost = 7.00M }
};

            DataLists.FoodList.AddRange(foodItems);


        }
    }

   
}

