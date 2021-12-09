namespace WebApiServiceEstacionamiento.Controllers
{
    #region Directives
    using AutoMapper;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.Extensions.Logging;
    using WebApiServiceEstacionamiento.Services;
    using WebApiServiceEstacionamiento.Services.GenericRepository;
    #endregion

    public abstract class WebApiControllers<T> : ControllerBase
    {
        #region Builds
        protected WebApiControllers(ILogger<T> logger, TUIService uIService, IMapper _mapper)
        {
        }

        protected WebApiControllers(IUnitOfWork uIService)
        {
        }

        #endregion

        #region Methods

        #endregion
    }
}
