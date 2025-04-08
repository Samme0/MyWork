using Assigntment4WebApp.Models.Data;
using System.Collections.Generic;

 namespace Assigntment4WebApp.Models.View
{
    public class DataLists
    {
        public static List<OrderEntity> OrderList { get; set; } = new List<OrderEntity>();

        public static List<FoodItemEntity> FoodList { get; set; } = new List<FoodItemEntity>();
    }
}
