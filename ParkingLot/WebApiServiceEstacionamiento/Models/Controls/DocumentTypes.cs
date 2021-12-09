namespace WebApiServiceEstacionamiento.Models.Controls
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Runtime.Serialization;

    [Table("DocumentTypes")]
    [DataContract]
    public class DocumentTypes
    {
        [Key]
        public Int64 ID { get; set; }
        public String Abrevation { get; set; }
        public String Description { get; set; }
    }
}
