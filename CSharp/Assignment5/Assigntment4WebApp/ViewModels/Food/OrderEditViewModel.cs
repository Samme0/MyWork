using Assigntment4WebApp.Models.View;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace Assigntment4WebApp.ViewModels.Food
{
    public class OrderEditViewModel
    {
        // Property to hold the order details being edited

        public Order Order { get; set; } = new Order();

        // list for dropdown controls
        public List<SelectListItem> BeverageList { get; set; } = new List<SelectListItem>();
        public List<SelectListItem> AppetizerList { get; set; } = new List<SelectListItem>();
        public List<SelectListItem> SandwichList { get; set; } = new List<SelectListItem>();
        public List<SelectListItem> DessertList { get; set; } = new List<SelectListItem>();

        public string Message { get; set; } = string.Empty;

    }
}
