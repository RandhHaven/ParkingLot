namespace WebApiServiceEstacionamiento.Controllers
{
    #region Directives
    using System;
    using System.Threading.Tasks;
    using AutoMapper;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.Extensions.Logging;
    using WebApiServiceEstacionamiento.Models.Parking;
    using WebApiServiceEstacionamiento.Models;
    using WebApiServiceEstacionamiento.Services.ParkingLot.CarServices;
    #endregion

    [Route("api/[controller]")]
    [ApiController]
    public class CarController : WebApiControllers<CarController>
    {
        #region Properties
        public ICarService _ICarService { get; set; }
        private readonly ILogger<CarController> _logger;
        private readonly IMapper _mapper;
        #endregion

        #region Builds
        public CarController(ILogger<CarController> logger, ICarService _ICarService, IMapper _mapper) : base(logger, _ICarService, _mapper)
        {
            this._ICarService = _ICarService  ?? throw new ArgumentNullException(nameof(_ICarService));
            this._mapper = _mapper ?? throw new ArgumentNullException(nameof(_mapper));
            this._logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }
        #endregion

        // GET: api/Car
        [HttpGet]
        public async Task<IActionResult> GetCars()
        {
            var cars = await _ICarService.GetCars();

            return Ok(cars);
        }

        // GET: api/Auto/5
        [HttpGet("{id}", Name = "GetCar")]
        public async Task<IActionResult> GetCar(int id)
        {
            var car = await _ICarService.GetCars();

            return Ok(car);
        }

        // POST: api/Auto
        [HttpPost]
        public async Task<IActionResult> InsertCar([FromBody] CarDto aCar)
        {
            if (ModelState.IsValid && !Object.Equals(aCar, null))
            {
                var car = await this._ICarService.InsertCar(_mapper.Map<Car>(aCar));

                return Ok(_mapper.Map<CarDto>(car));
            }
            return BadRequest(ModelState);
        }

        // PUT: api/Auto/5
        [HttpPut("{id}")]
        public void UpdateCar(int id, [FromBody] CarDto aCar)
        {
            this._ICarService.UpdateCar(_mapper.Map<Car>(aCar));
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void DeleteCar(int id)
        {
            this._ICarService.DeleteCar(id);
        }
    }
}
