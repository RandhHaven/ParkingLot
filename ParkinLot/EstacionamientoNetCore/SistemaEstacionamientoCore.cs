namespace EstacionamientoNetCore
{
    #region Assemblies
    using EstacionamientoEntity.Entitys;
    using System;
    using System.Collections.Generic;
    #endregion

    #region Class Core
    public class SistemaEstacionamientoCore : ISistemaEstacionamientoCore
    {
        public SistemaEstacionamientoCore()
        {
        }

        public void Inicializar()
        {
            this.GetListadoAutos();
        }

        public List<CarBase> GetListadoAutos()
        {
            List<CarBase> listAutos = new List<CarBase>();

            try
            {
                listAutos.Add(new CarBase
                {
                    IdAuto = 1000,
                    Patente = "CBC345",
                    Marca = "Honda",
                    Modelo = "HR-V",
                    Empleado = "Empleado 1"
                });
                listAutos.Add(new CarBase
                {
                    IdAuto = 1001,
                    Patente = "ORMR445",
                    Marca = "Renault",
                    Modelo = "Kangoo",
                    Empleado = "Empleado 2"
                });
                listAutos.Add(new CarBase
                {
                    IdAuto = 1002,
                    Patente = "XCE984",
                    Marca = "Chevrolet",
                    Modelo = "Prisma",
                    Empleado = "Empleado 3"
                });
                listAutos.Add(new CarBase
                {
                    IdAuto = 1003,
                    Patente = "MUJ234",
                    Marca = "Chevrolet",
                    Modelo = "Cruze",
                    Empleado = "Empleado 4"
                });
                listAutos.Add(new CarBase
                {
                    IdAuto = 1004,
                    Patente = "ORZ903",
                    Marca = "Fiat",
                    Modelo = "Punto",
                    Empleado = "Empleado 5"
                });
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return listAutos;
        }

        public List<EmployeeBase> GetListadoEmpleadosRec()
        {
            List<EmployeeBase> listEmpleados = new List<EmployeeBase>();            
            try
            {
                listEmpleados = APIS.APIEmployee.GetEmployees("", "", "Employee");
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

            return listEmpleados;
        }


        public string EliminarAuto(int idAuto)
        {
            try
            {
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return String.Empty;
        }

        public string CrearAuto()
        {
            try
            {

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return String.Empty;
        }

        public string EditarAuto(int idAuto)
        {
            try
            {

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return String.Empty;
        }

        public string EliminarEmpleado(int idEmpleado)
        {
            try
            {
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return String.Empty;
        }

        public string CrearEmpleado()
        {
            try
            {

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return String.Empty;
        }

        public string EditarEmpleado(int idEmpleado)
        {
            try
            {

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return String.Empty;
        }
    }
    #endregion
}
