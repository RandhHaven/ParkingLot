namespace WebApiServiceEstacionamiento.Models.Controls
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Runtime.Serialization;

    [Table("BrandCar")]
    [DataContract]
    public class BrandCar
    {
        [Key]
        public Int64 BrandID { get; set; }
        public String NameBrand { get; set; }
        public ModelCar ModelCar { get; set; }
    }
}
