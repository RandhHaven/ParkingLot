namespace WebApiServiceEstacionamiento.Models.Controls
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Runtime.Serialization;

    [Table("ModelCar")]
    [DataContract]
    public class ModelCar
    {
        [Key]
        public Int64 ID { get; set; }
        public String NameModel { get; set; }
    }
}
