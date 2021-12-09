namespace WebApiServiceEstacionamiento.Controllers.Admin
{
    using AutoMapper;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.Extensions.Logging;
    using System;
    using System.Threading.Tasks;
    using WebApiServiceEstacionamiento.Services.GenericRepository;

    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : WebApiControllers<CarController>
    {
        private readonly IUnitOfWork _IUnitOfWork;

        public CategoryController(IUnitOfWork uIUnitOfWork) : base(uIUnitOfWork)
        {
            this._IUnitOfWork = uIUnitOfWork ?? throw new ArgumentNullException(nameof(uIUnitOfWork));
        }

        // GET: api/Category
        [HttpGet]
        public async Task<IActionResult> GetCategorys()
        {
            var cars = await this._IUnitOfWork._ICategoryRepository.GetAll();

            return Ok(cars);
        }
    }
}
