namespace WebApiServiceEstacionamiento.Entities.Controls
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class Gender
    {
        [Key]
        public Int64 ID { get; set; }
        public String Name { get; set; }
    }
}