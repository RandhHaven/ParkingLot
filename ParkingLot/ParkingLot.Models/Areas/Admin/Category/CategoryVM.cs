namespace ParkingLot.Models.Areas.Admin.Category
{
    using global::ParkingLot.Models.Areas.Shared;
    using System.Collections.Generic;

    public class CategoryVM : ViewModel
    {
        #region Properties
        public List<CategoryDetailVM> List { get; set; }
        #endregion

        #region Build
        public CategoryVM()
        {
            this.List = new List<CategoryDetailVM>();
        }
        #endregion
    }
}
