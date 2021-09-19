namespace ParkingLot.Services.Areas.ParkinLot.EmployeeServicesCore
{
    using EstacionamientoEntity.Entitys;
    using ParkingLot.Services.Areas.Shared;
    using System.Collections.Generic;

    public interface IEmployeeServiceCore : TUIService
    {
        List<EmployeeBase> GetListadoEmpleadosRec();
        List<EmployeeBase> GetListadoEmpleados();
    }
}
