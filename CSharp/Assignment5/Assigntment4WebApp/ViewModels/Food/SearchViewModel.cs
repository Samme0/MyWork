using Assigntment4WebApp.Models.Data;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace Assigntment5WebApp.ViewModels.Food
{
    public class SearchViewModel
    {
        public List<OrderEntity> Orders { get; set; } = new List<OrderEntity>();
        public string? SelectedBeverage { get; set; }
        public string? SelectedAppetizer { get; set; }
        public string? SelectedSandwich { get; set; }
        public string? SelectedDessert { get; set; }
        public string Message { get; set; } = string.Empty;

        // Dropdown lists for the search view
        public List<SelectListItem> BeverageList { get; set; } = new List<SelectListItem>();
        public List<SelectListItem> AppetizerList { get; set; } = new List<SelectListItem>();
        public List<SelectListItem> SandwichList { get; set; } = new List<SelectListItem>();
        public List<SelectListItem> DessertList { get; set; } = new List<SelectListItem>();
    }
}
