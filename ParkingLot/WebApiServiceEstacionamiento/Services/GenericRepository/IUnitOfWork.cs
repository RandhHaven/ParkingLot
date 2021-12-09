namespace WebApiServiceEstacionamiento.Services.GenericRepository
{
    using System;
    using WebApiServiceEstacionamiento.Services.CategoryServices;

    public interface IUnitOfWork : IDisposable
    {
        ICategoryRepository _ICategoryRepository { get; set; }
    }
}
