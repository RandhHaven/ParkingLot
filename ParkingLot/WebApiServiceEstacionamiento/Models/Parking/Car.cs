namespace WebApiServiceEstacionamiento.Models.Parking
{
    #region Directives
    using System.ComponentModel.DataAnnotations;
    using System;
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
        public Int64 CarId { get; set; }

        [DataMember]
        [Required]
        [StringLength(200)]
        public String Brand { get; set; }

        [DataMember]
        [Required]
        [StringLength(200)]
        public String Model { get; set; }

        [DataMember]
        [Required]
        [StringLength(200)]
        public String Description { get; set; }

        [DataMember]
        [Required]
        [StringLength(50)]
        public String Patent { get; set; }

        [DataMember]
        [Required]
        public int EmployeeId { get; set; }

        [DataMember]
        [StringLength(50)]
        public String Colour { get; set; }

    }
    #endregion
}
