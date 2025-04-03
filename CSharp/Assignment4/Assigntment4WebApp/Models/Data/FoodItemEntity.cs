using System.ComponentModel.DataAnnotations;

namespace Assigntment4WebApp.Models.Data
{
    public class FoodItemEntity
    {
        [Key]
        public string? Item { get; set; }
        public string? Category { get; set; }
        public decimal ItemCost { get; set; }
    }

}
