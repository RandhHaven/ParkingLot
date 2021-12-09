using ParkingLot.Models.Areas.Admin.Category;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParkingLot.Services.CategoryServices
{
    public sealed class CategoryService : ICategoryService
    {
        public CategoryVM GetAllCategory()
        {
            return new CategoryVM();
        }
    }
}
