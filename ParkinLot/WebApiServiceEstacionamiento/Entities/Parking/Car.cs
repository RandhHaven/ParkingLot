namespace WebApiServiceEstacionamiento.Entities.Parking
{
    #region Directives
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Runtime.Serialization;
    #endregion

    #region Table
    [Table("Car")]
    [DataContract]
    public class Car
    {
        [Key]
        [DataMember]
        public int CarId { get; set; }

        [DataMember]
        [Required]
        [StringLength(200)]
        public string Brand { get; set; }

        [DataMember]
        [Required]
        [StringLength(200)]
        public string Model { get; set; }

        [DataMember]
        [Required]
        [StringLength(200)]
        public string Description { get; set; }

        [DataMember]
        [Required]
        [StringLength(50)]
        public string Patent { get; set; }

        [DataMember]
        [Required]
        public int EmployeeId { get; set; }

        [DataMember]
        [StringLength(50)]
        public string Colour { get; set; }

    }
    #endregion
}
