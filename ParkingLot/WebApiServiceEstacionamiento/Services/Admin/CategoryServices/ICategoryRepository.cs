namespace WebApiServiceEstacionamiento.Services.CategoryServices
{
    using Microsoft.AspNetCore.Mvc.Rendering;
    using System.Collections.Generic;
    using WebApiServiceEstacionamiento.Models.Admin;
    using WebApiServiceEstacionamiento.Services.GenericRepository;
    
    public interface ICategoryRepository : IRepository<Category>
    {
        IEnumerable<SelectListItem> GetListCategorys();
    }
}
