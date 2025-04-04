using Assigntment4WebApp.View;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace Assigntment4WebApp.ViewModels.Food
{
    public class OrderEditViewModel
    {
       
      public FooOrder Order { get; set; } = new FooOrder();

    // Lists for dropdown controls
      public List<SelectListItem> BeverageList { get; set; } = new List<SelectListItem>();
      public List<SelectListItem> AppetizerList { get; set; } = new List<SelectListItem>();
      public List<SelectListItem> SandwichList { get; set; } = new List<SelectListItem>();
      public List<SelectListItem> DessertList { get; set; } = new List<SelectListItem>();

      public string Message { get; set; } = string.Empty;
        
    }
}

