namespace ParkingNet.Services.CategoryServices
{
    using ParkingLot.Models.Areas.Admin.Category;

    public sealed class CategoryService : ICategoryService
    {
        public CategoryVM GetAllCategory()
        {
            return new CategoryVM();
        }
    }
}
