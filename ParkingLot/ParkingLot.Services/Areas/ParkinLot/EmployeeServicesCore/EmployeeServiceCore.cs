namespace ParkingLot.Services.Areas.ParkinLot.EmployeeServicesCore
{
    using ParkingLot.Entity.Entitys;
    using System;
    using System.Collections.Generic;

    public class EmployeeServiceCore : IEmployeeServiceCore
    {
        #region Build
        public EmployeeServiceCore()
        { }
        #endregion

        #region Methods
        public List<EmployeeBase> GetListadoEmpleados()
        {
            List<EmployeeBase> listEmpleados = new List<EmployeeBase>();
            try
            {
                listEmpleados = Core.APIS.APIEmployee.GetEmployees("", "https://localhost:5001/api/Employee", "Employee");
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return listEmpleados;
        }

        #endregion
    }
}
