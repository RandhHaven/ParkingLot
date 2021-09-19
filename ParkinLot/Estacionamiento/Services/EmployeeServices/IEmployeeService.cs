namespace Estacionamiento.Services.EmployeeServices
{
    using ParkingLot.Models.Areas.ParkingLot.Employee;

    public interface IEmployeeService : TUIService
    {
        EmployeeVM GetEmployees();
    }
}
