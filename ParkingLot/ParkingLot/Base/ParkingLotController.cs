namespace Estacionamiento.Base
{
    #region Directives
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.Extensions.Logging;
    using System;
    using System.Collections.Generic;
    using Microsoft.AspNetCore.Http;
    using Estacionamiento.Services;
    using ParkingLot.Models.Areas;
    using ParkingLot.Services;
    #endregion

    public abstract class ParkingLotController<T> : Controller
    {
        #region Properties
        public ILogger<T> _logger { get; set; }

        public List<Empleado> ListadoEmpleados
        {
            get
            {
                object o = HttpContext.Session.GetObject<List<Empleado>>("ListadoEmpleados");
                return (Object.Equals(o, null)) ? new List<Empleado>() : (List<Empleado>)o;
            }
            set
            {
                HttpContext.Session.SetObject("ListadoEmpleados", value);
            }
        }

        public List<Auto> ListadoAutos
        {
            get
            {
                object o = HttpContext.Session.GetObject<List<Auto>>("ListadoAutos");
                return (Object.Equals(o, null)) ? new List<Auto>() : (List<Auto>)o;
            }
            set
            {
                HttpContext.Session.SetObject("ListadoAutos", value);
            }
        }

        #endregion

        #region Builds
        protected ParkingLotController(ILogger<T> _logger, TUIService uiService)
        {
        }
        #endregion

        #region Methods

        public virtual void OnInitialize(ILogger<T> logger) { }
      
        #endregion
    }
}