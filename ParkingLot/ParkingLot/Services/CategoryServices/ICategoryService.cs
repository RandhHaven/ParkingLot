
namespace ParkingLot.Services.CategoryServices
{
    using ParkingLot.Models.Areas.Admin.Category;

    public interface ICategoryService : TUIService
    {
        CategoryVM GetAllCategory();
    }
}