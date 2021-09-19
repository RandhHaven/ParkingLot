using ParkingLot.Models.Areas.Shared;

namespace ParkingLot.Models.Areas.ParkingLot.Employee
{
    using System.ComponentModel.DataAnnotations;

    public class EmployeeDetailVM : DetailViewModel
    {
        #region Properties
        [Required]
        public int IdEmpleado { get; set; }

        public int Legajo { get; set; }

        [MaxLength(100)]
        public string Nombre { get; set; }

        [MaxLength(100)]
        public string Apellido { get; set; }

        public byte Edad { get; set; }

        public string NroCelular { get; set; }

        public string Email { get; set; }
        #endregion
    }
}
