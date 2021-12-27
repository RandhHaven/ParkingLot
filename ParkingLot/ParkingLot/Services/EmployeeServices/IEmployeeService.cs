namespace ParkingNet.Services.EmployeeServices
{
    using ParkingLot.Models.Areas.ParkingLot.Employee;
    using ParkingLot.Services;

    public interface IEmployeeService : TUIService
    {
        EmployeeVM GetEmployees();
    }
}
