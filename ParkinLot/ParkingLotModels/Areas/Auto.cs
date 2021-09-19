namespace ParkingLot.Models.Areas
{
    using System.ComponentModel.DataAnnotations;

    public class Auto
    {
        #region Properties
        [Required]
        public int IdAuto { get; set; }

        public string Modelo  { get; set; }

        public string Marca { get; set; }

        [MaxLength(50)]
        public string Empleado { get; set; }

        public string Patente { get; set; }

        #endregion
    }
}
