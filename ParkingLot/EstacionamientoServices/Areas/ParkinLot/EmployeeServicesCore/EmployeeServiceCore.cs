namespace ParkingLot.Services.Areas.ParkinLot.EmployeeServicesCore
{
    using EstacionamientoEntity.Entitys;
    using System;
    using System.Collections.Generic;

    public class EmployeeServiceCore : IEmployeeServiceCore
    {
        #region Build
        public EmployeeServiceCore()
        { }
        #endregion

        #region Methods
        public List<EmployeeBase> GetListadoEmpleadosRec()
        {
            List<EmployeeBase> listEmpleados = new List<EmployeeBase>();
            try
            {
                listEmpleados = EstacionamientoNetCore.APIS.APIEmployee.GetEmployees("", "https://localhost:5001/api/Employee", "Employee");
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return listEmpleados;
        }

        public List<EmployeeBase> GetListadoEmpleados()
        {
            List<EmployeeBase> listEmpleados = new List<EmployeeBase>();

            try
            {
                //unSistemaSolar.Initialize(anios);
                listEmpleados.Add(new EmployeeBase
                {
                    EmployeeId = 1000,
                    Legajo = 150,
                    NameEmployee = "Micaela",
                    Surname = "Perez",
                    Edad = 24,
                    Mobile = "45341223"
                });
                listEmpleados.Add(new EmployeeBase
                {
                    EmployeeId = 1001,
                    Legajo = 151,
                    NameEmployee = "Ignacio",
                    Surname = "Pezzoli",
                    Edad = 34,
                    Mobile = "023-45555443"
                });
                listEmpleados.Add(new EmployeeBase
                {
                    EmployeeId = 1002,
                    Legajo = 152,
                    NameEmployee = "Lidia",
                    Surname = "Ramirez",
                    Edad = 27,
                    Mobile = "154553334"
                });
                listEmpleados.Add(new EmployeeBase
                {
                    EmployeeId = 1003,
                    Legajo = 153,
                    NameEmployee = "Esteban",
                    Surname = "Kenia",
                    Edad = 30,
                    Mobile = "234443434"
                });
                listEmpleados.Add(new EmployeeBase
                {
                    EmployeeId = 1004,
                    Legajo = 154,
                    NameEmployee = "Cristian",
                    Surname = "Scarfo",
                    Edad = 23,
                    Mobile = "234443434-23"
                });
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
