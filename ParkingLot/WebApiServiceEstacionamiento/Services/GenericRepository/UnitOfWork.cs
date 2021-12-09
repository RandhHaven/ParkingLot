namespace WebApiServiceEstacionamiento.Services.GenericRepository
{
    using System;
    using WebApiServiceEstacionamiento.ParkingLotModel;
    using WebApiServiceEstacionamiento.Services.CategoryServices;

    public class UnitOfWork : IUnitOfWork
    {
        public ICategoryRepository _ICategoryRepository { get; set; }

        private readonly DatabaseContext _databaseContext;

        public UnitOfWork(DatabaseContext databaseContext)
        {            
            this._databaseContext = databaseContext ?? throw new ArgumentNullException(nameof(databaseContext));
            this._ICategoryRepository = new CategoryRepository(this._databaseContext);
        }

        public void Dispose()
        {
            this._databaseContext.Dispose();
        }

        public void Commit()
        {
            this._databaseContext.SaveChanges();
        }
    }
}