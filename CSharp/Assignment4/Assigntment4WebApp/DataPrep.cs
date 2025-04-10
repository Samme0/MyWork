using Assigntment4WebApp.Models.Data;
using Assigntment4WebApp.Models.View;

namespace Assigntment4WebApp
{
    public class DataPrep
    {
        public void LoadFoodEntities()
        {
            var foodItems = new List<FoodItemEntity>
            { 
                 // Beverages
                new FoodItemEntity { Item = "Soda", Category = "Beverage", ItemCost = 2.95M },

                new FoodItemEntity { Item = "Iced Tea", Category = "Beverage", ItemCost = 2.50M },

                new FoodItemEntity { Item = "Lemonade", Category = "Beverage", ItemCost = 3.00M },

                new FoodItemEntity { Item = "Coffee", Category = "Beverage", ItemCost = 1.75M },

                new FoodItemEntity { Item = "Milkshake", Category = "Beverage", ItemCost = 4.00M },

                // Appetizers
                new FoodItemEntity { Item = "Chips", Category = "Appetizer", ItemCost = 1.50M },

                new FoodItemEntity { Item = "Mozzarella Sticks", Category = "Appetizer", ItemCost = 5.00M },

                new FoodItemEntity {Item = "Spring Rolls", Category = "Appetizer", ItemCost = 4.50M },

                new FoodItemEntity { Item = "Garlic Bread", Category = "Appetizer", ItemCost = 3.25M },

                new FoodItemEntity { Item = "Bruschetta", Category = "Appetizer", ItemCost = 6.00M },

                // Sandwiches
                new FoodItemEntity { Item = "Club Sandwich", Category = "Sandwich", ItemCost = 8.50M },

                new FoodItemEntity { Item = "BTL", Category = "Sandwich", ItemCost = 7.00M },

                new FoodItemEntity { Item = "Grillrd Cheese", Category = "Sandwich", ItemCost = 6.50M },

                new FoodItemEntity { Item = "Turkey Sandwich", Category = "Sandwich", ItemCost = 9.00M },

                new FoodItemEntity { Item = "Veggie Sandwich", Category = "Sandwich", ItemCost = 7.50M },

                // Desserts
                new FoodItemEntity { Item = "Chocolate Cake", Category = "Dessert", ItemCost = 3.75M },

                new FoodItemEntity { Item = "Cheesecake", Category = "Dessert", ItemCost = 4.50M },

                new FoodItemEntity { Item = "Ice Cream", Category = "Dessert", ItemCost = 2.00M },

                new FoodItemEntity { Item = "Apple Pie", Category = "Dessert", ItemCost = 3.00M },

                new FoodItemEntity { Item = "Brownie", Category = "Dessert", ItemCost = 2.50M },
            };

            DataLists.FoodList.AddRange(foodItems);
        }
    }
}
