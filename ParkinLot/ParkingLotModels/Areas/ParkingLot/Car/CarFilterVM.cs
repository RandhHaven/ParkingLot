using ParkingLot.Models.Areas.Shared;

namespace ParkingLot.Models.Areas.ParkingLot.Car
{
    public class CarFilterVM : FilterViewModel
    {
        public string Modelo { get; set; }

        public string Marca { get; set; }
    }
}
