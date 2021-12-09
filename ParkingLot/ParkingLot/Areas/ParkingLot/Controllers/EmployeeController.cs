namespace ParkingLot.Controllers
{
    using ParkingLot.Base;
    using ParkingLot.Services.EmployeeServices;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.Extensions.Logging;

    [Area("ParkingLot")]
    public class EmployeeController : ParkingLotController<EmployeeController>
    {
        #region Properties
        public IEmployeeService _IEmployeeService { get; set; }
        #endregion

        #region Build
        public EmployeeController(ILogger<EmployeeController> logger, IEmployeeService _IEmployeeService) : base(logger, _IEmployeeService)
        {
            this.OnInitialize(logger);
            this._IEmployeeService = _IEmployeeService;
        }
        #endregion

        #region Methods

        public override ViewResult View()
        {
            var employeeVM = _IEmployeeService.GetEmployees();
            return View(employeeVM);
        }

        [HttpGet]
        public ActionResult ViewEmployees()
        {
            var employeeVM = _IEmployeeService.GetEmployees();
            return View(employeeVM);
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult EditEmployee()
        {
            return View();
        }
        #endregion
    }
}
