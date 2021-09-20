namespace WebApiServiceEstacionamiento.Entities.Controls
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class DocumentTypes
    {
        [Key]
        public Int64 ID { get; set; }
        public String Abrevation { get; set; }
        public String Description { get; set; }
    }
}
