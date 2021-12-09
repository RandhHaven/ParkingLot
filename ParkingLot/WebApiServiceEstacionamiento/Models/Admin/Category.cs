namespace WebApiServiceEstacionamiento.Models.Admin
{
    using System;
    #region Directives
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Runtime.Serialization;
    #endregion

    #region Table
    [Table("Category")]
    [DataContract]
    public class Category
    {
        [Key]
        [DataMember]
        public Int64 CategoryID { get; set; }

        [DataMember]
        [Required (ErrorMessage = "Field Name is Required.")]
        [StringLength(200)]
        public String NameCategory { get; set; }

        [DataMember]
        [Required]
        [StringLength(200)]
        public String Author { get; set; }

        [DataMember]
        [Required]
        [StringLength(200)]
        public String Tittle { get; set; }

        [DataMember]
        [Required]
        public DateTime? ReleaseDate { get; set; }

        [DataMember]
        [Required]
        public String Orden { get; set; }
    }
    #endregion
}