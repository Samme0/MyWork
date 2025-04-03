using System.ComponentModel.DataAnnotations;

namespace Assigntment4WebApp.View
{
    public class Order
    {
        public string OrderId { get; set; } = Guid.NewGuid().ToString(); // assign random key value
        public decimal OrderTotal { get; set; }
        [Required]
        public string BeverageItem { get; set; } // BeverageItem value selected from dropdown
        [Required]
        public string AppetizerItem { get; set; } // AppetizerItem value selected from dropdown
        [Required]
        public string SandwichItem { get; set; } // SandwichCourseItem value selected from dropdown
        [Required]
        public string DessertItem { get; set; } // DessertItem value selected from dropdown
    }
}
