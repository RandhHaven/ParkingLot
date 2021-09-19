namespace ParkingLot.Models.Areas.ParkingLot.Car
{
    using global::ParkingLot.Models.Areas.Shared;
    using System.Collections.Generic;

    public class CarVM : ViewModel
    {
        #region Properties
        public CarFilterVM CarFilter { get; set; }
        public CarDetailVM CarDetail { get; set; }
        public List<CarDetailVM> List { get; set; }
        #endregion

        #region Build
        public CarVM()
        {
            this.CarFilter = new CarFilterVM();
            this.CarDetail = new CarDetailVM();
            this.List = new List<CarDetailVM>();
        }
        #endregion
    }
}
