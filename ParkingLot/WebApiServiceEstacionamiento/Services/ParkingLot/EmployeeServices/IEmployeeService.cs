namespace WebApiServiceEstacionamiento.Services.ParkingLot.EmployeeServices
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using WebApiServiceEstacionamiento.Models.Parking;

    public interface IEmployeeService : TUIService
    {
        Task<IEnumerable<Employee>> GetEmployees();

        void UpdateEmployee(Employee anEmployee);

        Task<Employee> GetEmployeeById(Int64 id);

        Task<Employee> InsertEmployee(Employee anEmployee);
    }
}
