using ECOMMERCE.APPLICATION.CORE.Interfaces.ICategory;
using ECOMMERCE.APPLICATION.CORE.Interfaces.IDrink;
using ECOMMERCE.WEB.UI.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace ECOMMERCE.WEB.UI.Controllers
{
    public class DrinkController : Controller
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly IDrinkRepository _drinkRepository;
        public DrinkController(ICategoryRepository categoryRepository, IDrinkRepository drinkRepository)
        {
            _categoryRepository = categoryRepository;
            _drinkRepository = drinkRepository;
        }
        public ViewResult List()
        {
            ViewBag.Name = "DotNet, Teste";
            DrinkListViewModel vm = new DrinkListViewModel();
            vm.Drinks = _drinkRepository.Drinks;
            vm.CurrentCategory = "DrinkCategory";

            return View(vm);
        }
    }
}