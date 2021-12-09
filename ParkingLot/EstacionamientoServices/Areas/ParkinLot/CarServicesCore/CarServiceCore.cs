namespace ParkingLot.Services.Areas.ParkinLot.CarServicesCore
{
    using ParkingLot.Entity.Entitys;
    using System;
    using System.Collections.Generic;

    public class CarServiceCore : ICarServiceCore
    {
        #region Build
        public CarServiceCore()
        { }
        #endregion

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
    }
}
