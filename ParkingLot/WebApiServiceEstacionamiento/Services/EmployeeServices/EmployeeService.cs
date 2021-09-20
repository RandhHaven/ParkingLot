namespace WebApiServiceEstacionamiento.Services.EmployeeServices
{
    using Microsoft.EntityFrameworkCore;
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using WebApiServiceEstacionamiento.Entities.Parking;
    using WebApiServiceEstacionamiento.ParkingLotModel;

    public class EmployeeService : IEmployeeService
    {
        #region Properties
        private readonly DatabaseContext _databaseContext;
        #endregion

        #region Builds
        public EmployeeService(DatabaseContext databaseContext)
        {
            _databaseContext = databaseContext
                ?? throw new ArgumentNullException(nameof(databaseContext));
        }
        #endregion

        #region Methods
        public async Task<IEnumerable<Employee>> GetEmployees()
        {
            var employees = _databaseContext.Employees;

            return await Task.Factory.StartNew(() => employees);
        }

        public async Task<Employee> GetEmployeeById(Int64 id)
        {
            var employee = await _databaseContext.Employees.FirstOrDefaultAsync(car => car.EmployeeId == id);

            return employee;
        }

        public async Task<Employee> InsertEmployee(Employee anEmployee)
        {
            await _databaseContext.Employees.AddAsync(anEmployee);
            _databaseContext.SaveChanges();
            return anEmployee;
        }

        public async void UpdateEmployee(Employee anEmployee)
        {
            var result = await this.GetEmployeeById(anEmployee.EmployeeId);
            if (result != null)
            {
                result.Email = anEmployee.Email;
                result.FileEmployee = anEmployee.FileEmployee;
                result.Mobile = anEmployee.Mobile;
                result.Phone = anEmployee.Phone;
                _databaseContext.Employees.Update(result);
                _databaseContext.SaveChanges();
            }
        }
        #endregion
    }
}