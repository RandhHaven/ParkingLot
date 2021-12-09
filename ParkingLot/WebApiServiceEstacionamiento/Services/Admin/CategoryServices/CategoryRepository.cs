namespace WebApiServiceEstacionamiento.Services.CategoryServices
{
    using Microsoft.AspNetCore.Mvc.Rendering;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using WebApiServiceEstacionamiento.Models.Admin;
    using WebApiServiceEstacionamiento.ParkingLotModel;
    using WebApiServiceEstacionamiento.Services.GenericRepository;

    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        private DatabaseContext _databaseContext { get; set; }
        public CategoryRepository(DatabaseContext databaseContext) : base(databaseContext)
        {
           this._databaseContext = databaseContext
                    ?? throw new ArgumentNullException(nameof(databaseContext));
        }

        public IEnumerable<SelectListItem> GetListCategorys()
        {
            return this._databaseContext.Category.Select(cat => new SelectListItem
            {
                Text = cat.NameCategory,
                Value = cat.CategoryID.ToString()
            });
        }

        public override void Update(Category entity)
        {
            base.Update(entity);
        }
    }
}
