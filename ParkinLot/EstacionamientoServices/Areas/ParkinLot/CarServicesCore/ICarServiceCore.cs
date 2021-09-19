namespace ParkingLot.Services.Areas.ParkinLot.CarServicesCore
{
    using EstacionamientoEntity.Entitys;
    using ParkingLot.Services.Areas.Shared;
    using System.Collections.Generic;

    public interface ICarServiceCore : TUIService
    {
        List<CarBase> GetListadoAutos();
    }
}
