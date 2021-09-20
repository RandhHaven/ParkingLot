namespace WebApiServiceEstacionamiento.Controllers
{
    using AutoMapper;
    #region Directives
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.Extensions.Logging;
    using System.Collections.Generic;
    using System.Linq;
    using WebApiServiceEstacionamiento.Entities;
    using WebApiServiceEstacionamiento.Services;
    #endregion

    public abstract class WebApiControllers<T> : ControllerBase
    {
        #region Builds
        protected WebApiControllers(ILogger<T> logger, TUIService uIService, IMapper _mapper)
        {
        }

        #endregion

        #region Methods

        #endregion
    }
}
