using System.ComponentModel.DataAnnotations;

namespace Assigntment4WebApp.Models.Data
{
    public class OrderEntity
    {
        [Key] // unique identifier for the database record
        public string OrderId { get; set; } = Guid.NewGuid().ToString(); // assign random key value
        public decimal OrderTotal { get; set; }
        public string BeverageItem { get; set; }
        public string AppetizerItem { get; set; }
        public string SandwichItem { get; set; }
        public string DessertItem { get; set; }
    }
}