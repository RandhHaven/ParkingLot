namespace WebApiServiceEstacionamiento.Models.Parking
{
    #region Directives
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Runtime.Serialization;
    #endregion

    #region Table
    [Table("Employee")]
    [DataContract]
    public class Employee
    {
        [Key]
        [DataMember]
        [Required]
        [MaxLength(15)]
        public int EmployeeId { get; set; }

        [DataMember]
        [Required]
        [MaxLength(10)]
        public int FileEmployee { get; set; }

        [DataMember]
        [Required]
        [StringLength(200)]
        public string UserEmployee { get; set; }

        [DataMember]
        [Required]
        [StringLength(200)]
        public string NameEmployee { get; set; }

        [DataMember]
        [Required]
        [StringLength(100)]
        public string Surname { get; set; }

        [DataMember]
        [Required]
        [StringLength(200)]
        public string Email { get; set; }

        [DataMember]
        [Required]
        [StringLength(50)]
        public string Mobile { get; set; }

        [DataMember]
        [Required]
        [StringLength(50)]
        public string Phone { get; set; }
    }
    #endregion
}
