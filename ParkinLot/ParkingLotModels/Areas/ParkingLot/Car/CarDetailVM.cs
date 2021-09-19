using ParkingLot.Models.Areas.Shared;

namespace ParkingLot.Models.Areas.ParkingLot.Car
{
    using System.ComponentModel.DataAnnotations;

    public class CarDetailVM : DetailViewModel
    {
        [Required]
        public int IdAuto { get; set; }

        public string Modelo { get; set; }

        public string Marca { get; set; }

        [MaxLength(50)]
        public string Empleado { get; set; }

        public string Patente { get; set; }
    }
}
