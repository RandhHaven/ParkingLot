namespace Estacionamiento.Areas.Client.Controllers
{
    using System;
    using System.Diagnostics;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.Extensions.Logging;
    using Estacionamiento.Base;
    using Estacionamiento.Services.EmployeeServices;
    using ParkingLot.Models.Areas;

    [Area("Client")]
    public class HomeController : ParkingLotController<HomeController>
    {
       
        public HomeController(ILogger<HomeController> logger, IEmployeeService _IEmployeeService) : base(logger, _IEmployeeService)
        {
            this.OnInitialize(logger);
        }

        public override void OnInitialize(ILogger<HomeController> logger)
        {
            this._logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [HttpGet]
        public ActionResult ViewEditarEmpleado()
        {
            try
            {
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                throw ex;
            }
            return View();
        }

        [HttpPost]
        public ActionResult ViewEditarEmpleado(int idEmpleado)
        {
            try
            {
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                throw ex;
            }
            return View();
        }

        
        [HttpGet]
        public ActionResult ViewCrearEmpleado()
        {
            try
            {
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                throw ex;
            }
            return View();
        }

        [HttpGet]
        public ActionResult ViewEliminarEmpleado(int idEmpleado)
        {
            try
            {
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                throw ex;
            }
            return View();
        }

        [HttpGet]
        public ActionResult ViewEditarAuto(int idAuto)
        {
            try
            {
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                throw ex;
            }
            return View();
        }

        [HttpGet]
        public ActionResult ViewCrearAuto()
        {
            try
            {
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                throw ex;
            }
            return View();
        }

        [HttpPost]
        public ActionResult ViewEliminarAuto(int idAuto)
        {
            try
            {
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                throw ex;
            }
            return View();
        }

        [HttpGet]
        public ActionResult ViewEliminarAuto()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
