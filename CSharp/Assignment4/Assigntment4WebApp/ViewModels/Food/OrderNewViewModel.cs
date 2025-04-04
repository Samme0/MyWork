using Assigntment4WebApp.View;
using Assigntment4WebApp.ViewModels.Order;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Security.Policy;

namespace Assigntment4WebApp.ViewModels 
{
    public class OrderNewViewModel
    {
        public FooOrder Order { get; set; } = new FooOrder();

        public OrderModel? fooOrder { get; set; } = new OrderModel();
        public List<SelectListItem>? BeverageList { get; set; } = new List<SelectListItem>();
        public List<SelectListItem>? AppetizerList { get; set; } = new List<SelectListItem>();
        public List<SelectListItem>? SandwichList { get; set; } = new List<SelectListItem>();
        public List<SelectListItem>? DessertList { get; set; } = new List<SelectListItem>();
        public string Message { get; set; } = string.Empty;
    }
}
