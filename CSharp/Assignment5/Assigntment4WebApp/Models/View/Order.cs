using System.ComponentModel.DataAnnotations;

namespace Assigntment4WebApp.Models.View
{
    public class Order
    {
        public string OrderId { get; set; } = Guid.NewGuid().ToString();
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
