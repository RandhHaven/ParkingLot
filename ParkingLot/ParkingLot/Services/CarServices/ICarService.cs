namespace ParkingNet.Services.CarServices
{
    using ParkingLot.Models.Areas.ParkingLot.Car;
    using ParkingLot.Services;

    public interface ICarService : TUIService
    {
        CarVM GetAutos();
    }
}
