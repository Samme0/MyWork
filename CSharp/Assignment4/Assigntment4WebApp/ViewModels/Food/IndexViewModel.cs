using Assigntment4WebApp.Models.Data;
using Assigntment4WebApp.View;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace Assigntment4WebApp.ViewModels.Food
{
    public class IndexViewModel
    {
        public List<OrderEntity> Orders { get; set; } = new List<OrderEntity>();

        public string Message { get; set; } = string.Empty;

        public string SearchTerm { get; set; } = string.Empty;

        public int TottalOrders => Orders.Count;
    }
}
