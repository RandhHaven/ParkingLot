using ParkingLot.Models.Areas.Shared;

namespace ParkingLot.Models.Areas.ParkingLot.Employee
{    
    using System.ComponentModel.DataAnnotations;

    public class EmployeeFilterVM : FilterViewModel
    {
        public int Legajo { get; set; }

        [MaxLength(100)]
        public string Nombre { get; set; }

        [MaxLength(100)]
        public string Apellido { get; set; }
    }
}
