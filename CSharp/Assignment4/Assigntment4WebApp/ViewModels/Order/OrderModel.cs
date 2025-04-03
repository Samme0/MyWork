using System.ComponentModel.DataAnnotations;

namespace Assigntment4WebApp.ViewModels.Order
{
    public class OrderModel
    {
        public string OrderId { get; set; } = Guid.NewGuid().ToString(); // assign random key value
        public decimal OrderTotal { get; set; }
        [Required]
        public string BeverageItem { get; set; }
        [Required]
        public string AppetizerItem { get; set; }
        [Required]
        public string SandwichItem { get; set; }
        [Required]
        public string DessertItem { get; set; }
    }
}