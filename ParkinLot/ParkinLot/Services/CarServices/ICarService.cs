namespace Estacionamiento.Services.CarServices
{
    using ParkingLot.Models.Areas.ParkingLot.Car;

    public interface ICarService : TUIService
    {
        CarVM GetAutos();
    }
}
