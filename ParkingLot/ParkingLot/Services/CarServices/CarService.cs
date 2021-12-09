namespace ParkingLot.Services.CarServices
{
    using ParkingLot.Entity.Entitys;
    using ParkingLot.Models.Areas.ParkingLot.Car;
    using ParkingLot.Services.Areas.ParkinLot.CarServicesCore;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class CarService : ICarService
    {
        #region Properties
        public ICarServiceCore _core { get; set; }
        #endregion

        #region Builds
        public CarService(ICarServiceCore core)
        {
            _core = core;
        }
        #endregion

        public CarVM GetAutos()
        {
            CarVM carVM = new CarVM();
            List<CarDetailVM> listCar = new List<CarDetailVM>();
            try
            {
                var listCarBase = _core.GetListadoAutos();
                this.GetAutoMappping(listCarBase, ref listCar);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            carVM.List = listCar;
            return carVM;
        }

        public void GetAutoMappping(List<CarBase> listaBase, ref List<CarDetailVM> lista)
        {
            try
            {
                if (!Object.Equals(listaBase, null) && listaBase.Any())
                {
                    lista = listaBase.ConvertAll(sist => new CarDetailVM
                    {
                        IdAuto = sist.IdAuto,
                        Marca = sist.Marca,
                        Modelo = sist.Modelo,
                        Patente = sist.Patente,
                        Empleado = sist.Empleado
                    });
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
