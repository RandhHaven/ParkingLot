namespace WebApiServiceEstacionamiento.Models.Controls
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Runtime.Serialization;

    [Table("Gender")]
    [DataContract]
    public class Gender
    {
        [Key]
        public Int64 ID { get; set; }
        public String Name { get; set; }
    }
}