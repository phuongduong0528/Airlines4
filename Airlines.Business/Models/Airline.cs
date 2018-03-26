namespace Airlines.Business.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Airline")]
    public partial class Airline
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }

        [StringLength(50)]
        public string departure { get; set; }

        [StringLength(50)]
        public string arrival { get; set; }

        public int? age { get; set; }

        [StringLength(50)]
        public string gender { get; set; }

        [StringLength(50)]
        public string cabintype { get; set; }

        public int? q1 { get; set; }

        public int? q2 { get; set; }

        public int? q3 { get; set; }

        public int? q4 { get; set; }

        public int? month { get; set; }

        public int? year { get; set; }
    }
}
