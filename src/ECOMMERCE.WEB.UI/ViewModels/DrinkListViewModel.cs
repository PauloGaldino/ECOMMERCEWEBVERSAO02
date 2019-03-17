using ECOMMERCE.APPLICATION.CORE.Entities.Drink;
using System.Collections.Generic;

namespace ECOMMERCE.WEB.UI.ViewModels
{
    public class DrinkListViewModel
    {
        public IEnumerable<Drink> Drinks { get; set; }
        public string CurrentCategory { get; set; }
    }
}
