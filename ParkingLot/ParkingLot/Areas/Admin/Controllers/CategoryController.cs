namespace ParkingLot.Areas.Admin.Controllers
{
    using ParkingLot.Base;
    using ParkingLot.Services;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.Extensions.Logging;
    using ParkingLot.Models.Areas.Admin.Category;
    using ParkingLot.Resources;
    using ParkingLot.Services.CategoryServices;

    [Area("Admin")]
    public class CategoryController : GenericControllerBase<CategoryController, ICategoryService, CategoryVM>
    {       
        public CategoryController(ILogger<CategoryController> _logger, ICategoryService uiService, CategoryVM model) : base(_logger, uiService, model)
        {
        }

        protected override string Title => Labels.CategoryTitle;


        [HttpGet]
        public ActionResult GetAllCategorys()
        {
            var CategoryVM = this.UIService.GetAllCategory();
            return Json(new { data = CategoryVM.List });
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        public override ViewResult View()
        {
            return base.View();
        }
    }
}
