namespace ParkingLot.Controllers
{
    using ParkingLot.Base;
    using ParkingLot.Services.CarServices;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.Extensions.Logging;
    using ParkingLot.Models.Areas.ParkingLot.Car;
    using System;

    [Area("ParkingLot")]
    public class CarController : ParkingLotController<CarController>
    {
        #region Properties
        public ICarService _ICarService { get; set; }
        #endregion

        #region Builds
        public CarController(ILogger<CarController> logger, ICarService _ICarService): base(logger, _ICarService)
        {
            this.OnInitialize(logger);
            this._ICarService = _ICarService;
        }
        #endregion

        #region Methods
        public override ViewResult View()
        {
            var Carvm = _ICarService.GetAutos();
            return View(Carvm);
        }

        [HttpGet]
        public ActionResult ViewCars()
        {
            var Carvm = _ICarService.GetAutos();
            return View(Carvm);
        }

        [HttpGet]
        public ActionResult GetCars()
        {
            var CarVM = _ICarService.GetAutos();
            return Json(new { data = CarVM.List });            
        }

        public override void OnInitialize(ILogger<CarController> logger)
        {
            base.OnInitialize(logger);
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult EditCar(Int64 data)
        {
            return View();
        }
        #endregion

    }
}
