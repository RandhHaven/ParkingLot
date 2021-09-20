namespace ParkingLot.Models.Areas.Shared.Controls
{
    using System;
    using System.Collections.Generic;

    public class SimpleTablesVM
    {
        public SimpleTablesVM()
        {
            this.Items = new List<SimpleTableVM>();
        }

        public List<SimpleTableVM> Items { get; set; }
    }

    public class SimpleTableVM
    {
        public Int64 ID { get; set; }
        public String Name { get; set; }
    }
}