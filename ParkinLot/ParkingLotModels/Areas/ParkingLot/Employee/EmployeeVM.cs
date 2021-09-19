namespace ParkingLot.Models.Areas.ParkingLot.Employee
{
    using global::ParkingLot.Models.Areas.Shared;
    using System.Collections.Generic;

    public class EmployeeVM : ViewModel
    {
        #region Properties
        public EmployeeFilterVM EmployeeFilter { get; set; }
        public EmployeeDetailVM EmployeeDetail { get; set; }
        public List<EmployeeDetailVM> List { get; set; }
        #endregion

        #region Build
        public EmployeeVM()
        {
            this.EmployeeFilter = new EmployeeFilterVM();
            this.EmployeeDetail = new EmployeeDetailVM();
            this.List = new List<EmployeeDetailVM>();
        }
        #endregion
    }
}
