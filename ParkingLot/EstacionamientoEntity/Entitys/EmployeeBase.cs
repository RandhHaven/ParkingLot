namespace ParkingLot.Entity.Entitys
{
    using System;

    [Serializable]
    public class EmployeeBase : EntityBaseClass
    {
        #region Properties

        public int EmployeeId { get; set; }

        public int Legajo { get; set; }

        public string UserEmployee { get; set; }

        public string NameEmployee { get; set; }

        public string Surname { get; set; }

        public byte Edad { get; set; }

        public string Mobile { get; set; }

        public string Phone { get; set; }

        public string Email { get; set; }
        #endregion
    }
}
