using ECOMMERCE.APPLICATION.CORE.Entities.Drink;
using System.Collections.Generic;

namespace ECOMMERCE.APPLICATION.CORE.Interfaces.ICategory
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> Categories { get; }
    }
}
