using ECOMMERCE.APPLICATION.CORE.Entities.Drink;
using System.Collections.Generic;

namespace ECOMMERCE.APPLICATION.CORE.Interfaces.IDrink
{
    public interface IDrinkRepository
    {
        IEnumerable<Drink> Drinks { get; }
        IEnumerable<Drink> PreferredDrinks { get; }
        Drink GetDrinkById(int drinkId);
    }
}
