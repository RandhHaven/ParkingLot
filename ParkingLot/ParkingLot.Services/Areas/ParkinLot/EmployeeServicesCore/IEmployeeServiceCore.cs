namespace ParkingLot.Services.Areas.ParkinLot.EmployeeServicesCore
{
    using ParkingLot.Entity.Entitys;
    using ParkingLot.Services.Areas.Shared;
    using System.Collections.Generic;

    public interface IEmployeeServiceCore : TUIService
    {
        List<EmployeeBase> GetListadoEmpleados();
    }
}
