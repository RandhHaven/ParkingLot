namespace WebApiServiceEstacionamiento.Services.CarServices
{
    using System.Threading.Tasks;
    using WebApiServiceEstacionamiento.Entities.Parking;
    using System.Collections.Generic;
    using System;

    public interface ICarService : TUIService
    {
        Task<IEnumerable<Car>> GetCars();
        Task<Car> InsertCar(Car aCar);
        void UpdateCar(Car aCar);
        void DeleteCar(Int64 carId);
    }
}
