namespace WebApiServiceEstacionamiento.Services.ParkingLot.CarServices
{
    using System.Threading.Tasks;
    using WebApiServiceEstacionamiento.Models.Parking;
    using WebApiServiceEstacionamiento.ParkingLotModel;
    using System.Collections.Generic;
    using System;
    using System.Linq;
    using Microsoft.EntityFrameworkCore;

    public class CarService : ICarService
    {
        #region Properties
        private readonly DatabaseContext _databaseContext;
        #endregion

        #region Builds
        public CarService(DatabaseContext databaseContext)
        {
            _databaseContext = databaseContext
                 ?? throw new ArgumentNullException(nameof(databaseContext));
        }
        #endregion

        #region Methods
        public async Task<IEnumerable<Car>> GetCars()
        {
            var cars = _databaseContext.Cars;
            return await Task.Factory.StartNew(() => cars);
        }

        public async Task<Car> GetCar(Int64 idCar)
        {
            var car = await _databaseContext.Cars.FirstOrDefaultAsync(car => car.CarId == idCar);

            return car;
        }

        public async Task<Car> InsertCar(Car aCar)
        {
            await _databaseContext.Cars.AddAsync(aCar);
            _databaseContext.SaveChanges();
            return aCar;
        }

        public async void UpdateCar(Car aCar)
        {
            var result = await this.GetCar(aCar.CarId);
            if (result != null)
            {
                result.Brand = aCar.Brand;
                result.Colour = aCar.Colour;
                result.Description = aCar.Description;
                _databaseContext.Cars.Update(result);
                _databaseContext.SaveChanges();
            }
        }

        public async void DeleteCar(Int64 carId)
        {
            var result = await this.GetCar(carId);
            if (result != null)
            {
                _databaseContext.Cars.Remove(result);
                _databaseContext.SaveChanges();
            }
        }
        #endregion

    }
}
