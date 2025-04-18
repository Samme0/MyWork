using Assigntment4WebApp.Models.Data;
using Assigntment4WebApp.Models.View;

namespace Assigntment4WebApp.ViewModels.Food
{
    public class IndexViewModel
    {
        public List<OrderEntity> Orders { get; set; } = new List<OrderEntity>();

        public string SelectedBeverage { get; set; }

        public string SelectedAppetizer { get; set; }

        public string SelectedSandwich { get; set; }

        public string SelectedDessert { get; set; }

        public string Message { get; set; } = string.Empty;
    }
}
