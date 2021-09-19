namespace ParkingLot.Models.Areas
{
    public class Empleado
    {
        #region Properties

        public int IdEmpleado { get; set; }

        public int Legajo { get; set; }

        public string Nombre { get; set; }

        public string Apellido { get; set; }

        public byte Edad { get; set; }

        public string NroCelular { get; set; }

        public string Email { get; set; }
        #endregion
    }
}
