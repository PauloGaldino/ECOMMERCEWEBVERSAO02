using System.Collections.Generic;
using ECOMMERCE.APPLICATION.CORE.Entities.Drink;
using ECOMMERCE.APPLICATION.CORE.Interfaces.ICategory;

namespace ECOMMERCE.INFRASTRUCTURE.Mocks
{
    public class MockCategoryRepository:ICategoryRepository
    {
        public IEnumerable<Category> Categories
        {
            get
            {
                return new List<Category>
                     {
                         new Category { CategoryName = "Alcoholic", Description = "All alcoholic drinks" },
                         new Category { CategoryName = "Non-alcoholic", Description = "All non-alcoholic drinks" }
                     };
            }
        }
    }  
}
