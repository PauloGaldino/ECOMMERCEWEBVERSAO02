

using ECOMMERCE.APPLICATION.CORE.Entities.Drink;
using ECOMMERCE.APPLICATION.CORE.Interfaces.ICategory;
using ECOMMERCE.INFRASTRUCTURE.Data;
using System.Collections.Generic;

namespace ECOMMERCE.APPLICATION.CORE.INFRASTRUCTURE.Repositories.CategoryRepositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly AppDbContext _appDbcontext;
        public CategoryRepository(AppDbContext appDbcontext)
        {
            _appDbcontext = appDbcontext;
        }
        public IEnumerable<Category> Categories => _appDbcontext.Categories;

    }
}

