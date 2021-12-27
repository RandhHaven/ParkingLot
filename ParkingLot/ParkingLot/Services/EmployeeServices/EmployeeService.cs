namespace ParkingNet.Services.EmployeeServices
{
    using ParkingLot.Entity.Entitys;
    using ParkingLot.Models.Areas.ParkingLot.Employee;
    using ParkingLot.Services.Areas.ParkinLot.EmployeeServicesCore;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class EmployeeService : IEmployeeService
    {
        #region Properties
        public IEmployeeServiceCore _core { get; set; }
        #endregion

        #region Builds
        public EmployeeService(IEmployeeServiceCore core)
        {
            _core = core;
        }
        #endregion

        #region Methods

        public EmployeeVM GetEmployees()
        {
            EmployeeVM employeeVM = new EmployeeVM();
            List<EmployeeDetailVM> listEmployee = new List<EmployeeDetailVM>();
            try
            {
                var listEmpleadoBase = _core.GetListadoEmpleados();
                this.GetEmpleadoMappping(listEmpleadoBase, ref listEmployee);
            }
            catch (Exception ex)
            {
            }
            employeeVM.List = listEmployee;
            return employeeVM;
        }

        public void GetEmpleadoMappping(List<EmployeeBase> listaBase, ref List<EmployeeDetailVM> lista)
        {
            try
            {
                if (!Object.Equals(listaBase, null) && listaBase.Any())
                {
                    lista = listaBase.ConvertAll(sist => new EmployeeDetailVM
                    {
                        IdEmpleado = sist.EmployeeId,
                        Legajo = sist.Legajo,
                        Nombre = sist.NameEmployee,
                        Apellido = sist.Surname,
                        Edad = sist.Edad,
                        NroCelular = sist.Mobile
                    });
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion
    }
}
